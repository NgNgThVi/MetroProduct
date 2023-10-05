using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommand : IRequest<MetroPickUpResponse>
    {
        //Customer
        public string CustomerId { get; set; } = null!;

        // Trip
        public string TripId { get; set; } = null!;

        //Store
        public string StoreId { get; set; } = null!;

        public List<ProductAndQuantity>? ProductAndQuantity { get; set; }
        // order
        public string? OrderTokenQR { get; set; }
    }
    public class ProductAndQuantity
    {
        public string ProductId { get; set; } = null!;
        public int Quantity { get; set; } = 0;
    }
}
