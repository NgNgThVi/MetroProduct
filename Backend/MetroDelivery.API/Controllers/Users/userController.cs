
using MediatR;
using MetroDelivery.Application.Features.Users;
using MetroDelivery.Application.Features.Users.Commands.CreateUser;
using MetroDelivery.Application.Features.Users.Queries.GetAllUsers;
using MetroDelivery.Application.Features.Users.Queries.GetUserDetail;
using MetroDelivery.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Users
{
    [Route("api/[controller]")]
    [ApiController]
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
        public async Task<List<UserDto>> GetAllUser()
        {
            var response = await _mediator.Send(new GetListUserQuery());
            return response;
        }

        // POST api/<userController>
        [HttpPost]
        [Route("register")]
        public async Task<ActionResult> Post(CreateUserCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(GetAllUser), new { id = response });
        }

        // PUT api/<userController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<userController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
