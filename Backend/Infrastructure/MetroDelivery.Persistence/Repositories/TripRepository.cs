using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Persistence.DatabaseContext;

namespace MetroDelivery.Persistence.Repositories
{
    public class TripRepository : GenericRepository<Trip>, ITripRepository
    {
        public TripRepository(MetroDeliveryDatabaseContext context) : base(context)
        {
        }
    }
}
