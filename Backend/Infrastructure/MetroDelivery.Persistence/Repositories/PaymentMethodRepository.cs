using MetroDelivery.Application.Contracts.Persistance;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Persistence.DatabaseContext;

namespace MetroDelivery.Persistence.Repositories
{
    public class PaymentMethodRepository : GenericRepository<PaymentMethod>, IPaymentMethodRepository
    {
        public PaymentMethodRepository(MetroDeliveryDatabaseContext context) : base(context)
        {
        }
    }
}
