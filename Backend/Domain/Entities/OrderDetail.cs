using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderDetail : BaseAuditableEntity
    {
        [ForeignKey("Order")]
        public Guid OrderID { get; set; }
        [ForeignKey("Product")]
        public Guid ProductID { get; set; }
        public int quanity { get; set; }
        public double price { get; set; }

        // relationship
        public virtual Order Order { get; private set; }
        public virtual Product Products { get; private set; }
    }
}
