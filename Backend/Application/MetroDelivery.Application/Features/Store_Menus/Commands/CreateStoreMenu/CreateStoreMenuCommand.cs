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
        public List<Guid> MenuIds { get; init; }
        public Guid StoreId { get; init; }
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
            var menuIds = await _metroPickUpDbContext.Menu.Where(m => request.MenuIds.Contains(m.Id)).ToListAsync();

            if(menuIds.Count() == 0) {
                throw new NotFoundException($"Không tìm thấy Menu nào!");
            }

            foreach(var item in menuIds) {
                var storeMenu = new Store_Menu
                {
                    MenuId = item.Id,
                    StoreId = request.StoreId,
                };

                _metroPickUpDbContext.Store_Menu.Add(storeMenu);
            }
            await _metroPickUpDbContext.SaveChangesAsync();
            return menuIds[0].Id;
        }
    }
}
