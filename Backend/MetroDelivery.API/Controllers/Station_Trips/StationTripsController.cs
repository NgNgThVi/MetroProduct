using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Features.Station_Trips.Commands.CreateStationTrip;
using MetroDelivery.Application.Features.Station_Trips.Commands.DeleteStationTrip;
using MetroDelivery.Application.Features.Station_Trips.Commands.UpdateStationTrip;
using MetroDelivery.Application.Features.Station_Trips.Queries;
using MetroDelivery.Application.Features.Station_Trips.Queries.GetAllStationTrip;
using MetroDelivery.Application.Features.Station_Trips.Queries.GetStationByTripId;
using MetroDelivery.Application.Features.Stations.Commands.CreateStation;
using MetroDelivery.Application.Features.Stations.Commands.DeleteStation;
using MetroDelivery.Application.Features.Stations.Commands.UpdateStation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Station_Trips
{
    [Route("api/v1/station-trip")]
    [ApiController]
    public class StationTripsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StationTripsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("list")]
        public async Task<List<StationTripResponse>> GetAll()
        {
            var response = await _mediator.Send(new GetListStationTripQuery());
            return response;
        }

        [HttpGet]
        [Route("station-by-trip-id")]
        public async Task<List<StationTripResponse>> Get([FromQuery] GetStationByTripIdQuery request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        /*[Authorize(Roles = "Manager")]*/
        public async Task<ActionResult> Create([FromBody] CreateStationTripCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(GetAll), new { id = response });
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        /*[Authorize(Roles = "Manager")]*/
        public async Task<MetroPickUpResponse> Update(UpdateStationTripCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        /*[Authorize(Roles = "Manager")]*/
        public async Task<MetroPickUpResponse> Delete([FromQuery] DeleteStationTripCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
