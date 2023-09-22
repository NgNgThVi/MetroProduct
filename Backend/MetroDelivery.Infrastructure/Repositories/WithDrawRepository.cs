using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Infrastructure.DatabaseContext;

namespace MetroDelivery.Infrastructure.Repositories
{
    public class WithDrawRepository : GenericRepository<WithDraw>, IWithDrawRepository
    {
        public WithDrawRepository(MetroDeliveryDatabaseContext context) : base(context)
        {
        }
    }
}
