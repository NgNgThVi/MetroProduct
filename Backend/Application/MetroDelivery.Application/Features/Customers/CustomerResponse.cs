﻿using AutoMapper;
using MetroDelivery.Application.Common.Mapping;
using MetroDelivery.Application.Features.Staff.Queries;
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

        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double? Wallet { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime? Birthday { get; set; }

        public DateTime? Created { get; set; }
    }

    public class CustomerRole
    {
        public string CustomerId { get; set; }
        public string RoleId { get; set; }

        public RoleData? RoleData { get; set; }
        public CustomerInfo? CustomerData { get; set; }
    }

    public class CustomerInfo
    {
        public string Id { get; set; }

        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public double? Wallet { get; set; }
        public string Address { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? Created { get; set; }
    }
}
