using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Trips.Queries
{
    public class TripDto
    {
        public Guid Id { get; set; }
        public string TripName { get; set; }
        public DateTime TripStartTime { get; set; }
        public DateTime TripEndTime { get; set; }
    }
}
