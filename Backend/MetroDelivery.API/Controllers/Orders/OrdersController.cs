using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Application.Features.Orders.Commands.CreateOrder;
using MetroDelivery.Application.Features.Orders.Commands.UpdateOrder;
using MetroDelivery.Application.Features.Orders.Queries;
using MetroDelivery.Application.Features.Orders.Queries.GetAllOrder;
using MetroDelivery.Application.Features.Orders.Queries.GetByIdCustomer;
using MetroDelivery.Application.Features.Orders.Queries.GetOrderByManager;
using MetroDelivery.Application.Features.Orders.Queries.GetOrderWithDetailByManager;
using MetroDelivery.Application.Features.Orders.Queries.GetOrderWithOrderDetailByIdCustomer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Orders
{
    [Route("api/v1/order")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediator _mediator;

        public OrdersController(IProductRepository productRepository, IMediator mediator)
        {
            _productRepository = productRepository;
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<List<OrderResponse>> GetAll()
        {
            var response = await _mediator.Send(new GetListOrderQuery());
            return response;
        }

        [HttpGet]
        [Route("get-by-id-customer")]
        /*[Authorize(Roles = "EndUser")]*/
        public async Task<List<OrderResponse>> Get([FromQuery] GetByIdCustomerQuery request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpGet]
        [Route("get-by-id-store-of-manager")]
        /*[Authorize(Roles = "Manager")]*/
        public async Task<List<OrderResponse>> Get([FromQuery] GetOrderByManagerQuery request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpGet]
        [Route("get-order-with-order-detail-by-cutomer-id")]
        /*[Authorize(Roles = "EndUser")]*/
        public async Task<List<OrderRequest>> Get([FromQuery] GetOrderWithOrderDetailByIdCustomerQuery request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpGet]
        [Route("get-order-with-detail-by-manager")]
        public async Task<List<OrderRequest>> Get([FromQuery] GetOrderWithDetailByManagerQuery request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpPost]
        [Route("orders")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        /*[Authorize(Roles = "EndUser")]*/
        public async Task<MetroPickUpResponse> CreateOrder(CreateOrderCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        /* [Authorize(Roles = "Manager")]*/
        public async Task<MetroPickUpResponse> Update(UpdateOrderCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
