using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Interface;
using Microsoft.EntityFrameworkCore;

namespace MetroDelivery.Application.Features.Orders.Queries.GetAllOrder
{
    public class GetListOrderQueryHandler : IRequestHandler<GetListOrderQuery, List<OrderResponse>>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public GetListOrderQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<List<OrderResponse>> Handle(GetListOrderQuery request, CancellationToken cancellationToken)
        {
            var orderList = await _metroPickUpDbContext.Order.Where(o => !o.IsDelete)
                                                            .Join(
                                                                _metroPickUpDbContext.Customer,
                                                                orders => orders.CustomerID,
                                                                customer => customer.Id,
                                                                (orders, customer) => new
                                                                {
                                                                    Orders = orders,
                                                                    Customers = customer
                                                                }
                                                            )
                                                            .Join(
                                                                _metroPickUpDbContext.Trip,
                                                                orderCustomer => orderCustomer.Orders.TripID,
                                                                trip => trip.Id,
                                                                (orderCutomer, trip) => new {OrderCustomer = orderCutomer, Trips = trip}
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

                                                                    CustomerId = orderCutomerTrip.OrderCustomer.Orders.CustomerID,
                                                                    TripId = orderCutomerTrip.OrderCustomer.Orders.TripID,
                                                                    StoreId = orderCutomerTrip.OrderCustomer.Orders.StoreID,

                                                                    CustomerData = orderCutomerTrip.OrderCustomer.Customers,
                                                                    TripData = orderCutomerTrip.Trips,
                                                                    StoreData = store
                                                                }
                                                            ).ToListAsync();
            return orderList;
        }
    }
}
