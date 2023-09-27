using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Identity.DbContext;

namespace MetroDelivery.Identity.Repositories
{
    public class TripRepository : GenericRepository<Trip>, ITripRepository
    {
        public TripRepository(MetroPickupIdentityDbContext context) : base(context)
        {
        }
    }
}
