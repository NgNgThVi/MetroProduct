using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Identity.DbContext;

namespace MetroDelivery.Identity.Repositories
{
    public class MenuRepository : GenericRepository<Menu>, IMenuRepository
    {
        public MenuRepository(MetroPickupIdentityDbContext context) : base(context)
        {
        }
    }
}
