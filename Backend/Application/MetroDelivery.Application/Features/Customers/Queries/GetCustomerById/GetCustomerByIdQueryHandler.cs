using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;

namespace MetroDelivery.Application.Features.Customers.Queries.GetCustomerById
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, CustomerDto>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public GetCustomerByIdQueryHandler(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task<CustomerDto> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            //add to datbase 
            var userById = await _customerRepository.CustomerIdMusBeExist(request.id);

            if (userById == null) {
                throw new NotFoundExcrption(nameof(userById.ApplicationUser.UserName), request.id);
            }
            else if (userById.IsDelete == true) {
                throw new NotFoundExcrption("The customer have been deleted");
            }

            //convert data to dto
            var data = _mapper.Map<CustomerDto>(userById);

            //return
            return data;
        }
    }
}
