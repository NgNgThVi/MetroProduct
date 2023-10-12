using FluentValidation;
using MetroDelivery.Application.Features.OrderDetails.Commands.CreateOrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
