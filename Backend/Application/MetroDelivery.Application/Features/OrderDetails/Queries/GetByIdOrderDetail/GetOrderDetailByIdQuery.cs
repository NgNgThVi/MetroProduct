using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.OrderDetails.Queries.GetByIdOrderDetail
{
    public class GetOrderDetailByIdQuery : IRequest<OrderDetailResponse>
    {
        public Guid Id { get; set; }
    }

    public class GetOrderDetailByIdQueryHandler : IRequestHandler<GetOrderDetailByIdQuery, OrderDetailResponse>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public GetOrderDetailByIdQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<OrderDetailResponse> Handle(GetOrderDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var orderDetailExist = await _metroPickUpDbContext.OrderDetail.Where(o => !o.IsDelete && o.Id == request.Id)
                                                                        .Join(
                                                                            _metroPickUpDbContext.Order,
                                                                            orderDetail => orderDetail.OrderID,
                                                                            order => order.Id,
                                                                            (orderDetail, order) => new
                                                                            {
                                                                                OrderDetails = orderDetail,
                                                                                Orders = order
                                                                            }
                                                                        )
                                                                        .Join(
                                                                            _metroPickUpDbContext.Product,
                                                                            combined => combined.OrderDetails.ProductID,
                                                                            product => product.Id,
                                                                            (combined, product) => new OrderDetailResponse
                                                                            {
                                                                                OrderDetailId = combined.OrderDetails.Id,
                                                                                Quanity = combined.OrderDetails.Quanity,
                                                                                Price = combined.OrderDetails.Price,
                                                                                ProductID = combined.OrderDetails.ProductID,
                                                                                OrderID = combined.OrderDetails.OrderID,
                                                                                Created = combined.OrderDetails.Created,

                                                                                OrderData = _mapper.Map<OrderData>(combined.Orders),
                                                                                ProductData = _mapper.Map<ProductData>(product)

                                                                            }
                                                                        ).SingleOrDefaultAsync();
            if(orderDetailExist == null) {
                throw new NotFoundException("orderDetail ko tồn tại");
            }
            return orderDetailExist;
        }
    }
}
