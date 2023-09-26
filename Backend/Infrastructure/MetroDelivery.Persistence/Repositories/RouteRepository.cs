using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Persistence.DatabaseContext;

namespace MetroDelivery.Persistence.Repositories
{
    public class RouteRepository : GenericRepository<Route>, IRouteRepository
    {
        public RouteRepository(MetroDeliveryDatabaseContext context) : base(context)
        {
        }
    }
}
