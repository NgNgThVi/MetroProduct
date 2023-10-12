using MediatR;
using MetroDelivery.Application.Features.Menu_Products;
using MetroDelivery.Application.Features.Menu_Products.Commands.CreateMenuProduct;
using MetroDelivery.Application.Features.Menu_Products.Queries.GetListMenu_Product;
using MetroDelivery.Application.Features.Menus.Commands.CreateMenu;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Menu_Products
{
    [Route("api/v1/menu-product")]
    [ApiController]
    public class MenuProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MenuProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<MenuProductResponse>> GetAll()
        {
            var response = await _mediator.Send(new GetAllMenu_Products());
            return response;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Create([FromBody] CreateMenuProductCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(GetAll), new { id = response });
        }
    }
}
