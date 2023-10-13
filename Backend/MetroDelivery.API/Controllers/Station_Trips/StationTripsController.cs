using MediatR;
using MetroDelivery.Application.Features.Station_Trips.Queries;
using MetroDelivery.Application.Features.Station_Trips.Queries.GetAllStationTrip;
using Microsoft.AspNetCore.Mvc;

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

        
    }
}
