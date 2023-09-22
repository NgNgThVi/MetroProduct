using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Infrastructure.DatabaseContext;

namespace MetroDelivery.Infrastructure.Repositories
{
    public class TripRouteRepository : GenericRepository<Trip_Route>, ITripRouteRepository
    {
        public TripRouteRepository(MetroDeliveryDatabaseContext context) : base(context)
        {
        }
    }
}
