using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Domain.IdentityModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Users.Commands.CreateUser
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Guid>
    {
        private readonly IMapper _mapper;
        private readonly ICustomerRepository _customerRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public CreateCustomerCommandHandler(IMapper mapper, ICustomerRepository customerRepository, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            this._mapper = mapper;
            this._customerRepository = customerRepository;
            this._userManager = userManager;
            this._roleManager = roleManager;
            this._signInManager = signInManager;
        }

        public async Task<Guid> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            // check email
            var emailExist = await _userManager.FindByEmailAsync(request.Email);
            if (emailExist != null) {
                throw new BadRequestException("The username already exists!");
            }
            // validate incoming data
            var validator = new CreateUserCommandValidator(_customerRepository);
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
                Birthday = request.Birthday,
                ApplicationUserId = user.Id,
            };

            

            // add to database
            await _customerRepository.CreateAsync(customer);

            // return record id
            return customer.Id;
        }

    }
}
