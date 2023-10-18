using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Features.Station_Trips.Commands.CreateStationTrip;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Station_Trips.Commands.UpdateStationTrip
{
    public class UpdateStationTripCommand : IRequest<MetroPickUpResponse>
    {
        public Guid Id { get; set; }
        public Guid TripId { get; set; }
        public Guid StationId { get; set; }
        public DateTime Arrived { get; set; }
    }

    public class UpdateStationTripCommandHandler : IRequestHandler<UpdateStationTripCommand, MetroPickUpResponse>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public UpdateStationTripCommandHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<MetroPickUpResponse> Handle(UpdateStationTripCommand request, CancellationToken cancellationToken)
        {
            var stationTripExist = await _metroPickUpDbContext.Station_Trip.Where(s => s.Id == request.Id).SingleOrDefaultAsync();
            if(stationTripExist == null) {
                throw new NotFoundException($"không tìm thấy stationTripId nào hết");
            }
            if (stationTripExist.IsDelete == true) {
                throw new NotFoundException($"stationTripId đã bị xóa");
            }

            stationTripExist.TripID = request.TripId;
            stationTripExist.StationID = request.StationId;
            stationTripExist.Arrived = request.Arrived;

            _metroPickUpDbContext.Station_Trip.Update(stationTripExist);
            await _metroPickUpDbContext.SaveChangesAsync();

            return new MetroPickUpResponse
            {
                Message = "Update successfully"
            };
        }
    }
}
