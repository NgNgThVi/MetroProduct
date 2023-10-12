using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
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
        public Guid MenuID { get; set; }
        public List<Guid> ProductID { get; init; }

        /*public double? PriceOfProductBelongToTimeService { get; set; }*/
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
            var productExist = await _metroPickUpDbContext.Products.Where(p => request.ProductID.Contains(p.Id) && !p.IsDelete).ToListAsync();
            if(productExist.Count() == 0) {
                throw new NotFoundException($"Không tìm thấy Product nào!");
            }
            
            foreach( var product in productExist) {
                var entityMenuProduct = new Menu_Product();
                entityMenuProduct.MenuID = request.MenuID;
                entityMenuProduct.ProductID = product.Id;
                entityMenuProduct.PriceOfProductBelongToTimeService = product.Price * 0.02; // dựa theo price của bảng product để thay đổi giá cả
            
                _metroPickUpDbContext.Menu_Products.Add(entityMenuProduct);
            }

            await _metroPickUpDbContext.SaveChangesAsync(); 
            return productExist[0].Id;
        }
    }
}
