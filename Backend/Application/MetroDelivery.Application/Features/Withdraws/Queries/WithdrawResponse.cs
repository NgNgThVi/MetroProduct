using MetroDelivery.Application.Features.PaymentMethods.Queries;
using MetroDelivery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Application.Features.Withdraws.Queries
{
    public class WithdrawResponse
    {
        public Guid Id { get; set; }

        public Guid CustomerID { get; set; }
        public Guid PaymentMethodID { get; set; }
        public double? Balance { get; set; }
        public double? Deposit { get; set; }
        public DateTime? CreateTimeOfWithdraw { get; set; }

        // relationship
        public CustomerData? CustomerData { get; set; }
        public PaymentMethodResponse? PaymentMethodData { get; set; }
    }

    public class CustomerData
    {
        public Guid Id { get; set; }
        public string ApplicationUserId { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
    }
}
