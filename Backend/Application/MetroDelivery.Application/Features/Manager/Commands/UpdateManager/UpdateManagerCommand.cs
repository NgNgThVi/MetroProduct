using AutoMapper;
using FluentValidation;
using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Contracts.Logging;
using MetroDelivery.Application.Features.Customers.Commands.UpdateCustomer;
using MetroDelivery.Domain.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Manager.Commands.UpdateManager
{
    public class UpdateManagerCommand : IRequest<MetroPickUpResponse>
    {
        public string Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public string StoreId { get; set; }
    }

    public class UpdateManagerCommandHandler : IRequestHandler<UpdateManagerCommand, MetroPickUpResponse>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public UpdateManagerCommandHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper,
            UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        public async Task<MetroPickUpResponse> Handle(UpdateManagerCommand request, CancellationToken cancellationToken)
        {
            // validate incoming data
            var staff = await _metroPickUpDbContext.ApplicationUsers.Where(c => c.Id == request.Id).SingleOrDefaultAsync();
            if (staff == null) {
                throw new NotFoundException("Manager does not exist !");
            }
            else if (staff.EmailConfirmed == false) {
                throw new NotFoundException("The Manager have been deleted");
            }
            var validator = new UpdateManagerCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Any()) {

                throw new BadRequestException("Invalid Manager", validationResult);
            }

            staff.PhoneNumber = request.Phone;
            staff.Birthday = request.Birthday;
            staff.Address = request.Address;
            staff.FirstName = request.FirstName;
            staff.LastName = request.LastName;
            staff.StoreId = Guid.Parse(request.StoreId);


            // add database
            _metroPickUpDbContext.ApplicationUsers.Update(staff);
            await _metroPickUpDbContext.SaveChangesAsync();


            var user = await _userManager.FindByIdAsync(staff.Id);
            if (user != null) {
                var userRoles = await _userManager.GetRolesAsync(user);
                // Xóa role hiện tại
                await _userManager.RemoveFromRolesAsync(user, userRoles);
                //Add role mới vào
                await _userManager.AddToRoleAsync(user, "Manager");
            }

            // return
            return new MetroPickUpResponse
            {
                Message = "Update Manager Successfully"
            };
        }
    }

    public class UpdateManagerCommandValidator : AbstractValidator<UpdateManagerCommand>
    {

        public UpdateManagerCommandValidator()
        {

            RuleFor(p => p.FirstName)
                .NotEmpty().WithMessage("{FirstName} is required")
                .NotNull()
                .MaximumLength(10).WithMessage("{FirstName} must be fewer than 10 characters");

            RuleFor(p => p.LastName)
                .NotEmpty().WithMessage("{LastName} is required")
                .NotNull()
                .MaximumLength(10).WithMessage("{LastName} must be fewer than 10 characters");

            RuleFor(p => p.Phone)
                .NotEmpty().WithMessage("Phone number is required")
                .NotNull()
                .Matches(@"^\d{10}$")
                .WithMessage("Invalid phone number");

            RuleFor(p => p.Address)
                .NotEmpty().WithMessage("Address is required")
                .NotNull()
                .MaximumLength(100).WithMessage("Address must be fewer than 100 chrarcters");

        }
    }
}
