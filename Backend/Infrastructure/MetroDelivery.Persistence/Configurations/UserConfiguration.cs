using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Persistence.Configurations
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
                    Role = "1"
                },
            new User
            {
                Id = Guid.Parse("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                UserName = "Manager",
                Password = "MANAGER",
                Email = "Manager@gmail.com",
                Phone = "03030303",
                Address = "hcm",
                Role = "2"
            }
            );
        }
    }
}
