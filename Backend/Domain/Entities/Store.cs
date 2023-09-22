using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
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
        public IList<Product> Products { get; private set; }
        public IList<Menu> Menus { get; private set; }
    }
}
