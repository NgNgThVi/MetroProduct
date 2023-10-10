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
                },
                new Customer
                {   //anh da đen
                    Id = Guid.Parse("0512A248-0054-4616-ADE5-AE412F4F07BD"),
                    Phone = "0961868641",
                    Address = "Cần Thơ",
                    Birthday = DateTime.ParseExact("04/05/2002", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ApplicationUserId = "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9"
                },
                new Customer
                {   // vĩ bê đê
                    Id = Guid.Parse("ECF95BF5-D766-4B6E-94A7-D33EA29C0618"),
                    Phone = "0903182861",
                    Address = "Đắk Lắk",
                    Birthday = DateTime.ParseExact("14/08/1899", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ApplicationUserId = "1F11BA64-2870-43F7-BB03-867112867F25"
                },
                new Customer
                {   // thành Nhân
                    Id = Guid.Parse("01D31C40-14C9-444C-A2FE-F58EA0FBC08A"),
                    Phone = "0914009910",
                    Address = "Gia Lai",
                    Birthday = DateTime.ParseExact("26/02/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    ApplicationUserId = "2E089AF6-3437-4DD6-9956-BB792E783AFB"
                }
            );
        }
    }

}
