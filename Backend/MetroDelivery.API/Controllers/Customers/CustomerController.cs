
using MediatR;
using MetroDelivery.Application.Features.Customers;
using MetroDelivery.Application.Features.Customers.Commands.CreateCustomer;
using MetroDelivery.Application.Features.Customers.Commands.DeleteCustomer;
using MetroDelivery.Application.Features.Customers.Commands.UpdateCustomer;
using MetroDelivery.Application.Features.Customers.Queries.GetAllCustomers;
using MetroDelivery.Application.Features.Customers.Queries.GetCustomerById;
using MetroDelivery.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
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
        // GET api/<userController>/5
        [HttpGet]
        [Route("get-all-customer")]
        
        public async Task<List<CustomerDto>> GetAllUser()
        {
            var response = await _mediator.Send(new GetListCustomerQuery());
            return response;
        }

        // POST api/<userController> same vs cai register o AuthSerice cho user
        [HttpPost]
        [Route("register-customer")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        
        public async Task<ActionResult> CreateCustomer([FromQuery] CreateCustomerCommand request)
        {
            /*try {*/
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(GetAllUser), new { id = response });
            /*}
            catch (Exception ex) {
                if(ex is ValidationException) {
                    ValidationException error = (ValidationException)ex;
                    var errorsDiction = new Dictionary<string, string[]>(error.Errors);
                    return BadRequest(errorsDiction);
                }
                return BadRequest(ex.Message);
            }*/
        }

        // GET api/<userController>/5
        [HttpGet]
        [Route("get-customer-by-id")]
        /*[Authorize(Roles = "Admin")]*/
        public async Task<ActionResult<CustomerDto>> GetUserById([FromQuery] GetCustomerByIdQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        // PUT api/<userController>/5
        [HttpPut]
        [Route("update-customer-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<CustomerDto>> UpdateCustomer(UpdateCustomerCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok("Update Customer Successfully");
        }

        // DELETE api/<userController>/5
        [HttpDelete]
        [Route("delete-customer-by-id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete([FromQuery] DeleteUserCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
