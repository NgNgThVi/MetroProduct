﻿using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Application.Features.Trips.Commands.DeleteTrip
{
    public class DeleteTripCommandHandler : IRequestHandler<DeleteTripCommand, MetroPickUpResponse>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public DeleteTripCommandHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<MetroPickUpResponse> Handle(DeleteTripCommand request, CancellationToken cancellationToken)
        {
            var tripId = await _metroPickUpDbContext.Trips.Where(t => t.Id == request.Id).SingleOrDefaultAsync();

            if(tripId == null) {
                throw new NotFoundException($"Not Found Trips {tripId}");
            }
            if(tripId.IsDelete == true) {
                throw new NotFoundException("Trip is delete!!");
            }

            tripId.IsDelete = true;
            _metroPickUpDbContext.Trips.Update(tripId);
            await _metroPickUpDbContext.SaveChangesAsync();

            return new MetroPickUpResponse
            {
                Message = "Delete Trips Successfully"
            };
        }
    }
}
