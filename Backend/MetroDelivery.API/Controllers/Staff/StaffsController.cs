using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Application.Features.Customers;
using MetroDelivery.Application.Features.Customers.Commands.CreateCustomer;
using MetroDelivery.Application.Features.Customers.Commands.DeleteCustomer;
using MetroDelivery.Application.Features.Customers.Commands.UpdateCustomer;
using MetroDelivery.Application.Features.Customers.Queries.GetCustomerById;
using MetroDelivery.Application.Features.Staff.Commands.CreateStaff;
using MetroDelivery.Application.Features.Staff.Commands.DeleteStaff;
using MetroDelivery.Application.Features.Staff.Commands.UpdateStaff;
using MetroDelivery.Application.Features.Staff.Queries;
using MetroDelivery.Application.Features.Staff.Queries.GetAllStaff;
using MetroDelivery.Application.Features.Staff.Queries.GetByIdStaff;
using MetroDelivery.Application.Features.Staff.Queries.GetStaffByStoreId;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

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
        /*[Authorize(Roles = "Manager, Staff")]*/
        public async Task<List<StaffRole>> Get()
        {
            var response = await _mediator.Send(new GetListStaffQuery());
            return response;
        }

        [HttpGet]
        [Route("get-staff-by-id")]
        /*[Authorize(Roles = "Manager, Staff")]*/
        public async Task<ActionResult<StaffRole>> GetUserById([FromQuery] GetByIdStaffQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet]
        [Route("get-staff-by-store-id")]
        /*[Authorize(Roles = "Manager, Staff")]*/
        public async Task<ActionResult<StaffRole>> Get([FromQuery] GetStaffByStoreIdQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        [Route("register-staff")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        /*[Authorize(Roles = "Manager")]*/
        public async Task<ActionResult> CreateCustomer(CreateStaffCommand request)
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
        /*[Authorize(Roles = "Manager")]*/
        public async Task<MetroPickUpResponse> UpdateCustomer(UpdateStaffCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpDelete]
        [Route("delete-staff-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        /*[Authorize(Roles = "Manager")]*/
        public async Task<MetroPickUpResponse> Delete([FromQuery] DeleteStaffCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
