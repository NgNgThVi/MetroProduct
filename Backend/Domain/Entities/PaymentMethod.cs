using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
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
