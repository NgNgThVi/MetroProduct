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
    public class UpdateUserCommandValidator : AbstractValidator<UpdateUserCommand>
    {
        private IUserRepository _userRepository;
        public UpdateUserCommandValidator(IUserRepository userRepository)
        {
            RuleFor(p => p.Id)
                .NotNull()
                .MustAsync(UserIdMusBeExist);

            RuleFor(p => p.NewUserName)
                .NotEmpty().WithMessage("{UserName} is required")
                .NotNull()
                .MaximumLength(100).WithMessage("{UserName} must be fewer than 100 characters");

            RuleFor(p => p.NewPassword)
                .NotEmpty().WithMessage("Password is required")
                .NotNull()
                .MaximumLength(50).WithMessage("Password must be fewer than 50 characters")
                .Matches(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@#$%^&+=!]).+$")
                .WithMessage("Password must contain at least one lowercase letter, one uppercase letter, one digit, and one special character.");

            RuleFor(p => p.NewEmail)
                .NotEmpty().WithMessage("Email is required")
                .NotNull()
                .MaximumLength(100).WithMessage("Email must be fewer than 100 characters")
                .Matches(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")
                .WithMessage("Invalid email address");

            RuleFor(p => p.NewPhone)
                .NotEmpty().WithMessage("Phone number is required")
                .NotNull()
                .Matches(@"^\d{10}$")
                .WithMessage("Invalid phone number");

            RuleFor(p => p.NewAddress)
                .NotEmpty().WithMessage("Address is required")
                .NotNull()
                .MaximumLength(100).WithMessage("Address must be fewer than 100 chrarcters");

            RuleFor(q => q)
                .MustAsync(UserEmailUnique)
                .WithMessage("Email type already exists");

            this._userRepository = userRepository;
        }

        private async Task<bool> UserIdMusBeExist(Guid idCommand, CancellationToken token)
        {
            var userGetById = await _userRepository.GetByIdAsync(idCommand);
            return userGetById != null;
        }

        private Task<bool> UserEmailUnique(UpdateUserCommand command, CancellationToken token)
        {
            return _userRepository.IsUserEmailUnique(command.NewEmail);
        }
    }
}
