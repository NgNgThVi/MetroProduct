using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Features.Customers;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Orders.Queries.GetByIdOrder
{
    public class GetByIdOrderQuery : IRequest<OrderResponse>
    {
        public Guid OrderId { get; set; }
    }

    public class GetByIdOrderQueryHandler : IRequestHandler<GetByIdOrderQuery, OrderResponse>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public GetByIdOrderQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<OrderResponse> Handle(GetByIdOrderQuery request, CancellationToken cancellationToken)
        {
            var order = await _metroPickUpDbContext.Order.Where(o => !o.IsDelete && o.Id == request.OrderId)
                                                            .Join(
                                                                _metroPickUpDbContext.ApplicationUsers,
                                                                orders => orders.ApplicationUserID,
                                                                applicationUser => applicationUser.Id,
                                                                (orders, applicationUser) => new
                                                                {
                                                                    Orders = orders,
                                                                    ApplicationUser = applicationUser
                                                                }
                                                            )
                                                            .Join(
                                                                _metroPickUpDbContext.Trip,
                                                                orderCustomer => orderCustomer.Orders.TripID,
                                                                trip => trip.Id,
                                                                (orderCutomer, trip) => new { OrderCustomer = orderCutomer, Trips = trip }
                                                            )
                                                            .Join(
                                                                _metroPickUpDbContext.Store,
                                                                orderCutomerTrip => orderCutomerTrip.OrderCustomer.Orders.StoreID,
                                                                store => store.Id,
                                                                (orderCutomerTrip, store) => new OrderResponse
                                                                {
                                                                    OrderId = orderCutomerTrip.OrderCustomer.Orders.Id,
                                                                    TotalPrice = orderCutomerTrip.OrderCustomer.Orders.TotalPrice,
                                                                    OrderTokenQR = orderCutomerTrip.OrderCustomer.Orders.OrderTokenQR,

                                                                    ApplicationUserID = orderCutomerTrip.OrderCustomer.Orders.ApplicationUserID,
                                                                    TripId = orderCutomerTrip.OrderCustomer.Orders.TripID,
                                                                    StoreId = orderCutomerTrip.OrderCustomer.Orders.StoreID,

                                                                    CustomerData = _mapper.Map<CustomerResponse>(orderCutomerTrip.OrderCustomer.ApplicationUser),
                                                                    TripData = orderCutomerTrip.Trips,
                                                                    StoreData = store
                                                                }
                                                            ).SingleOrDefaultAsync();
            if(order == null) {
                throw new NotFoundException("Order is not existed");
            }

            return order;
        }
    }
}
