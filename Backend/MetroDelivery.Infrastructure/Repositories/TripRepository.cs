using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Infrastructure.DatabaseContext;

namespace MetroDelivery.Infrastructure.Repositories
{
    public class TripRepository : GenericRepository<Trip>, ITripRepository
    {
        public TripRepository(MetroDeliveryDatabaseContext context) : base(context)
        {
        }
    }
}
