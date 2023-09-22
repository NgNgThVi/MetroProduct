using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Infrastructure.DatabaseContext;

namespace MetroDelivery.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(MetroDeliveryDatabaseContext context) : base(context)
        {
        }
    }
}
