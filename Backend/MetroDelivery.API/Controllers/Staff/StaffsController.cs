using MediatR;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Application.Features.Staff.Queries;
using MetroDelivery.Application.Features.Staff.Queries.GetAllStaff;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<List<StaffRole>> Get()
        {
            var response = await _mediator.Send(new GetListStaffQuery());
            return response;
        }

        
    }
}
