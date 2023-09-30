using MetroDelivery.Domain.Common;
using MetroDelivery.Domain.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroDelivery.Domain.Entities
{
    public class Customer : BaseAuditableEntity
    {
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime? Birthday { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }

        // relationship
        public IList<Order> Orders { get; private set; }
        public IList<WithDraw> WithDraws { get; private set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
