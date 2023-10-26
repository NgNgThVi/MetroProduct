using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.CRUDResponse;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Features.Menu_Products.Commands.CreateMenuProduct;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Menu_Products.Commands.UpdateMenuProduct
{
    public class UpdateMenuProductCommand : IRequest<MetroPickUpResponse>
    {
        public string MenuProductId { get; set; }
        public List<ProductList> ProductData { get; init; }
    }
    public class ProductList
    {
        public string ProductID { get; init; }
        public double? PriceOfProductBelongToTimeService { get; set; }
    }

    public class UpdateMenuProductCommandHandler : IRequestHandler<UpdateMenuProductCommand, MetroPickUpResponse>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public UpdateMenuProductCommandHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<MetroPickUpResponse> Handle(UpdateMenuProductCommand request, CancellationToken cancellationToken)
        {
            var productIs = request.ProductData.Select(s => Guid.Parse(s.ProductID)).ToList();
            var productExist = await _metroPickUpDbContext.Product.Where(p => productIs.Contains(p.Id) && !p.IsDelete).ToListAsync();

            // tạo menu_product
            if (productExist.Count() == 0) {
                throw new NotFoundException($"Không tìm thấy Product nào!");
            }

            var menuProductExist = await _metroPickUpDbContext.Menu_Product
                                                .Where(mp => mp.Id == Guid.Parse(request.MenuProductId))
                                                .SingleOrDefaultAsync();
            if(menuProductExist == null) {
                throw new NotFoundException($"không có menuProdcutId này {request.MenuProductId}");
            }

            foreach (var productData in request.ProductData) {
                // check productId đã tồn tại trong menuProductId này chưa
                var existingMenuProducts = await _metroPickUpDbContext.Menu_Product
                                                .Where(mp => mp.Id == Guid.Parse(request.MenuProductId) && mp.ProductID == Guid.Parse(productData.ProductID))
                                                .Include(mp => mp.Products)
                                                .SingleOrDefaultAsync();
                if(existingMenuProducts != null) {
                    throw new NotFoundException($"product đã tồn tại trong menuProduct {existingMenuProducts} này!");
                }
                var product = productExist.FirstOrDefault(p => p.Id == Guid.Parse(productData.ProductID));
                if (product == null) {
                    throw new NotFoundException($"Không tìm thấy product {product} này!");
                }
                var entityMenuProduct = new Menu_Product();
                entityMenuProduct.ProductID = product.Id;
                entityMenuProduct.MenuID = menuProductExist.MenuID;
                entityMenuProduct.PriceOfProductBelongToTimeService = productData.PriceOfProductBelongToTimeService;

                _metroPickUpDbContext.Menu_Product.Add(entityMenuProduct);
            }

            await _metroPickUpDbContext.SaveChangesAsync();
            return new MetroPickUpResponse
            {
                Message = "Create Menu Product Successfully"
            };
        }
    }
}
