using MetroDelivery.Domain.Entities;
using MetroDelivery.Domain.IdentityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User
                {
                    Id = Guid.Parse("F9589C1A-3CBC-4215-BB84-B8FA7D719440"),
                    UserName = "Staff",
                    Password = "MANAGER",
                    Email = "Staff@gmail.com",
                    Phone = "03030303",
                    Address = "da nang",
                    Role = "1",
                    ApplicationUserId = "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84"
                },
            new User
            {
                Id = Guid.Parse("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                UserName = "Manager",
                Password = "MANAGER",
                Email = "Manager@gmail.com",
                Phone = "03030303",
                Address = "hcm",
                Role = "2",
                ApplicationUserId = "2198E4CD-3305-49C5-B78A-0B54DD76898F"
            }
            );
        }
    }
}
