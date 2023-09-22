using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Menu_Product : BaseAuditableEntity
    {
        [ForeignKey("Menu")]
        public Guid MenuID { get; set; }
        [ForeignKey("Product")]
        public Guid ProductID {  get; set; }

        // relationship
        public virtual Menu Menu { get; set; }
        public virtual Product Products { get; set; }
    }
}
