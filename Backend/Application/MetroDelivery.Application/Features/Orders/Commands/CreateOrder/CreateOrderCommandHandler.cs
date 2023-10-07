/*using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Contant;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Orders.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, MetroPickUpResponse>
    {


        private IProductRepository _productRepository { get; set; }
        private IOrderRepository _orderRepository { get; set; }
        private IOrderDetailRepository _orderDetailRepository { get; set; }

        private IMediator _mediator { get; set; }
        private IMetroPickUpDbContext _dbContext { get; set; }

        public CreateOrderCommandHandler(IProductRepository productRepository, IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository, IMediator mediator, IMetroPickUpDbContext dbContext)
        {
            _productRepository = productRepository;
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
            _mediator = mediator;
            _dbContext = dbContext;
        }

        public async Task<MetroPickUpResponse> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            //Step 1: Check minus product

            //Local variable
            double totalPrice = 0;
            List<Product> listProduct = new List<Product>();

            foreach (var data in request.ProductAndQuantity) {
                var checkMinusProduct = await _productRepository.CheckMinusProduct(data.ProductId, request.StoreId);

                if (checkMinusProduct.Message != Extension.Ok) {
                    return new MetroPickUpResponse
                    {
                        Message = Extension.CreateOrderFailedBecauseSomeProductWasOutOfStock
                    };
                }
                var product = await _productRepository.GetByIdAsync(Guid.Parse(data.ProductId));
                listProduct.Add(product);
                totalPrice += (data.Quantity * product.Price);
            }
            try {
                //Create Order 
                var order = new Order()
                {
                    CustomerID = Guid.Parse(request.CustomerId),
                    TripID = Guid.Parse(request.TripId),
                    StoreID = Guid.Parse(request.StoreId),
                    TotalPrice = totalPrice,
                    OrderTokenQR = request.OrderTokenQR,
                    IsDelete = false
                };
                await _orderRepository.CreateAsync(order);

                //Create Order Detail
                foreach (var item in request.ProductAndQuantity) {
                    //Order detail
                    var orderDetail = new OrderDetail
                    {
                        OrderID = order.Id,
                        ProductID = Guid.Parse(item.ProductId),
                        quanity = item.Quantity,
                        price = listProduct.Where(x => x.Id == Guid.Parse(item.ProductId)).Select(x => x.Price).Single() * item.Quantity
                    };
                    await _orderDetailRepository.CreateAsync(orderDetail);
                }
                foreach (var item in request.ProductAndQuantity) {
                    var product = await _dbContext.Products.Where(x => x.Id == Guid.Parse(item.ProductId)).FirstOrDefaultAsync();
                    product.Stock = product.Stock - item.Quantity;
                    if (product.Stock < 0) {
                        return new MetroPickUpResponse
                        {
                            Message = Extension.CreateOrderFailedBecauseSomeProductWasOutOfStock
                        };
                    }
                    _dbContext.Products.Update(product);
                    await _dbContext.SaveChangesAsync();
                    //Update Product stock
                    var product = await _productRepository.GetByIdAsync(Guid.Parse(item.ProductId));
                    var resultStock = product.Stock - item.Quantity;
                    if (resultStock < 0) {
                        return new MetroPickUpResponse
                        {
                            Message = Extension.CreateOrderFailedBecauseSomeProductWasOutOfStock
                        };
                    }
                    //await _productRepository.UpdateAsync(product);
                    var productRequest = new UpdateProductCommand()
                    {
                        Product = product,
                    };
                    var productResponse = await _mediator.Send(productRequest);
                    if (productResponse.Message != Extension.Ok) {
                        return new MetroPickUpResponse
                        {
                            Message = Extension.Fail
                        };
                    }
                }
                return new MetroPickUpResponse
                {
                    Message = Extension.Ok
                };
            }
            catch (Exception ex) {
                return new MetroPickUpResponse
                {
                    Message = ex.Message
                };
            }
        }
    }
}
*/