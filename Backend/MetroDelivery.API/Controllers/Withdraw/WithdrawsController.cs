/*using MediatR;
using MetroDelivery.Application.Features.Trips.Queries.GetAllTrip;
using MetroDelivery.Application.Features.Trips.Queries;
using Microsoft.AspNetCore.Mvc;
using MetroDelivery.Application.Features.Withdraws.Queries;
using MetroDelivery.Application.Features.Withdraws.Queries.GetAllWithdraw;
using MetroDelivery.Application.Features.Trips.Commands.CreateTrip;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Features.Trips.Commands.UpdateTrip;
using MetroDelivery.Application.Features.Stores.Queries.GetStoreById;
using MetroDelivery.Application.Features.Stores;
using MetroDelivery.Application.Features.Withdraws.Queries.GetByIdWithdraw;
using MetroDelivery.Application.Features.Stores.Commands.CreateStores;
using MetroDelivery.Application.Features.Stores.Commands.DeleteStore;
using MetroDelivery.Application.Features.Stores.Commands.UpdateStore;
using MetroDelivery.Application.Features.Withdraws.Commands.CreateWithdraw;
using MetroDelivery.Application.Features.Withdraws.Commands.UpdateWithdraw;
using MetroDelivery.Application.Features.Withdraws.Commands.DeleteWithdraw;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Withdraw
{
    [Route("api/v1/with-draw")]
    [ApiController]
    public class WithdrawsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WithdrawsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all")]
        public async Task<List<WithdrawResponse>> GetAll()
        {
            var response = await _mediator.Send(new GetListWithdrawQuery());
            return response;
        }

        [HttpGet]
        [Route("by-id")]
        public async Task<WithdrawResponse> Get([FromQuery] GetByIdWithdrawQuery request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Create([FromBody] CreateWithdrawCommand request)
        {
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(GetAll), new { id = response });
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<MetroPickUpResponse> Update(UpdateWithdrawCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<MetroPickUpResponse> Delete([FromQuery] DeleteWithdrawCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
*/