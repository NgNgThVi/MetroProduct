using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Infrastructure.DatabaseContext;

namespace MetroDelivery.Infrastructure.Repositories
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        public StoreRepository(MetroDeliveryDatabaseContext context) : base(context)
        {
        }
    }
}
