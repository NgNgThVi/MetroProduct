using AutoMapper;
using MediatR;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Stores.Queries.GetAllStores
{
    public class GetListStoreQueries : IRequest<List<StoreDto>>
    {

    }

    public class GetListStoreQueriesHandler : IRequestHandler<GetListStoreQueries, List<StoreDto>>
    {
        private readonly IMapper _mapper;
        private readonly IStoreRepository _storeRepository;
        public GetListStoreQueriesHandler(IStoreRepository storeRepository, IMapper mapper)
        {
            this._storeRepository = storeRepository;
            this._mapper = mapper;
        }
        public Task<List<StoreDto>> Handle(GetListStoreQueries request, CancellationToken cancellationToken)
        {
            var 
        }
    }
}
