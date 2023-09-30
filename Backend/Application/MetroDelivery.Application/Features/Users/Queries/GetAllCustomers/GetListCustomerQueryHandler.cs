using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Contracts.Logging;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Application.Features.Users.Commands.UpdateUser;
using MetroDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Users.Queries.GetAllUsers
{
    public class GetListCustomerQueryHandler : IRequestHandler<GetListCustomerQuery, List<CustomerDto>>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly IAppLogger<GetListCustomerQuery> _logger;

        public GetListCustomerQueryHandler(IMapper mapper, ICustomerRepository customerRepository,
            IAppLogger<GetListCustomerQuery> logger)
        {
            this._mapper = mapper;
            this._customerRepository = customerRepository;
            this._logger = logger;
        }

        public async Task<List<CustomerDto>> Handle(GetListCustomerQuery request, CancellationToken cancellationToken)
        {
            // query the database
            var users = await _customerRepository.GetAsync();

            // convert data objects to Dto objects
            var data = _mapper.Map<List<CustomerDto>>(users);

            //logger
            _logger.LogInformation("Get all Customer retrived successfully");

            // return list of Dto object
            return data;
        }
    }
}
