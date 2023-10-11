/*using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Trip_Routes.Queries.GetInforRoute
{
    public class GetByInforRouteQuery : IRequest<TripRouteResponse>
    {
        // chon Route
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }

        //chọn Trip
        public Guid TripId { get; set; }

    }

    public class GetByInforRouteQueryHandler : IRequestHandler<GetByInforRouteQuery, TripRouteResponse>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public GetByInforRouteQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<TripRouteResponse> Handle(GetByInforRouteQuery request, CancellationToken cancellationToken)
        {
            var tripId = await _metroPickUpDbContext.Trip_Routes.Where(tr => tr.TripID == request.TripId).SingleOrDefaultAsync();
            if (tripId == null) {
                throw new NotFoundException("Con tàu chưa có tuyến đường nào!");
            }

            var route = await _metroPickUpDbContext.Trip_Routes.Where(tr => tr.Route.FromLocation == request.FromLocation
                                                                            && tr.Route.ToLocation == request.ToLocation)
                                                                .Include(tr => tr.Route)
                                                                .SingleOrDefaultAsync();
            if(route == null) {
                throw new NotFoundException($"tuyến đường này không dành cho con tàu {tripId}");
            }

            var tripData = _mapper.Map<TripData>(tripId);
            var routeData = _mapper.Map<RouteData>(route);
            var result = new TripRouteResponse
            {
                TripData = tripData,
                RouteData = routeData
            };
            return result;
        }
    }
}
*/