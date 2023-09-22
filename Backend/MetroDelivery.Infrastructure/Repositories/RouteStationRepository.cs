using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Infrastructure.DatabaseContext;

namespace MetroDelivery.Infrastructure.Repositories
{
    public class RouteStationRepository : GenericRepository<Route_Station>, IRouteStationRepository
    {
        public RouteStationRepository(MetroDeliveryDatabaseContext context) : base(context)
        {
        }
    }
}
