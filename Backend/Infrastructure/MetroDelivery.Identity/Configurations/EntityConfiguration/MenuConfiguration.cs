using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetroDelivery.Identity.Configurations.EntityConfiguration
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasData(
                new Menu
                {
                    Id = Guid.Parse("56CBA664-CB0A-49C8-A6D6-CBE6A5455EC2"),
                    StoreID = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8"),
                    StartTimeService = TimeSpan.Parse("06:00"),
                    EndTimeService = TimeSpan.Parse("10:00"),
                    IsDelete = false,
                },
                new Menu
                {
                    Id = Guid.Parse("72CB9180-9ABA-4B44-ADE4-7A3586391F8D"),
                    StoreID = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8"),
                    StartTimeService = TimeSpan.Parse("10:00"),
                    EndTimeService = TimeSpan.Parse("15:00"),
                    IsDelete = false
                },
                new Menu
                {
                    Id = Guid.Parse("5FCCA20E-90D0-49B4-A933-56D044C4F80B"),
                    StoreID = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8"),
                    StartTimeService = TimeSpan.Parse("15:00"),
                    EndTimeService = TimeSpan.Parse("23:00"),
                    IsDelete = false
                },
                new Menu
                {
                    Id = Guid.Parse("9310E385-5E67-45BF-8AF2-58B7D2C7593D"),
                    StoreID = Guid.Parse("D3599DF7-877E-41C7-832D-14850E5C88BD"),
                    StartTimeService = TimeSpan.Parse("06:00"),
                    EndTimeService = TimeSpan.Parse("10:00"),
                    IsDelete = false,
                },
                new Menu
                {
                    Id = Guid.Parse("298DE718-8200-42F4-AB92-9B43C97C744A"),
                    StoreID = Guid.Parse("D3599DF7-877E-41C7-832D-14850E5C88BD"),
                    StartTimeService = TimeSpan.Parse("10:00"),
                    EndTimeService = TimeSpan.Parse("15:00"),
                    IsDelete = false
                },
                new Menu
                {
                    Id = Guid.Parse("7E2F6320-8B19-4561-B3D2-5F672E01B594"),
                    StoreID = Guid.Parse("D3599DF7-877E-41C7-832D-14850E5C88BD"),
                    StartTimeService = TimeSpan.Parse("15:00"),
                    EndTimeService = TimeSpan.Parse("23:00"),
                    IsDelete = false
                }
                );
        }
    }
}
