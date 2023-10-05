using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;

namespace MetroDelivery.Application.Features.Stores.Queries.GetStoreById
{
    public class GetStoreByIdQueriesHandler : IRequestHandler<GetStoreByIdQueries, StoreDto>
    {
        private readonly IStoreRepository _storeReposity;
        private readonly IMapper _mapper;
        public GetStoreByIdQueriesHandler(IStoreRepository storeRepository, IMapper mapper)
        {
            this._storeReposity = storeRepository;
            this._mapper = mapper;
        }

        public async Task<StoreDto> Handle(GetStoreByIdQueries request, CancellationToken cancellationToken)
        {
            var storeId = await _storeReposity.GetByIdAsync(request.Id);
            if (storeId == null) {
                throw new NotFoundException(nameof(Store), request.Id);
            }
            else if (storeId.IsDelete == true) {
                throw new NotFoundException($"{storeId} does not exist.");
            }

            var data = _mapper.Map<StoreDto>(storeId);

            return data;
        }
    }
}
