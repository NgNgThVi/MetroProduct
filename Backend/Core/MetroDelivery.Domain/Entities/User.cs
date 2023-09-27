using MetroDelivery.Domain.Common;
using MetroDelivery.Domain.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroDelivery.Domain.Entities
{
    public class User : BaseAuditableEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }

        // relationship
        public IList<Order> Orders { get; private set; }
        public IList<WithDraw> WithDraws { get; private set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
