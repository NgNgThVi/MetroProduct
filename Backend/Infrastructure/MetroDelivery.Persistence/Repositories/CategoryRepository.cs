using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Persistence.DatabaseContext;

namespace MetroDelivery.Persistence.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(MetroDeliveryDatabaseContext context) : base(context)
        {
        }
    }
}
