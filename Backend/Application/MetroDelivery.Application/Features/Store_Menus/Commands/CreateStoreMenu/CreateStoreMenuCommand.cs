using AutoMapper;
using MediatR;
using MetroDelivery.Application.Common.Exceptions;
using MetroDelivery.Application.Common.Interface;
using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Store_Menus.Commands.CreateStoreMenu
{
    public class CreateStoreMenuCommand : IRequest<Guid>
    {
        public List<string> MenuIds { get; init; }
        public string StoreId { get; init; }
        public string ApplyDate { get; set; }
        public bool Priority { get; set; }
    }

    public class CreateStoreMenuCommandHandler : IRequestHandler<CreateStoreMenuCommand, Guid>
    {
        private readonly IMetroPickUpDbContext _metroPickUpDbContext;
        private readonly IMapper _mapper;
        public CreateStoreMenuCommandHandler(IMetroPickUpDbContext metroPickUpDbContext, IMapper mapper)
        {
            _metroPickUpDbContext = metroPickUpDbContext;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateStoreMenuCommand request, CancellationToken cancellationToken)
        {
            var menuIdParse = request.MenuIds.Select(Guid.Parse).ToList();
            var menuIds = await _metroPickUpDbContext.Menu.Where(m => menuIdParse.Contains(m.Id)).ToListAsync();

            if (menuIds.Count() == 0) {
                throw new NotFoundException($"Không tìm thấy Menu nào!");
            }

            foreach (var item in menuIds) {
                var storeMenuExist = await _metroPickUpDbContext.Store_Menu.Where(m => m.MenuId == item.Id 
                                                            && m.StoreId == Guid.Parse(request.StoreId)
                                                            && m.Priority == true).SingleOrDefaultAsync();
                if(storeMenuExist != null) {
                    throw new NotFoundException($"Cửa hàng này {request.StoreId} đã được tạo với menu này {item.Id} rồi và đang priority = 1");
                }
                var storeMenu = new Store_Menu
                {
                    MenuId = item.Id,
                    StoreId = Guid.Parse(request.StoreId),
                    ApplyDate = request.ApplyDate,
                    Priority = request.Priority,
                };

                _metroPickUpDbContext.Store_Menu.Add(storeMenu);
            }
            await _metroPickUpDbContext.SaveChangesAsync();
            return menuIds[0].Id;
        }
    }
}
