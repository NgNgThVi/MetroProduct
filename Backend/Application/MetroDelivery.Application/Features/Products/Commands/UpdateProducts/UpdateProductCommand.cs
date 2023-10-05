using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Contant;
using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Products.Commands.UpdateProducts
{
    public class UpdateProductCommand : IRequest<MetroPickUpResponse>
    {
        public Product Product { get; set; } = null!;
    }

    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, MetroPickUpResponse>
    {
        private IProductRepository _productRepository;

        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<MetroPickUpResponse> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            try {
                await _productRepository.UpdateAsync(request.Product);
                return new MetroPickUpResponse
                {
                    Message = Extension.Ok
                };
            }
            catch (Exception ex) {
                return new MetroPickUpResponse
                {
                    Message = ex.Message
                };
            }
        }
    }
}
