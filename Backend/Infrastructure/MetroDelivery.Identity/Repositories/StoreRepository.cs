using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Identity.DbContext;

namespace MetroDelivery.Identity.Repositories
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        public StoreRepository(MetroPickupIdentityDbContext context) : base(context)
        {
        }
    }
}
