using MetroDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Orders.Queries
{
    public class OrderResponse
    {
        public Guid OrderId { get; set; }
        //Customer
        public Guid CustomerId { get; set; }

        // Trip
        public Guid TripId { get; set; }

        //Store
        public Guid StoreId { get; set; }


        // order
        public string? OrderTokenQR { get; set; }
        public double? TotalPrice { get; set; }

        public Customer? CustomerData { get; set; }
        public Trip? TripData { get; set; }
        public Store? StoreData { get; set; }
    }
}
