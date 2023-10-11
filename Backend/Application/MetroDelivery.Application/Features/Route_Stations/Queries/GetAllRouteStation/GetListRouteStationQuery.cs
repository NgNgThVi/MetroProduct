using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Features.Trip_Routes.Queries;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Route_Stations.Queries.GetAllRouteStation
{
    public class GetListRouteStationQuery : IRequest<List<RouteStationResponse>>
    {
    }

    public class GetListRouteStationQueryHandler : IRequestHandler<GetListRouteStationQuery, List<RouteStationResponse>>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public GetListRouteStationQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<List<RouteStationResponse>> Handle(GetListRouteStationQuery request, CancellationToken cancellationToken)
        {
            var routeStation = await _metroPickUpDbContext.Route_Stations.Where(r => r.IsDelete == false)
                                    .Join(
                                        _metroPickUpDbContext.Routes,
                                        routeAndStation => routeAndStation.RouteID,
                                        route => route.Id,
                                        (routeAndStation, route) => new
                                        {
                                            Route_Stations = routeAndStation,
                                            Routes = route
                                        }
                                     )
                                    .Join(
                                        _metroPickUpDbContext.Stations,
                                        combined => combined.Route_Stations.StationID,
                                        station => station.Id,
                                        (combined, station) => new RouteStationResponse
                                        {
                                            Id = combined.Route_Stations.Id,
                                            RouteID = combined.Route_Stations.RouteID,
                                            StationID = combined.Route_Stations.StationID,
                                            RouteData = combined.Routes,
                                            StationData = station
                                        }
                                    ).ToListAsync();
            return routeStation;
        }
    }
}
