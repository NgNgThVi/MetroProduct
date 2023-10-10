using MediatR;
using MetroDelivery.Application.Features.Stations.Queries;
using MetroDelivery.Application.Features.Stations.Queries.GetAllStation;
using MetroDelivery.Application.Features.Stations.Queries.GetByIdStation;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Stations
{
    [Route("api/v1/station")]
    [ApiController]
    public class StationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StationsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all-station")]
        public async Task<List<StationResponse>> GetAllStation()
        {
            var response = await _mediator.Send(new GetListStationQuery());   
            return response;
        }

        // GET api/<StationsController>/5
        [HttpGet]
        [Route("get-by-id")]
        public async Task<StationResponse> Get([FromQuery] GetStationByIdQuery request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        
    }
}
