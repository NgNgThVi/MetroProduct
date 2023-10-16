using FluentValidation;
using System;

namespace MetroDelivery.Application.Features.Products.Commands.UpdateProducts
{
    public class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
            RuleFor(p => p.ProductId)
                .NotEmpty().WithMessage("{ProductId} is required")
                .NotNull().WithMessage("{ProductId} cannot be null")
                .Must(BeValidGuid).WithMessage("Invalid {ProductId}");

            RuleFor(p => p.CategoryID)
                .NotEmpty().WithMessage("{CategoryID} is required")
                .NotNull().WithMessage("{CategoryID} cannot be null")
                .Must(BeValidGuid).WithMessage("Invalid {CategoryID}");

            RuleFor(p => p.ProductName)
                .NotEmpty().WithMessage("{ProductName} is required")
                .NotNull()
                .MaximumLength(100).WithMessage("{ProductName} must be fewer than 100 characters");

            RuleFor(p => p.ProductDescription)
                .MaximumLength(500).WithMessage("{ProductDescription} must be fewer than 500 characters");

            RuleFor(p => p.Price)
                .GreaterThanOrEqualTo(0).WithMessage("{Price} must be greater than or equal to 0");

            RuleFor(p => p.Image)
                .MaximumLength(255).WithMessage("{Image} must be fewer than 255 characters");

        }

        private bool BeValidGuid(Guid guid)
        {
            return Guid.TryParse(guid.ToString(), out _);
        }
    }
}
