using MediatR;
using MetroDelivery.Application.Features.Stores;
using MetroDelivery.Application.Features.Stores.Queries.GetAllStores;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Stores
{
    [Route("api/v1/store")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StoresController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all-store")]
        public Task<List<StoreDto>> GetAll()
        {
            var response = _mediator.Send(new GetListStoreQueries());
            return response;
        }

        
    }
}
