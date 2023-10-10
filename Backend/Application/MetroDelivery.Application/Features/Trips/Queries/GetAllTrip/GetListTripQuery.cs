using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Trips.Queries.GetAllTrip
{
    public class GetListTripQuery : IRequest<List<TripDto>>
    {
    }

    public class GetListTripQueryHandler : IRequestHandler<GetListTripQuery, List<TripDto>>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public GetListTripQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<List<TripDto>> Handle(GetListTripQuery request, CancellationToken cancellationToken)
        {
            var list = await _metroPickUpDbContext.Trips.Where(t => t.IsDelete == false).ToListAsync();

            var data = _mapper.Map<List<TripDto>>(list);

            return data;
        }
    }
}
