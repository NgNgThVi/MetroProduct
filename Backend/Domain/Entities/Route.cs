using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Route : BaseAuditableEntity
    {
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }

        //relationship
        public IList<Trip_Route> Trip_Routes { get; private set; }
        public IList<Route_Station> Route_Stations { get; private set; }

    }
}
