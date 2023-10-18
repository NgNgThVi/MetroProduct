/*using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Features.Trips.Queries;
using MetroDelivery.Domain.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Customers.Queries.GetCustomerByApplicationUserId
{
    public class GetCustomerByApplicationIdQuery : IRequest<CustomerResponse>
    {
        public string ApplicationUserId { get; set; }
    }

    public class GetCustomerByApplicationIdQueryHandler : IRequestHandler<GetCustomerByApplicationIdQuery, CustomerResponse>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        private readonly UserManager<ApplicationUser> _userManager;
        public GetCustomerByApplicationIdQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<CustomerResponse> Handle(GetCustomerByApplicationIdQuery request, CancellationToken cancellationToken)
        {
            var customer = await _metroPickUpDbContext.Customer.Where(x => x.ApplicationUserId == request.ApplicationUserId).SingleOrDefaultAsync();
            if (customer == null) {
                throw new NotFoundException("Have no Customer!");
            }
            if (customer.IsDelete == true) {
                throw new NotFoundException("đã bị xóa");
            }

            var listResult = new List<CustomerResponse>();
            var customerData = _mapper.Map<CustomerDto>(customer);
            var applicationUserInfor = await _userManager.FindByIdAsync(customer.ApplicationUserId);
            var applicationUserData = _mapper.Map<ApplicationUserData>(applicationUserInfor);
            var result = new CustomerResponse
            {
                CustomerData = customerData,
                ApplicationUserData = applicationUserData,
            };
            return result;
        }
    }
}
*/