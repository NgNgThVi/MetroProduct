using MetroDelivery.Application.Features.Customers.Queries.GetCustomerById;
using MetroDelivery.Application.Features.Customers;
using Microsoft.AspNetCore.Mvc;
using MetroDelivery.Application.Features.Customers.Queries.GetByIdForAdmin;
using MediatR;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Admin
{
    [Route("api/v1/admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdminController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all-for-admin-by-all-id")]
        /*[Authorize(Roles = "Admin, EndUser")]*/
        // đang get detail cho cả 4 role, đổi tên lại
        public async Task<ActionResult<CustomerRole>> GetUserById([FromQuery] GetByIdForAdminQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
