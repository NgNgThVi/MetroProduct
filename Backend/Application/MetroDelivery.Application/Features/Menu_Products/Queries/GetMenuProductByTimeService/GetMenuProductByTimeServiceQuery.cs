using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Features.Menus.Queries;
using MetroDelivery.Application.Features.OrderDetails.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Menu_Products.Queries.GetMenuProductByTimeService
{
    public class GetMenuProductByTimeServiceQuery : IRequest<List<MenuProductResponse>>
    {
        public TimeSpan StartTimeService { get; set; }
        public TimeSpan EndTimeService { get; set; }
    }

    public class GetMenuProductByTimeServiceQueryHandler : IRequestHandler<GetMenuProductByTimeServiceQuery, List<MenuProductResponse>>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public GetMenuProductByTimeServiceQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<List<MenuProductResponse>> Handle(GetMenuProductByTimeServiceQuery request, CancellationToken cancellationToken)
        {
            var menuProductList = await _metroPickUpDbContext.Menu_Product.Where(s => !s.IsDelete && s.Menu.StartTimeService == request.StartTimeService && s.Menu.EndTimeService == request.EndTimeService)
                                                                .Join(
                                                                    _metroPickUpDbContext.Menu,
                                                                    menuProduct => menuProduct.MenuID,
                                                                    menu => menu.Id,
                                                                    (menuProduct, menu) => new
                                                                    {
                                                                        MenuProducts = menuProduct,
                                                                        Menus = menu
                                                                    }
                                                                )
                                                                .Join(
                                                                    _metroPickUpDbContext.Product,
                                                                    combined => combined.MenuProducts.ProductID,
                                                                    product => product.Id,
                                                                    (combined, product) => new MenuProductResponse
                                                                    {
                                                                        Id = combined.MenuProducts.Id,
                                                                        MenuID = combined.MenuProducts.MenuID,
                                                                        ProductID = combined.MenuProducts.ProductID,
                                                                        PriceOfProductBelongToTimeService = combined.MenuProducts.PriceOfProductBelongToTimeService,
                                                                        Created = combined.MenuProducts.Created,

                                                                        MenuData = _mapper.Map<MenuResponse>(combined.Menus),
                                                                        ProductData = _mapper.Map<ProductData>(product)
                                                                    }
                                                                ).ToListAsync();

            return menuProductList;
        }
    }
}
