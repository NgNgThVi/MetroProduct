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
                    Id = Guid.Parse("E7A15238-5DB0-49BD-94E6-D5F8B77AE6CE"),
                    StartTimeService = TimeSpan.Parse("06:00"),
                    EndTimeService = TimeSpan.Parse("13:00"),
                    ApplyDate = "Thursday",
                    Priority = true
                },
                new Menu
                {
                    Id = Guid.Parse("5263453C-DAE9-45E4-8204-5430A7256CDE"),
                    StartTimeService = TimeSpan.Parse("13:00"),
                    EndTimeService = TimeSpan.Parse("22:00"),
                    ApplyDate = "Thursday",
                    Priority = true
                },
                new Menu
                {
                    Id = Guid.Parse("D3FD2009-C658-4498-BF59-26936918A0C8"),
                    StartTimeService = TimeSpan.Parse("13:00"),
                    EndTimeService = TimeSpan.Parse("22:00"),
                    ApplyDate = "Thursday",
                    Priority = false
                }
            );
        }
    }
}
