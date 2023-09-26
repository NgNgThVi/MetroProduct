using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Persistence.DatabaseContext;

namespace MetroDelivery.Persistence.Repositories
{
    public class RouteStationRepository : GenericRepository<Route_Station>, IRouteStationRepository
    {
        public RouteStationRepository(MetroDeliveryDatabaseContext context) : base(context)
        {
        }
    }
}
