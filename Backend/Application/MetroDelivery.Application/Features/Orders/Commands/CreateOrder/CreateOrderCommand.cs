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
        public Guid CustomerId { get; set; }

        // Trip
        public Guid TripId { get; set; }

        //Store
        public Guid StoreId { get; set; }

        
        // order
        public string? OrderTokenQR { get; set; }
        public double? TotalPrice { get; set; }
    }
    
}
