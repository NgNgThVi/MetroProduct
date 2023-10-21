using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Features.Categorys.Commands.DeleteCategory;
using MetroDelivery.Application.Features.Categorys.Commands.UpdateCategory;
using MetroDelivery.Application.Features.Categorys.Queries.GetCategoryById;
using MetroDelivery.Application.Features.Categorys.Queries;
using MetroDelivery.Application.Features.Menus.Commands.CreateMenu;
using MetroDelivery.Application.Features.Menus.Queries;
using MetroDelivery.Application.Features.Menus.Queries.GetAllMenu;
using MetroDelivery.Application.Features.Stores.Commands.CreateStores;
using Microsoft.AspNetCore.Mvc;
using MetroDelivery.Application.Features.Menus.Queries.GetByIdMenu;
using MetroDelivery.Application.Features.Menus.Commands.UpdateMenu;
using MetroDelivery.Application.Features.Menus.Commands.DeleteMenu;
using Microsoft.AspNetCore.Authorization;
using System.Data;

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

        [HttpGet]
        [Route("get-by-id")]
        public async Task<ActionResult<MenuResponse>> GetUserById([FromQuery] GetMenuByIdQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        /*[Authorize(Roles = "Manager")]*/
        public async Task<ActionResult> Create([FromBody] CreateMennuCommand request)
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
        public async Task<MetroPickUpResponse> Update(UpdateMenuCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        /*[Authorize(Roles = "Manager")]*/
        public async Task<MetroPickUpResponse> Delete([FromQuery] DeleteMenuCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
