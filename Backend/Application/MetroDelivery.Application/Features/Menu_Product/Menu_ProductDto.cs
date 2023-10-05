using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Menu_Product
{
    public class Menu_ProductDto
    {
        public Guid Id { get; set; }

        [ForeignKey("Menu")]
        public Guid MenuID { get; set; }
        [ForeignKey("Product")]
        public Guid ProductID { get; set; }

    }
}
