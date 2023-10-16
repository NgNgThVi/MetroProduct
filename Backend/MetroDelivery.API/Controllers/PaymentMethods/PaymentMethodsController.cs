using MediatR;
using MetroDelivery.Application.Features.Customers;
using MetroDelivery.Application.Features.PaymentMethods.Queries;
using MetroDelivery.Application.Features.PaymentMethods.Queries.GetAllPaymentMethod;
using MetroDelivery.Application.Features.PaymentMethods.Queries.GetByIdPaymentMethod;
using MetroDelivery.Application.Features.Routes.Queries.GetByFromToRoute;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.PaymentMethods
{
    [Route("api/v1/payment-method")]
    [ApiController]
    public class PaymentMethodsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaymentMethodsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<PaymentMethodResponse>> GetAll()
        {
            var response = await _mediator.Send(new GetListPaymentMethodQuery());
            return response;
        }

        [HttpGet]
        [Route("get-payment-method-by-id")]
        public async Task<ActionResult<PaymentMethodResponse>> GetUserById([FromQuery] GetByIdPaymentMethodQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
