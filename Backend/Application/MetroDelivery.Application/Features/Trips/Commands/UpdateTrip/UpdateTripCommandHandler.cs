using AutoMapper;
using FluentValidation;
using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Application.Features.Trips.Commands.UpdateTrip
{
    public class UpdateTripCommandHandler : IRequestHandler<UpdateTripCommand, MetroPickUpResponse>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
       
        public UpdateTripCommandHandler(IMetroPickUpDbContext metroPickUpDbContext)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            
        }

        public async Task<MetroPickUpResponse> Handle(UpdateTripCommand request, CancellationToken cancellationToken)
        {
            var tripId = await _metroPickUpDbContext.Trips.Where(t => t.Id == request.TripId).SingleOrDefaultAsync();
            if(tripId == null) {
                throw new NotFoundException("Not found trip");
            }
            if(tripId.IsDelete == true) {
                throw new NotFoundException("Trip is delete!!");
            }

            tripId.TripName = request.TripName;
            tripId.TripStartTime = request.TripStartTime;
            tripId.TripEndTime = request.TripEndTime;
            
            _metroPickUpDbContext.Trips.Update(tripId);
            await _metroPickUpDbContext.SaveChangesAsync();

            return new MetroPickUpResponse
            {
                Message = "Update Successfully"
            };
        }
    }
}
