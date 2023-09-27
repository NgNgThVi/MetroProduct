﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "CF531396-C1CD-427B-9D17-0383B7675394",
                    Name = "EndUser",
                    NormalizedName = "EndUser",
                },
                new IdentityRole
                {
                    Id = "AF5EB4AC-219A-4BC1-99FE-8C23876536EA",
                    Name = "Administrator",
                    NormalizedName = "Administrator",
                },
                new IdentityRole
                {
                    Id = "647D9649-F5A2-4F24-808F-6FC326EC2AA3",
                    Name = "Staff",
                    NormalizedName = "Staff",
                });
        }
    }
}
