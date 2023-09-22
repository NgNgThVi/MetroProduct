using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Route_Station : BaseAuditableEntity
    {
        [ForeignKey("Route")]
        public Guid RouteID { get; set; }
        [ForeignKey("Station")]
        public Guid StationID {  get; set; }

        //relationship
        public virtual Route Route { get; set; }
        public virtual Station Station { get; set; }
    }
}
