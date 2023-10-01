using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommand
    {
        //Customer
        public string CustomerId { get; set; }

        // Trip
        public string TripId { get; set; }

        //Store
        public string StoreId { get; set; }

        // order
        public double TotalPrice { get; set; }
        public string? OrderTokenQR { get; set; }
    }
}
