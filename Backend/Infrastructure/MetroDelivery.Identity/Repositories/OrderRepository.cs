using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Identity.DbContext;

namespace MetroDelivery.Identity.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(MetroPickupIdentityDbContext context) : base(context)
        {
        }
    }
}
