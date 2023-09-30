using MetroDelivery.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroDelivery.Domain.Entities
{
    public class Product : BaseAuditableEntity
    {
        [ForeignKey("Store")]
        public Guid StoreID { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryID { get; set; }
        public string ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string? Image { get; set; }
        public int stock { get; set; }
        public double price { get; set; }

        //relationship
        public virtual Store Store { get; set; }
        public virtual Category Category { get; set; }
        public IList<Menu_Product> Menu_Products { get; private set; }
        public IList<OrderDetail> OrderDetails { get; private set; }
    }
}
