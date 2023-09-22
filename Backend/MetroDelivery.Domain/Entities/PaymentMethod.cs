using MetroDelivery.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroDelivery.Domain.Entities
{
    public class PaymentMethod : BaseAuditableEntity
    {
        [ForeignKey("Order")]
        public Guid OrderID { get; set; }
        public string PaymentMethodName { get; set; }

        //relationship
        public virtual Order Order { get; set; }
    }
}
