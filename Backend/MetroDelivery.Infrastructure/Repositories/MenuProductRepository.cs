using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Infrastructure.DatabaseContext;

namespace MetroDelivery.Infrastructure.Repositories
{
    public class MenuProductRepository : GenericRepository<Menu_Product>, IMenuProductRepository
    {
        public MenuProductRepository(MetroDeliveryDatabaseContext context) : base(context)
        {
        }
    }
}
