﻿using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Features.Routes.Commands.CreateRoute;
using MetroDelivery.Application.Features.Routes.Commands.DeleteRoute;
using MetroDelivery.Application.Features.Routes.Commands.UpdateRoute;
using MetroDelivery.Application.Features.Stores;
using MetroDelivery.Application.Features.Stores.Commands.CreateStores;
using MetroDelivery.Application.Features.Stores.Commands.DeleteStore;
using MetroDelivery.Application.Features.Stores.Commands.UpdateStore;
using MetroDelivery.Application.Features.Stores.Queries.GetAllStores;
using MetroDelivery.Application.Features.Stores.Queries.GetStoreById;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.Stores
{
    [Route("api/v1/store")]
    [ApiController]
    public class StoresController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StoresController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("get-all-store")]
        public Task<List<StoreDto>> GetAll()
        {
            var response = _mediator.Send(new GetListStoreQueries());
            return response;
        }

        [HttpGet]
        [Route("get-by-id")]
        public async Task<StoreDto> Get([FromQuery] GetStoreByIdQueries request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        /*[Authorize(Roles = "Manager")]*/
        public async Task<ActionResult> Create([FromBody] CreateStoreCommand request)
        {
                /*"storeName": "Metro PickUp 2",
                "storeLocation": "Số 3, Vincom, Quận Bình Thạnh",
                "storeOpenTime": "06:00:00",
                "storeCloseTime": "11:00:00"*/
            var response = await _mediator.Send(request);
            return CreatedAtAction(nameof(GetAll), new { id = response });
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        /*[Authorize(Roles = "Manager")]*/
        public async Task<MetroPickUpResponse> Update(UpdateStoreCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        /*[Authorize(Roles = "Manager")]*/
        public async Task<MetroPickUpResponse> Delete([FromQuery] DeleteStoreCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
