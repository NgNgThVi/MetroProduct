
using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Features.Customers;
using MetroDelivery.Application.Features.Customers.Commands.CreateCustomer;
using MetroDelivery.Application.Features.Customers.Commands.DeleteCustomer;
using MetroDelivery.Application.Features.Customers.Commands.UpdateCustomer;
using MetroDelivery.Application.Features.Customers.Queries.GetAllCustomers;
using MetroDelivery.Application.Features.Customers.Queries.GetAllForAdmin;
using MetroDelivery.Application.Features.Customers.Queries.GetCustomerById;
using MetroDelivery.Application.Features.Staff.Queries;
using MetroDelivery.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Customers
{

    [Route("api/v1/customer")]
    [ApiController]

    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }
       
        [HttpGet]
        [Route("get-all-customer-for-admin")]

        public async Task<List<CustomerResponse>> GetAllUser()
        {
            var response = await _mediator.Send(new GetListForAdminQuery());
            return response;
        }

        [HttpGet]
        [Route("get-all-customer-only-customer")]
        public async Task<List<CustomerRole>> Get()
        {
            var response = await _mediator.Send(new GetListCustomerQuery());
            return response;
        }

        [HttpPost]
        [Route("register-customer")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]

        public async Task<ActionResult> CreateCustomer([FromQuery] CreateCustomerCommand request)
        {
            /*try {*/
                var response = await _mediator.Send(request);
                return Ok(response);
            /*}
            catch (Exception ex) {
                if (ex is ValidationException) {
                    ValidationException error = (ValidationException)ex;
                    var errorsDiction = new Dictionary<string, string[]>(error.Errors);
                    return BadRequest(errorsDiction);
                }
                return BadRequest(ex.Message);
            }*/
        }

        [HttpGet]
        [Route("get-customer-by-id")]
       /* [Authorize(Roles = "Admin")]*/
        public async Task<ActionResult<CustomerRole>> GetUserById([FromQuery] GetCustomerByIdQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        [Route("update-customer-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<MetroPickUpResponse> UpdateCustomer(UpdateCustomerCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpDelete]
        [Route("delete-customer-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<MetroPickUpResponse> Delete([FromQuery] DeleteCustomerCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
