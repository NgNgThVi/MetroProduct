using AutoMapper;
using MetroDelivery.Application.Common.Mapping;
using MetroDelivery.Domain.Entities;
using MetroDelivery.Domain.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Customers
{
    [AutoMap(typeof(ApplicationUser))]
    public class CustomerResponse
    {
        public string Id { get; set; }

        public string UserName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double? Wallet { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime? Birthday { get; set; }
    }
}
