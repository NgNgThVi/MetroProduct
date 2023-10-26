using MediatR;
using MetroDelivery.Application.Features.Customers.Queries.GetAllForAdmin;
using MetroDelivery.Application.Features.Customers;
using Microsoft.AspNetCore.Mvc;
using MetroDelivery.Application.Features.Manager.Queries;
using MetroDelivery.Application.Features.Manager.Queries.GetAllManager;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Features.Staff.Commands.CreateStaff;
using MetroDelivery.Application.Features.Staff.Commands.DeleteStaff;
using MetroDelivery.Application.Features.Staff.Commands.UpdateStaff;
using MetroDelivery.Application.Features.Staff.Queries.GetByIdStaff;
using MetroDelivery.Application.Features.Staff.Queries;
using MetroDelivery.Application.Features.Manager.Queries.GetByIdStaff;
using MetroDelivery.Application.Features.Manager.Commands.CreateManager;
using MetroDelivery.Application.Features.Manager.Commands.DeleteManager;
using MetroDelivery.Application.Features.Manager.Commands.UpdateManager;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Manager
{
    [Route("api/v1/manager")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ManagerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all")]
        /*[Authorize(Roles = "Admin")]*/
        public async Task<ActionResult<List<ManagerRole>>> GetAll()
        {
            try {
                var response = await _mediator.Send(new GetListManagerQuery());
                return response;
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("get-manager-by-id")]
        /*[Authorize(Roles = "Manager, Staff")]*/
        public async Task<ActionResult<ManagerRole>> GetUserById([FromQuery] GetByIdManagerQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("register-manager")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        /*[Authorize(Roles = "Manager")]*/
        public async Task<ActionResult> CreateCustomer([FromQuery] CreateManagerCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        [Route("update-manager-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        /*[Authorize(Roles = "Manager")]*/
        public async Task<MetroPickUpResponse> UpdateCustomer(UpdateManagerCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpDelete]
        [Route("delete-manager-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        /*[Authorize(Roles = "Manager")]*/
        public async Task<MetroPickUpResponse> Delete([FromQuery] DeleteManagerCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
