using MetroDelivery.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroDelivery.Domain.Entities
{
    public class Order : BaseAuditableEntity
    {
        [ForeignKey("Customer")]
        public Guid CustomerID { get; set; }
        [ForeignKey("Trip")]
        public Guid TripID { get; set; }
        [ForeignKey("Store")]
        public Guid StoreID { get; set; }

        public double? TotalPrice { get; set; }
        public string? OrderTokenQR { get; set; }

        //relationship
        public virtual Customer Customer { get; private set; }
        public virtual Trip Trip { get; private set; }
        public virtual Store Store { get; private set; }
        
        public IList<OrderDetail> OrderDetail { get; private set; }
    }
}
