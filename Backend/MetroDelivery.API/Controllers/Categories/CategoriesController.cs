using MediatR;
using MetroDelivery.Application.Features.Categorys.Queries;
using MetroDelivery.Application.Features.Categorys.Queries.GetAllCategory;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Categories
{
    [Route("api/v1/category")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<List<CategoryResponse>> Get()
        {
            var response = await _mediator.Send(new GetListCategoryQuery());  
            return response;
        }

        
    }
}
