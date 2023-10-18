using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Application.Features.Menus.Queries;
using MetroDelivery.Application.Features.OrderDetails.Queries;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Menu_Products.Queries.GetMenuProductByTimeService
{
    public class GetMenuProductByStationIdQuery : IRequest<List<MenuProductResponse>>
    {
        public Guid StationId { get; set; }
    }

    public class GetMenuProductByStationIdQueryQueryHandler : IRequestHandler<GetMenuProductByStationIdQuery, List<MenuProductResponse>>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public GetMenuProductByStationIdQueryQueryHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<List<MenuProductResponse>> Handle(GetMenuProductByStationIdQuery request, CancellationToken cancellationToken)
        {
            var stationExist = await _metroPickUpDbContext.Station.Where(s => s.Id == request.StationId).SingleOrDefaultAsync();
            if (stationExist == null) {
                throw new NotFoundException($"Not found station with {stationExist}");
            }
            if (stationExist.IsDelete == true) {
                throw new NotFoundException($"station đã bị xóa");
            }

            // Lấy thông tin về múi giờ của Việt Nam
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");

            // Lấy thời gian hiện tại theo múi giờ của Việt Nam
            DateTime vietnamTime = TimeZoneInfo.ConvertTime(DateTime.Now, vietnamTimeZone);

            var menus = await _metroPickUpDbContext.Menu.Where(m => (m.StartTimeService <= vietnamTime.TimeOfDay) && (m.EndTimeService > vietnamTime.TimeOfDay)).SingleOrDefaultAsync();
            if (menus == null) {
                throw new NotFoundException("Cửa hàng đã đóng cửa, xin quý khách quay lại vào 6h sáng mai");
            }

            var storeMenu = await _metroPickUpDbContext.Store_Menu.Where(s => !s.IsDelete && s.MenuId == menus.Id && s.StoreId == stationExist.StoreID).SingleOrDefaultAsync();
            if (storeMenu == null) {
                var storeMenuEntity = new Store_Menu
                {
                    MenuId = menus.Id,
                    StoreId = stationExist.StoreID,
                };
                _metroPickUpDbContext.Store_Menu.Add(storeMenuEntity);
                await _metroPickUpDbContext.SaveChangesAsync();

                var menuProductList1 = await _metroPickUpDbContext.Menu_Product.Where(s => !s.IsDelete && s.Menu.StartTimeService == storeMenuEntity.Menu.StartTimeService && s.Menu.EndTimeService == storeMenuEntity.Menu.EndTimeService)
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

                return menuProductList1;
            }
           
            var menuProductList = await _metroPickUpDbContext.Menu_Product.Where(s => !s.IsDelete && s.Menu.StartTimeService == storeMenu.Menu.StartTimeService && s.Menu.EndTimeService == storeMenu.Menu.EndTimeService)
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
