using MetroDelivery.Domain.Common;

namespace MetroDelivery.Domain.Entities
{
    public class Trip : BaseAuditableEntity
    {
        public string TripName { get; set; }
        public DateTime TripStartTime { get; set; }
        public DateTime TripEndTime { get; set;}

        //relationship
        public IList<Order> Order { get; set; } 
        public IList<Trip_Route> Trip_Routes { get; private set; }
    }
}
