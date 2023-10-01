using MetroDelivery.Domain.Entities;
using MetroDelivery.Domain.IdentityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Identity.Configurations.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
                new Customer
                {
                    Id = Guid.Parse("F9589C1A-3CBC-4215-BB84-B8FA7D719440"),
                    Phone = "03030303",
                    Address = "da nang",
                    Birthday = DateTime.ParseExact("20/10/2002", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ApplicationUserId = "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84"
                },
            new Customer
            {
                Id = Guid.Parse("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                Phone = "03030303",
                Address = "hcm",
                Birthday = DateTime.ParseExact("04/03/2010", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                ApplicationUserId = "2198E4CD-3305-49C5-B78A-0B54DD76898F"
            }
            );
        }
    }

}
