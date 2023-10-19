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
        public string StationId { get; set; }
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
            var stationExist = await _metroPickUpDbContext.Station.Where(s => s.Id == Guid.Parse(request.StationId)).SingleOrDefaultAsync();
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
            var currentDayOfWeek = vietnamTime.DayOfWeek;

            // kiểm tra ngày với priority trong StoreMenu nếu thỏa priority thì lấy ra 
            var storeMenus = await _metroPickUpDbContext.Store_Menu.Where(m => (m.Menu.StartTimeService <= vietnamTime.TimeOfDay)
                                                                    && (m.Menu.EndTimeService > vietnamTime.TimeOfDay)
                                                                    && m.ApplyDate == currentDayOfWeek.ToString() // chỗ này là thứ mấy
                                                                    && m.Priority == true
                                                                    && m.StoreId == stationExist.StoreID)
                                                                    .SingleOrDefaultAsync();
            if (storeMenus == null) {
                if (stationExist == null) {
                    throw new ArgumentNullException(nameof(stationExist), "Station không được phép là null");
                }
                throw new NotFoundException("StoreMenu chưa được tạo, cần phải có storeMenu, hoặc hết giờ hoặt động của cửa hàng");
            }
            var sotrmenu = storeMenus.MenuId;
            

            // get MenuProduct với cái Menu của StoreMenu
            var menuProductList = await _metroPickUpDbContext.Menu_Product.Where(s => !s.IsDelete && s.MenuID == storeMenus.MenuId)
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
