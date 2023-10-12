using MediatR;
using MetroDelivery.Application.Features.Store_Menus.Commands.CreateStoreMenu;
using MetroDelivery.Application.Features.Store_Menus.Queries;
using MetroDelivery.Application.Features.Store_Menus.Queries.GetAllStoreMenu;
using MetroDelivery.Application.Features.Stores.Commands.CreateStores;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Store_Menus
{
    [Route("api/v1/store-menu")]
    [ApiController]
    public class StoreMenusController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StoreMenusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<StoreMenuResponse>> GetAll()
        {
            var response = await _mediator.Send(new GetListStoreMenuQuery());
            return response;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Create([FromBody] CreateStoreMenuCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(GetAll), new { id = response });
        }

        
    }
}
