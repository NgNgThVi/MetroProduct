using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Domain.Entities;

namespace MetroDelivery.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<MetroPickUpResponse>
    {
        public Product Product { get; set; } = null!;
    }
}
