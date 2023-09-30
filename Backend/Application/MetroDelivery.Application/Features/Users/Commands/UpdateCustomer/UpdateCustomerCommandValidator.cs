using FluentValidation;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Application.Features.Users.Commands.CreateUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Users.Commands.UpdateUser
{
    public class UpdateCustomerCommandValidator : AbstractValidator<UpdateCustomerCommand>
    {
        private ICustomerRepository _customerRepository;
        public UpdateCustomerCommandValidator(ICustomerRepository customerRepository)
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


            this._customerRepository = customerRepository;
        }
    }
}
