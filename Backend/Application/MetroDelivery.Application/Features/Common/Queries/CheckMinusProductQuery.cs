using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;

namespace MetroDelivery.Application.Features.Common.Queries
{
    public class CheckMinusProductQuery : IRequest<MetroPickUpResponse>
    {
        public string? ProductId { get; set; }
    }
}
