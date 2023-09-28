
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
    
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class userController : ControllerBase
    {
        private readonly IMediator _mediator;

        public userController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("getUserDetail")]
        public async Task<UserDto> GetUserDetail([FromQuery]GetUserDetailQuery request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
        // GET api/<userController>/5
        [HttpGet]
        [Route("getAllUser")]
        /*[Authorize(Policy = "Admin")]*/
        public async Task<List<UserDto>> GetAllUser()
        {
            var response = await _mediator.Send(new GetListUserQuery());
            return response;
        }

        // POST api/<userController>
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> CreateUser([FromQuery] CreateUserCommand request)
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
        /*[Authorize(Policy = "Admin")]*/
        public async Task<ActionResult<UserDto>> GetUserById([FromQuery] Guid request)
        {
            var response = await _mediator.Send(new GetUserByIdQuery(request));
            return Ok(response);
        }

        // PUT api/<userController>/5
        [HttpPut]
        [Route("updateUserById")]
        public async Task<ActionResult<UserDto>> UpdateUser(Guid id, [FromBody] UpdateUserCommand request)
        {
            if (id != request.Id) {
                return BadRequest();
            }
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        // DELETE api/<userController>/5
        [HttpDelete]
        [Route("deleteUserById")]
        public async Task<ActionResult> Delete([FromQuery] Guid request)
        {
            var command = new DeleteUserCommand { Id = request };
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
