using AutoMapper;
using MediatR;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Users.Queries.GetAllUsers
{
    public class GetListUserQueryHandler : IRequestHandler<GetListUserQuery, List<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public GetListUserQueryHandler(IMapper mapper, ICustomerRepository customerRepository)
        {
            this._mapper = mapper;
            this._customerRepository = customerRepository;
        }

        public async Task<List<CustomerDto>> Handle(GetListUserQuery request, CancellationToken cancellationToken)
        {
            // query the database
            var users = await _customerRepository.GetAsync();

            // convert data objects to Dto objects
            var data = _mapper.Map<List<CustomerDto>>(users);

            // return list of Dto object
            return data;
        }
    }
}
