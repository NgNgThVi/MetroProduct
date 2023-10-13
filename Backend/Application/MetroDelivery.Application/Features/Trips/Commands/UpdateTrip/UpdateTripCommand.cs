using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Features.Trips.Commands.CreateTrip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Trips.Commands.UpdateTrip
{
    public class UpdateTripCommand : IRequest<MetroPickUpResponse>
    {
        public Guid TripId { get; set; }
        public string TripName { get; set; }
        public DateTime TripStartTime { get; set; }
        public DateTime TripEndTime { get; set; }
        public Guid RouteId { get; set; }
    }
}
