using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Application.Features.Trips.Queries.GetTrips
{
    public class GetTripByInforQueryHandler : IRequestHandler<GetTripByInforQuery, TripResponse>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public GetTripByInforQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<TripResponse> Handle(GetTripByInforQuery request, CancellationToken cancellationToken)
        {
            var trip = await _metroPickUpDbContext.Trips.Where(t => t.TripName == request.TripName 
                                                           &&  t.TripStartTime == DateTime.Parse(request.TripStartTime)
                                                           && t.TripEndTime == DateTime.Parse(request.TripEndTime)).SingleOrDefaultAsync();
            if (trip == null || trip.IsDelete == true) {
                throw new NotFoundException("Trip is not exist or deleted!!");
            }

            var data = _mapper.Map<TripResponse>(trip);

            return data;
        }
    }
}
