using MetroDelivery.Domain.Common;

namespace MetroDelivery.Domain.Entities
{
    public class Category : BaseAuditableEntity
    {
        public string CategoryName { get;set; }
    }
}
