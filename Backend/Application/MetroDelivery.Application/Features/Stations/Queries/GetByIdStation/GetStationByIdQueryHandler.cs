using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Features.Stores.Queries.GetStoreById;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Application.Features.Stations.Queries.GetByIdStation
{
    public class GetStationByIdQueryHandler : IRequestHandler<GetStationByIdQuery, StationResponse>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public GetStationByIdQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<StationResponse> Handle(GetStationByIdQuery request, CancellationToken cancellationToken)
        {
            var station = await _metroPickUpDbContext.Station.Where(s => s.Id == request.Id).SingleOrDefaultAsync();
            if(station == null) {
                throw new NotFoundException($"Not found station with {station}");
            }

            var stationData = _mapper.Map<StationData>(station);
            var storeId = await _metroPickUpDbContext.Store.Where(s => s.Id == station.StoreID).SingleOrDefaultAsync();
            var storeData = _mapper.Map<StoreData>(storeId);
            var result = new StationResponse
            {
                StationData = stationData,
                StoreData = storeData
            };

            return result;
        }
    }
}
