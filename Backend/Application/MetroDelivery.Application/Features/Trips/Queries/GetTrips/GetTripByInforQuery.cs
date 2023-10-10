using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Trips.Queries.GetTrips
{
    public class GetTripByInforQuery : IRequest<TripResponse>
    {
        public string TripName { get; set; }
        public string TripStartTime { get; set; }
        public string TripEndTime { get; set;}
    }
}
