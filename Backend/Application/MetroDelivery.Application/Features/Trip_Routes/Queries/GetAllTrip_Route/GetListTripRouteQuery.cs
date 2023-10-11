using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Trip_Routes.Queries.GetAllTrip_Route
{
    public class GetListTripRouteQuery : IRequest<List<TripRouteResponse>>
    {
    }
}
