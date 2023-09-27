using MetroDelivery.Domain.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetroDelivery.Identity.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "2198E4CD-3305-49C5-B78A-0B54DD76898F",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    FirstName = "Nhan",
                    LastName = "Admin",
                    UserName = "admin@gmail.com",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssw0rd1"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "E6DE8827-B7C2-46E9-9227-66E6ECE676A8",
                    Email = "enduser@gmail.com",
                    NormalizedEmail = "ENDUSER@GMAIL.COM",
                    FirstName = "Vi",
                    LastName = "EndUser",
                    UserName = "enduser@gmail.com",
                    NormalizedUserName = "ENDUSER@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssw0rd1"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84",
                    Email = "staff@gmail.com",
                    NormalizedEmail = "STAFF@GMAIL.COM",
                    FirstName = "Vi",
                    LastName = "Staff",
                    UserName = "staff@gmail.com",
                    NormalizedUserName = "STAFF@GMAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssw0rd1"),
                    EmailConfirmed = true
                });
        }
    }
}
