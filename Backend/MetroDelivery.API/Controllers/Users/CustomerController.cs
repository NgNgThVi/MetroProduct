
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Features.Users;
using MetroDelivery.Application.Features.Users.Commands.CreateUser;
using MetroDelivery.Application.Features.Users.Commands.DeleteUser;
using MetroDelivery.Application.Features.Users.Commands.UpdateUser;
using MetroDelivery.Application.Features.Users.Queries.GetAllUsers;
using MetroDelivery.Application.Features.Users.Queries.GetUserById;
using MetroDelivery.Application.Features.Users.Queries.GetUserDetail;
using MetroDelivery.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Users
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
        [Route("getAllUser")]
        [Authorize(Roles = "Admin")]
        public async Task<List<CustomerDto>> GetAllUser()
        {
            var response = await _mediator.Send(new GetListUserQuery());
            return response;
        }

        // POST api/<userController>
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateUser([FromQuery] CreateCustomerCommand request)
        {
            /*try {*/
                var response = await _mediator.Send(request);
                return CreatedAtAction(nameof(GetAllUser), new {id = response});
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
        [Route("getUserById")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<CustomerDto>> GetUserById([FromQuery] GetCustomerByIdQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        // PUT api/<userController>/5
        [HttpPut]
        [Route("updateCustomerById")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult<CustomerDto>> UpdateCustomer(UpdateCustomerCommand request)
        {
            var response = await _mediator.Send(request);
            return Ok("Update Customer Successfully");
        }

        // DELETE api/<userController>/5
        [HttpDelete]
        [Route("deleteCustomerById")]
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
