using MetroDelivery.Domain.IdentityModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Customers.Queries.GetCustomerByApplicationUserId
{
    public class CustomerResponse
    {
        public CustomerDto? CustomerData { get; set; }

        public ApplicationUserData? ApplicationUserData { get; set; }
    }

    public class ApplicationUserData
    {
        public string Id { get; set; }
        public string? Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
