using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Application.Features.Customers;
using MetroDelivery.Application.Features.Customers.Commands.CreateCustomer;
using MetroDelivery.Application.Features.Customers.Commands.DeleteCustomer;
using MetroDelivery.Application.Features.Customers.Commands.UpdateCustomer;
using MetroDelivery.Application.Features.Customers.Queries.GetCustomerById;
using MetroDelivery.Application.Features.Staff.Commands.DeleteStaff;
using MetroDelivery.Application.Features.Staff.Commands.UpdateStaff;
using MetroDelivery.Application.Features.Staff.Queries;
using MetroDelivery.Application.Features.Staff.Queries.GetAllStaff;
using MetroDelivery.Application.Features.Staff.Queries.GetByIdStaff;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Staff
{
    [Route("api/v1/staff")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StaffsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<StaffRole>> Get()
        {
            var response = await _mediator.Send(new GetListStaffQuery());
            return response;
        }

        [HttpGet]
        [Route("get-staff-by-id")]
        public async Task<ActionResult<StaffRole>> GetUserById([FromQuery] GetByIdStaffQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("register-customer")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]

        public async Task<ActionResult> CreateCustomer([FromQuery] CreateCustomerCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);   
        }

        [HttpPut]
        [Route("update-staff-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<MetroPickUpResponse> UpdateCustomer(UpdateStaffCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        // DELETE api/<userController>/5
        [HttpDelete]
        [Route("delete-staff-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<MetroPickUpResponse> Delete([FromQuery] DeleteStaffCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
