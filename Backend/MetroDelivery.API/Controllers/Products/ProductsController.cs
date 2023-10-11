using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Features.Products.Commands.CreateProducts;
using MetroDelivery.Application.Features.Products.Commands.DeleteProducts;
using MetroDelivery.Application.Features.Products.Commands.UpdateProducts;
using MetroDelivery.Application.Features.Products.Queries;
using MetroDelivery.Application.Features.Products.Queries.GetAllProduct;
using MetroDelivery.Application.Features.Products.Queries.GetProductById;
using MetroDelivery.Application.Features.Stores.Commands.CreateStores;
using MetroDelivery.Application.Features.Trips.Commands.CreateTrip;
using MetroDelivery.Application.Features.Trips.Commands.DeleteTrip;
using MetroDelivery.Application.Features.Trips.Commands.UpdateTrip;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Products
{
    [Route("api/v1/product")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<List<ProductResponse>> GetAll()
        {
            var response = await _mediator.Send(new GetListProductQuery());
            return response;
        }


        [HttpGet]
        [Route("get-by-id")]
        public async Task<ProductResponse> Get([FromQuery] GetProductByIdQuery request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Create([FromBody] CreateProductCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(GetAll), new { id = response });
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<MetroPickUpResponse> Update(UpdateProductCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<MetroPickUpResponse> Delete([FromQuery] DeleteProductCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
