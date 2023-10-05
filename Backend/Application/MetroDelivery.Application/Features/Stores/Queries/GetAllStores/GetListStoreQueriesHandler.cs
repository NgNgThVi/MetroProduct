using AutoMapper;
using MediatR;
using MetroDelivery.Application.Contracts.Persistance;

namespace MetroDelivery.Application.Features.Stores.Queries.GetAllStores
{
    public class GetListStoreQueriesHandler : IRequestHandler<GetListStoreQueries, List<StoreDto>>
    {
        private readonly IMapper _mapper;
        private readonly IStoreRepository _storeRepository;
        public GetListStoreQueriesHandler(IStoreRepository storeRepository, IMapper mapper)
        {
            this._storeRepository = storeRepository;
            this._mapper = mapper;
        }
        public async Task<List<StoreDto>> Handle(GetListStoreQueries request, CancellationToken cancellationToken)
        {
            var storeList = await _storeRepository.GetAsync();

            var data = _mapper.Map<List<StoreDto>>(storeList);

            return data;

        }
    }
}
