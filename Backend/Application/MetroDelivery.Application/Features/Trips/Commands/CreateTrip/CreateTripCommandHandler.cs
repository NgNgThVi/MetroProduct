using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Application.Features.Trips.Commands.CreateTrip
{
    public class CreateTripCommandHandler : IRequestHandler<CreateTripCommand, Guid>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public CreateTripCommandHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateTripCommand request, CancellationToken cancellationToken)
        {
            var tripName = await _metroPickUpDbContext.Trips.Where(t => t.TripName == request.TripName
                                                                        && t.TripStartTime == request.TripStartTime
                                                                        && t.TripEndTime == request.TripEndTime)
                                                            .SingleOrDefaultAsync();
            if(tripName != null) {
                throw new NotFoundException("Trip is already exist");
            }
            var trip = new Trip
            {
                TripName = request.TripName,
                TripStartTime = request.TripStartTime,
                TripEndTime = request.TripEndTime,
            };

            _metroPickUpDbContext.Trips.Add(trip);
            await _metroPickUpDbContext.SaveChangesAsync();
            return trip.Id;
        }
    }
}
