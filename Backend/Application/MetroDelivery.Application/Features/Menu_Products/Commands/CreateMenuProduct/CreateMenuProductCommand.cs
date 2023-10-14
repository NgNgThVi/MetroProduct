using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Features.OrderDetails.Queries;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Menu_Products.Commands.CreateMenuProduct
{
    public class CreateMenuProductCommand : IRequest<Guid>
    {
        /*public Guid MenuID { get; set; }*/
        public TimeSpan StartTimeService { get; set; }
        public TimeSpan EndTimeService { get; set; }

        public List<ProductList> ProductData { get; init; }
    }
    public class ProductList
    {
        public Guid ProductID { get; init; }
        public double? PriceOfProductBelongToTimeService { get; set; }
    }

    public class CreateMenuProductCommandHandler : IRequestHandler<CreateMenuProductCommand, Guid>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public CreateMenuProductCommandHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateMenuProductCommand request, CancellationToken cancellationToken)
        {
            var productIs = request.ProductData.Select(s => s.ProductID).ToList();
            var productExist = await _metroPickUpDbContext.Product.Where(p => productIs.Contains(p.Id) && !p.IsDelete).ToListAsync();

            // tạo menu
            var checkMenuExist = await _metroPickUpDbContext.Menu.Where(m => m.StartTimeService == request.StartTimeService && m.EndTimeService == request.EndTimeService && !m.IsDelete).SingleOrDefaultAsync();
            if (checkMenuExist != null) {
                throw new NotFoundException("Menu này đã tạo trong Menu_Product rồi");
            }
            var menu = new Menu
            {
                StartTimeService = request.StartTimeService,
                EndTimeService = request.EndTimeService,
            };

            _metroPickUpDbContext.Menu.Add(menu);
            await _metroPickUpDbContext.SaveChangesAsync();

            // tạo menu_product
            if (productExist.Count() == 0) {
                throw new NotFoundException($"Không tìm thấy Product nào!");
            }

            foreach ( var productData in request.ProductData) {
                var product = productExist.FirstOrDefault(p => p.Id == productData.ProductID);
                if(product == null) {
                    throw new NotFoundException($"Không tìm thấy product {product} này!");
                }
                var entityMenuProduct = new Menu_Product();
                entityMenuProduct.MenuID = menu.Id;
                entityMenuProduct.ProductID = product.Id;
                entityMenuProduct.PriceOfProductBelongToTimeService = productData.PriceOfProductBelongToTimeService;
            
                _metroPickUpDbContext.Menu_Product.Add(entityMenuProduct);
            }

            await _metroPickUpDbContext.SaveChangesAsync(); 
            return productExist[0].Id;
        }
    }
}
