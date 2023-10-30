using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Stores.Queries.GetAllStoreHaveManger
{
    public class GetAllStoreHaveManagerQuery : IRequest<List<StoreResponse>>
    {
    }

    /*public class GetAllStoreHaveManagerQueryHandler : IRequestHandler<GetAllStoreHaveManagerQuery, List<StoreResponse>>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public GetAllStoreHaveManagerQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<List<StoreResponse>> Handle(GetAllStoreHaveManagerQuery request, CancellationToken cancellationToken)
        {
            var storeList = await _metroPickUpDbContext.Store.Where(s => !s.IsDelete)
                                                                .Join(
                                                                    _metroPickUpDbContext.ApplicationUsers,
                                                                    
                                                                )
        }
    }*/
}
