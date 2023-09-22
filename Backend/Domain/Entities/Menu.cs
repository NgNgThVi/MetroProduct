using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Menu : BaseAuditableEntity
    {
        [ForeignKey("Store")]
        public Guid StoreID { get; set; }   
        public DateTime StartTimeService { get; set; }
        public DateTime EndTimeService { get; set;}

        //relationship
        public virtual Store Store { get; set; }
        public IList<Menu_Product> Menu_Products { get; private set;}
    }
}
