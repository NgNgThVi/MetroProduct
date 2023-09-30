using MetroDelivery.Domain.Common;

namespace MetroDelivery.Domain.Entities
{
    public class Store : BaseAuditableEntity
    {
        public string StoreName { get; set; }
        public string StoreLocation { get; set; }
        public DateTime StoreOpenTime { get; set; }
        public DateTime StoreCloseTime { get; set;}

        // relationship
        public IList<Order> Orders { get; private set; }
        public IList<Station> Stations { get; private set; }
        public IList<Menu> Menus { get; private set; }
    }
}
