using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Interface;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Application.Features.Trip_Routes.Queries.GetAllTrip_Route
{
    public class GetListTripRouteQueryHandler : IRequestHandler<GetListTripRouteQuery, List<TripRouteResponse>>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public GetListTripRouteQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<List<TripRouteResponse>> Handle(GetListTripRouteQuery request, CancellationToken cancellationToken)
        {
            var tripRoute = await _metroPickUpDbContext.Trip_Routes.Where(s => !s.IsDelete)
                                .Join(
                                    _metroPickUpDbContext.Trips,
                                    tripAndRoute => tripAndRoute.TripID,
                                    trip => trip.Id,
                                    (tripAndRoute, trip) => new
                                    {
                                        Trip_Routes = tripAndRoute,
                                        Trips = trip
                                    }
                                )
                                .Join(
                                    _metroPickUpDbContext.Routes,
                                    combined => combined.Trip_Routes.RouteID,
                                    route => route.Id,
                                    (combined, route) => new TripRouteResponse
                                    {
                                        Id = combined.Trip_Routes.Id,
                                        RouteID = combined.Trip_Routes.RouteID,
                                        TripID = combined.Trip_Routes.TripID,
                                        TripData = combined.Trips,
                                        RouteData = route,
                                    }
                                ).ToListAsync();

            return tripRoute;

        }
    }
}
