using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Contant;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Application.Features.Menu_Products;
using MetroDelivery.Application.Features.Menus.Queries;
using MetroDelivery.Application.Features.OrderDetails.Queries;
using MetroDelivery.Application.Features.Orders.Queries;
using MetroDelivery.Application.Features.Products.Commands.CreateProducts;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, OrderResponseMessage>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public CreateOrderCommandHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<OrderResponseMessage> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var storeId = await _metroPickUpDbContext.Store.Where(s => s.Id == request.StoreId).SingleOrDefaultAsync();
            if (storeId == null) {
                throw new NotFoundException("không có cửa hàng này, xin nhập lại");
            }
            var station = await _metroPickUpDbContext.Station.Where(s => s.StoreID == request.StoreId).SingleOrDefaultAsync();
            if (station == null) {
                throw new NotFoundException("không có station từ cửa hàng, xin nhập lại");
            }
            var stationTrip = await _metroPickUpDbContext.Station_Trip.Where(s => s.StationID == station.Id && s.TripID == request.TripId).SingleOrDefaultAsync();
            if(stationTrip == null) {
                throw new NotFoundException("Bắt User nhập lại thời gian kết thúc chuyến tàu, tại staionTrip");
            }
            // Lấy thông tin về múi giờ của Việt Nam
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            // Lấy thời gian hiện tại theo múi giờ của Việt Nam
            DateTime vietnamTime = TimeZoneInfo.ConvertTime(DateTime.Now, vietnamTimeZone);

            /*var validator = new CreateOrderCommandValidator();
            var validatorResult = await validator.ValidateAsync(request);
            if (validatorResult.Errors.Any()) {
                throw new BadRequestException("Invalid Create user", validatorResult);
            }*/
            var timeDifference =  stationTrip.Arrived.TimeOfDay - vietnamTime.TimeOfDay;
            if (timeDifference.TotalMinutes < 15) {
                throw new NotFoundException("User phải đặt hàng trước 15p, xin mời đặt lại ở trạm kế tiếp vì bị lố thời gian chuẩn bị");
            }
            var totalPrice = request.Products.Sum(product => product.PriceOfProductBelongToTimeService * product.Quantity);
            var order = new Order
            {
                TotalPrice = totalPrice,
                OrderTokenQR = request.OrderTokenQR,

                ApplicationUserID = request.ApplicationUserID,
                TripID = request.TripId,
                StoreID = request.StoreId
            };

            _metroPickUpDbContext.Order.Add(order);
            await _metroPickUpDbContext.SaveChangesAsync();

            // Lặp qua danh sách các sản phẩm trong đơn đặt hàng và thêm chúng vào đối tượng OrderDetail
            foreach (var product in request.Products) {
                var orderDetail = new OrderDetail
                {
                    ProductID = product.ProductId,
                    OrderID = order.Id,
                    Quanity = product.Quantity,
                    Price = product.PriceOfProductBelongToTimeService * product.Quantity
                };
                _metroPickUpDbContext.OrderDetail.Add(orderDetail);
            }
            await _metroPickUpDbContext.SaveChangesAsync();
            var lastOrderDetail = await _metroPickUpDbContext.OrderDetail
                                        .OrderByDescending(od => od.Created) // Sắp xếp theo thời gian tạo giảm dần để lấy OrderDetail mới nhất
                                        .FirstOrDefaultAsync();

            if (lastOrderDetail == null) {
                throw new NotFoundException("chưa có order nào được tạo hết");
            }
            var lastOrderDetailId = lastOrderDetail.Id;
            return new OrderResponseMessage { 
                OrderId = order.Id,
                OrderDetailId = lastOrderDetailId,
            };
        }
    }
}
