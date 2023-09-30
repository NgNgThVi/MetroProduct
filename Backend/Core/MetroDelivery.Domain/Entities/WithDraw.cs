using MetroDelivery.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroDelivery.Domain.Entities
{
    public class WithDraw : BaseAuditableEntity
    {
        [ForeignKey("User")]
        public Guid UserID { get; set; }
        public double? Balance { get; set; }

        // relationship
        public virtual Customer Customer { get; set; }
    }
}
