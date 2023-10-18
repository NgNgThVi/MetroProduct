using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Application.Features.Customers.Queries.GetCustomerById
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, CustomerResponse>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public GetCustomerByIdQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<CustomerResponse> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            //add to datbase 
            var userById = await _metroPickUpDbContext.ApplicationUsers.Where(c => c.Id == request.id).SingleOrDefaultAsync();

            if (userById == null) {
                throw new NotFoundException(nameof(userById.UserName), request.id);
            }
            else if (userById.EmailConfirmed == false) {
                throw new NotFoundException("The customer have been deleted");
            }

            //convert data to dto
            var data = _mapper.Map<CustomerResponse>(userById);

            //return
            return data;
        }
    }
}
