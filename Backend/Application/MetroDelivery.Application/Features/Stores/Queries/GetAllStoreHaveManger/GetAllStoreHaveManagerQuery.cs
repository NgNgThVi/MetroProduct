using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Interface;
using Microsoft.EntityFrameworkCore;
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

    public class GetAllStoreHaveManagerQueryHandler : IRequestHandler<GetAllStoreHaveManagerQuery, List<StoreResponse>>
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
            var storeList = await _metroPickUpDbContext.Store.Where(s => !s.IsDelete).ToListAsync();
            var store = storeList.Select(s => new StoreResponse
            {
                StoreId = s.Id,
                StoreName = s.StoreName,
                StoreLocation = s.StoreLocation,
                StoreOpenTime = s.StoreOpenTime,
                StoreCloseTime = s.StoreCloseTime,

                ManagerData = GetManagerData(s.Id)
            }).ToList();

            return store;
        }

        private List<ManagerData> GetManagerData(Guid storeId)
        {
            var manager = _metroPickUpDbContext.ApplicationUsers.Where(a => a.StoreId == storeId).ToList();

            var data = _mapper.Map<List<ManagerData>>(manager);

            return data;
        }
    }
}
