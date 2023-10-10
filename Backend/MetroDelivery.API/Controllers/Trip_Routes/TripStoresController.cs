using MediatR;
using MetroDelivery.Application.Features.Stores.Queries.GetAllStores;
using MetroDelivery.Application.Features.Stores;
using Microsoft.AspNetCore.Mvc;
using MetroDelivery.Application.Features.Trip_Routes.Queries;
using MetroDelivery.Application.Features.Trip_Routes.Queries.GetInforRoute;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Trip_Routes
{
    [Route("api/v1/trip-route")]
    [ApiController]
    public class TripStoresController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TripStoresController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        [Route("get-trip-route")]
        public async Task<TripRouteResponse> GetRoute([FromQuery] GetByInforRouteQuery request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        
    }
}
