using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Features.Orders.Commands.CreateOrder;
using MetroDelivery.Application.Features.PaymentMethods.Queries;
using MetroDelivery.Application.Features.PaymentMethods.Queries.GetAllPaymentMethod;
using MetroDelivery.Application.Features.PaymentMethods.Queries.GetByIdPaymentMethod;
using MetroDelivery.Application.Features.PaymentMethods.Queries.GetPaymentHistory;
using MetroDelivery.Application.Models.VnPay;
using MetroDelivery.Identity.Services.VnPay;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MetroDelivery.API.Controllers.PaymentMethods
{
    [Route("api/v1/payment-method")]
    [ApiController]
    public class PaymentMethodsController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IVnPayService _vnPayService;

        public PaymentMethodsController(IMediator mediator, IVnPayService vnPayService)
        {
            _mediator = mediator;
            _vnPayService = vnPayService;
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

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        /*[Authorize(Roles = "EndUser")]*/
        public IActionResult CreateOrder([FromBody] PaymentInformation request)
        {
            if (ModelState.IsValid) {
                var url = _vnPayService.CreatePaymentUrl(request, HttpContext);
                var response = new PaymentUrlResponse { PaymentUrl = url };
                return Ok(response);
            }
            else {
                return BadRequest("Invalid payment information.");
            }
        }

        [HttpGet("PaymentCallback")]
        public IActionResult PaymentCallback()
        {
            var response = _vnPayService.PaymentExecute(Request.Query);
            return Ok(response);
        }

        // history
        [HttpGet]
        [Route("get-payment-history-by-order-id")]
        public async Task<ActionResult<PaymentMethodResponse>> Get([FromQuery] GetPaymentHistoryQuery request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }

    public class PaymentUrlResponse
    {
        public string PaymentUrl { get; set; }
    }
}
