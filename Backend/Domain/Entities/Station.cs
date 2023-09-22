using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Station : BaseAuditableEntity
    {
        [ForeignKey("Store")]
        public Guid StoreID { get; set; }
        public string StationName { get; set; }

        // relationship 
        public IList<Route_Station> Route_Stations { get; private set;}
        public virtual Store Store { get; set; }
    }
}
