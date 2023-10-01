using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Contracts.Logging;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Domain.IdentityModels;
using Microsoft.AspNetCore.Identity;

namespace MetroDelivery.Application.Features.Customers.Commands.UpdateCustomer
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;
        private readonly IAppLogger<UpdateCustomerCommand> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UpdateCustomerCommandHandler(IMapper mapper, ICustomerRepository userRepository, IAppLogger<UpdateCustomerCommand> logger,
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _mapper = mapper;
            _customerRepository = userRepository;
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<Unit> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            // validate incoming data
            var customer = await _customerRepository.CustomerIdMusBeExist(request.CustomerId);
            if (customer == null) {
                throw new NotFoundExcrption("Customer does not exist !");
            }
            else if (customer.IsDelete == true) {
                throw new NotFoundExcrption("The customer have been deleted");
            }
            var validator = new UpdateCustomerCommandValidator(_customerRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any()) {
                _logger.LogWarning("Validation errors in update for {0} - {1}", nameof(Customer), request.CustomerId);
                throw new BadRequestException("Invalid Customer", validationResult);
            }

            customer.Phone = request.Phone;
            customer.Birthday = request.Birthday;
            customer.Address = request.Address;

            if (customer.ApplicationUser != null) {
                customer.ApplicationUser.FirstName = request.FirstName;
                customer.ApplicationUser.LastName = request.LastName;
            }

            // add database
            await _customerRepository.UpdateAsync(customer);


            var user = await _userManager.FindByIdAsync(customer.ApplicationUser.Id);
            if (user != null) {
                var userRoles = await _userManager.GetRolesAsync(user);
                // Xóa role hiện tại
                await _userManager.RemoveFromRolesAsync(user, userRoles);
                //Add role mới vào
                await _userManager.AddToRoleAsync(user, "EndUser");
            }

            // return
            return Unit.Value;
        }
    }
}
