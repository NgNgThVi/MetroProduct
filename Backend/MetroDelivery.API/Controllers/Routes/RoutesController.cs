using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Features.Customers.Queries.GetCustomerById;
using MetroDelivery.Application.Features.Customers;
using MetroDelivery.Application.Features.Routes.Commands.CreateRoute;
using MetroDelivery.Application.Features.Routes.Commands.DeleteRoute;
using MetroDelivery.Application.Features.Routes.Commands.UpdateRoute;
using MetroDelivery.Application.Features.Routes.Queries;
using MetroDelivery.Application.Features.Routes.Queries.GetAllRoute;
using MetroDelivery.Application.Features.Trips.Commands.CreateTrip;
using MetroDelivery.Application.Features.Trips.Commands.DeleteTrip;
using MetroDelivery.Application.Features.Trips.Commands.UpdateTrip;
using Microsoft.AspNetCore.Mvc;
using MetroDelivery.Application.Features.Routes.Queries.GetByFromToRoute;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Routes
{
    [Route("api/v1/route")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoutesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<List<RouteResponse>> GetAll()
        {
            var response = await _mediator.Send(new GetListRouteQuery());
            return response;
        }

        [HttpGet]
        [Route("get-route-by-id")]
        public async Task<ActionResult<CustomerDto>> GetUserById([FromQuery] GetRouteByFromToQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Create([FromBody] CreateRouteCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(GetAll), new { id = response });
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<MetroPickUpResponse> Update(UpdateRouteCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<MetroPickUpResponse> Delete([FromQuery] DeleteRouteCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
