using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Features.Categorys.Commands.UpdateCategory;
using MetroDelivery.Application.Features.Menu_Products;
using MetroDelivery.Application.Features.Menu_Products.Commands.CreateMenuProduct;
using MetroDelivery.Application.Features.Menu_Products.Commands.DeleteMenuProduct;
using MetroDelivery.Application.Features.Menu_Products.Commands.UpdateMenuProduct;
using MetroDelivery.Application.Features.Menu_Products.Queries.GetListMenu_Product;
using MetroDelivery.Application.Features.Menu_Products.Queries.GetMenuProductByMenuId;
using MetroDelivery.Application.Features.Menu_Products.Queries.GetMenuProductByTimeService;
using MetroDelivery.Application.Features.Menus.Commands.CreateMenu;
using MetroDelivery.Application.Features.Menus.Commands.DeleteMenu;
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

        [HttpGet]
        [Route("get-menu-product-by-station-id")]
        public async Task<MenuProductResponseData> Get([FromQuery] GetMenuProductByStationIdQuery request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpGet]
        [Route("get-menu-product-by-menu-id")]
        public async Task<List<MenuProductResponse>> Get([FromQuery] GetMenuProducByMenuIdQuery request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<MetroPickUpResponse> Create([FromBody] CreateMenuProductCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<MetroPickUpResponse> Update(UpdateMenuProductCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<MetroPickUpResponse> Delete([FromQuery] DeleteMenuProductCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
