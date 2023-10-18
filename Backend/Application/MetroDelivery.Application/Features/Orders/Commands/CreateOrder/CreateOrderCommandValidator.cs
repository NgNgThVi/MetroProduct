/*using FluentValidation;

namespace MetroDelivery.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(p => p.TotalPrice)
            .GreaterThanOrEqualTo(0).WithMessage("{Price} must be greater than or equal to 0");

        }
    }
}
*/