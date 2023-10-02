using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Constant;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;

namespace MetroDelivery.Application.Features.Products.Commands.UpdateProduct
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, MetroPickUpResponse>
    {
        private IProductRepository _productRepository;

        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<MetroPickUpResponse> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                await _productRepository.UpdateAsync(request.Product);
                return new MetroPickUpResponse
                {
                    Message = Extension.Ok
                };
            }
            catch (Exception ex)
            {
                return new MetroPickUpResponse
                {
                    Message = ex.Message
                };
            }
        }
    }
}
