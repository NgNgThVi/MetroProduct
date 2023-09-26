using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Persistence.DatabaseContext;

namespace MetroDelivery.Persistence.Repositories
{
    public class MenuProductRepository : GenericRepository<Menu_Product>, IMenuProductRepository
    {
        public MenuProductRepository(MetroDeliveryDatabaseContext context) : base(context)
        {
        }
    }
}
