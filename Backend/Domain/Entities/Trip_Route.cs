using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Trip_Route : BaseAuditableEntity
    {
        [ForeignKey("Trip")]
        public Guid TripID { get; set; }
        [ForeignKey("Route")]
        public Guid RouteID { get; set; }

        //relationship
        public virtual Trip Trip { get; set; }
        public virtual Route Route { get; set; }
    }
}
