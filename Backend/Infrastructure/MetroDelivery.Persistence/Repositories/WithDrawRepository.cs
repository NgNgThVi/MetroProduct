using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Persistence.DatabaseContext;

namespace MetroDelivery.Persistence.Repositories
{
    public class WithDrawRepository : GenericRepository<WithDraw>, IWithDrawRepository
    {
        public WithDrawRepository(MetroDeliveryDatabaseContext context) : base(context)
        {
        }
    }
}
