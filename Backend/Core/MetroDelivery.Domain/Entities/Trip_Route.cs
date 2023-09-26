using MetroDelivery.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroDelivery.Domain.Entities
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
