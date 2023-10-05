using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Application.Features.Orders.Commands.CreateOrder;
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

        [HttpPost]
        [Route("orders")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<MetroPickUpResponse> CreateOrder(CreateOrderCommand request)
        {
            var result = await _mediator.Send(request);

            return result;
        }
    }
}
