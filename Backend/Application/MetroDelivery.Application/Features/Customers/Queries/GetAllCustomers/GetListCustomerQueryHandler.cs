using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Contracts.Logging;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Customers.Queries.GetAllCustomers
{
    public class GetListCustomerQueryHandler : IRequestHandler<GetListCustomerQuery, List<CustomerDto>>
    {
        /*private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        private readonly IAppLogger<GetListCustomerQuery> _logger;

        public GetListCustomerQueryHandler(IMapper mapper, ICustomerRepository customerRepository,
            IAppLogger<GetListCustomerQuery> logger)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
            _logger = logger;
        }*/
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        private readonly IAppLogger<GetListCustomerQuery> _logger;
        public GetListCustomerQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper, IAppLogger<GetListCustomerQuery> logger)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<List<CustomerDto>> Handle(GetListCustomerQuery request, CancellationToken cancellationToken)
        {
            // query the database
            /*var users = await _customerRepository.GetAsync();*/
            var users = await _metroPickUpDbContext.Customer.Where(c => !c.IsDelete).ToListAsync();

            // convert data objects to Dto objects
            var data = _mapper.Map<List<CustomerDto>>(users);

            //logger
            _logger.LogInformation("Get all Customer retrived successfully");

            // return list of Dto object
            return data;
        }
    }
}
