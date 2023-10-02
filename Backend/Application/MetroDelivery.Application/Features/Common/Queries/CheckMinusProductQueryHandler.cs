using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Contracts.Persistance;

namespace MetroDelivery.Application.Features.Common.Queries
{
    public class CheckMinusProductQueryHandler : IRequestHandler<CheckMinusProductQuery, MetroPickUpResponse>
    {
        private readonly IProductRepository _customerRepository;

        public CheckMinusProductQueryHandler(IProductRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public Task<MetroPickUpResponse> Handle(CheckMinusProductQuery request, CancellationToken cancellationToken)
        {

            throw new NotImplementedException();
        }
    }
}
