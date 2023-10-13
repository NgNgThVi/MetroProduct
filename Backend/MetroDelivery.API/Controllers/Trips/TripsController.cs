using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Features.Trips.Commands.CreateTrip;
using MetroDelivery.Application.Features.Trips.Commands.DeleteTrip;
using MetroDelivery.Application.Features.Trips.Commands.UpdateTrip;
using MetroDelivery.Application.Features.Trips.Queries;
using MetroDelivery.Application.Features.Trips.Queries.GetAllTrip;
using Microsoft.AspNetCore.Mvc;

namespace MetroDelivery.API.Controllers.Trips
{
    [Route("api/v1/trip")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TripsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all-trip")]
        public async Task<List<TripResponse>> GetAllTrip()
        {
            var response = await _mediator.Send(new GetListTripQuery());
            return response;
        }


        [HttpPost]
        [Route("register-trip")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Create([FromQuery] CreateTripCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(GetAllTrip), new { id = response });
        }

        [HttpPut]
        [Route("update-trip-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<MetroPickUpResponse> Update(UpdateTripCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpDelete]
        [Route("delete-trip-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<MetroPickUpResponse> Delete([FromQuery] DeleteTripCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
