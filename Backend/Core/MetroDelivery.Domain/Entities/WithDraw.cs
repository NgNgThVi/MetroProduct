using MetroDelivery.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroDelivery.Domain.Entities
{
    public class WithDraw : BaseAuditableEntity
    {
        [ForeignKey("Customer")]
        public Guid CustomerID { get; set; }
        [ForeignKey("PaymentMethod")]
        public Guid PaymentMethodID { get; set; }
        public double? Balance { get; set; }
        public double? Deposit { get; set; }
        public DateTime? CreateTimeOfWithdraw { get; set; }

        // relationship
        public virtual Customer Customer { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
