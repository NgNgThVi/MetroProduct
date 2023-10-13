using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Contracts.Logging;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Application.Features.Customers.Commands.CreateCustomer;
using MetroDelivery.Application.Features.Customers.Queries.GetAllCustomers;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Domain.IdentityModels;
using Microsoft.AspNetCore.Identity;

namespace MetroDelivery.Application.Features.Customers.Commands.CreateCustomer
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Guid>
    {
        /*private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public CreateCustomerCommandHandler(IMapper mapper, ICustomerRepository customerRepository, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }*/
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        private readonly IAppLogger<GetListCustomerQuery> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public CreateCustomerCommandHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper, IAppLogger<GetListCustomerQuery> logger,
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            // check email
            var emailExist = await _userManager.FindByEmailAsync(request.Email);
            if (emailExist != null) {
                throw new BadRequestException("The username already exists!");
            }
            // validate incoming data
            var validator = new CreateUserCommandValidator(/*_customerRepository*/);
            var validatorResult = await validator.ValidateAsync(request);
            if (validatorResult.Errors.Any()) {
                throw new BadRequestException("Invalid Create user", validatorResult);
            }

            var user = new ApplicationUser
            {
                Email = request.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                EmailConfirmed = true,
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded) {
                await _userManager.AddToRoleAsync(user, "EndUser");
                await _signInManager.SignInAsync(user, isPersistent: false);
            }
            else {
                throw new BadRequestException("Account creation failed !");
            }

            var customer = new Customer
            {
                Phone = request.Phone,
                Address = request.Address,
                /*Birthday = request.Birthday,*/
                ApplicationUserId = user.Id,
            };



            // add to database
            /*await _customerRepository.CreateAsync(customer);*/
            _metroPickUpDbContext.Customer.Add(customer);
            await _metroPickUpDbContext.SaveChangesAsync();

            // return record id
            return customer.Id;
        }

    }
}
