using MediatR;
using MetroDelivery.Application.Features.Menus.Commands.CreateMenu;
using MetroDelivery.Application.Features.Menus.Queries;
using MetroDelivery.Application.Features.Menus.Queries.GetAllMenu;
using MetroDelivery.Application.Features.Stores.Commands.CreateStores;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Menus
{
    [Route("api/v1/menu")]
    [ApiController]
    public class MenusController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MenusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<MenuResponse>> GetAll()
        {
            var response = await _mediator.Send(new GetListMenuQuery());
            return response;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Create([FromBody] CreateMennuCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(GetAll), new { id = response });
        }
    }
}
