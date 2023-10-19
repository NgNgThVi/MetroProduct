﻿using MetroDelivery.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroDelivery.Domain.Entities
{
    public class Menu : BaseAuditableEntity
    {   
        public TimeSpan StartTimeService { get; set; }
        public TimeSpan EndTimeService { get; set;}
        public string ApplyDate { get; set;}
        public bool Priority { get; set;}

        //relationship
        public IList<Store_Menu> Store_Menu { get; set; }
        public IList<Menu_Product> Menu_Product { get; private set;}
    }
}
