using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetroDelivery.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    // staff
                    RoleId = "647D9649-F5A2-4F24-808F-6FC326EC2AA3",
                    UserId = "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84"
                },
                new IdentityUserRole<string>
                {
                    // endUser
                    RoleId = "CF531396-C1CD-427B-9D17-0383B7675394",
                    UserId = "E6DE8827-B7C2-46E9-9227-66E6ECE676A8"
                },
                new IdentityUserRole<string>
                {
                    // admin
                    RoleId = "AF5EB4AC-219A-4BC1-99FE-8C23876536EA",
                    UserId = "2198E4CD-3305-49C5-B78A-0B54DD76898F"
                }

                ,
                new IdentityUserRole<string>
                {
                    // anh da den
                    RoleId = "CF531396-C1CD-427B-9D17-0383B7675394",
                    UserId = "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9"
                },
                new IdentityUserRole<string>
                {
                    // nguyễn thành nhân
                    RoleId = "CF531396-C1CD-427B-9D17-0383B7675394",
                    UserId = "2E089AF6-3437-4DD6-9956-BB792E783AFB"
                },
                new IdentityUserRole<string>
                {
                    // trần ngọc thái vĩ
                    RoleId = "CF531396-C1CD-427B-9D17-0383B7675394",
                    UserId = "1F11BA64-2870-43F7-BB03-867112867F25"
                }
            );
        }
    }
}
