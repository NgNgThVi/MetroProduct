using MetroDelivery.Domain.Common;

namespace MetroDelivery.Domain.Entities
{
    public class Store : BaseAuditableEntity
    {
        public string StoreName { get; set; }
        public string StoreLocation { get; set; }
        public TimeSpan? StoreOpenTime { get; set; }
        public TimeSpan? StoreCloseTime { get; set;}

        // relationship
        public IList<Order> Orders { get; private set; }
        public IList<Station> Stations { get; private set; }
        public IList<Store_Menu> Store_Menu { get; private set; }
        
    }
}
