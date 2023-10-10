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
                    EndTimeService = TimeSpan.Parse("08:00")
                },
                new Menu
                {
                    Id = Guid.Parse("5263453C-DAE9-45E4-8204-5430A7256CDE"),
                    StartTimeService = TimeSpan.Parse("08:00"),
                    EndTimeService = TimeSpan.Parse("11:00")
                },
                new Menu
                {
                    Id = Guid.Parse("9B08173A-E338-45EF-B479-6B0E95F2B055"),
                    StartTimeService = TimeSpan.Parse("11:00"),
                    EndTimeService = TimeSpan.Parse("13:00")
                },
                new Menu
                {
                    Id = Guid.Parse("47A91DD5-F999-461A-8F80-935D169CA0C3"),
                    StartTimeService = TimeSpan.Parse("13:00"),
                    EndTimeService = TimeSpan.Parse("17:00")
                },
                new Menu
                {
                    Id = Guid.Parse("D6184EA2-9833-499F-9A56-8138C3B60C78"),
                    StartTimeService = TimeSpan.Parse("17:00"),
                    EndTimeService = TimeSpan.Parse("20:00")
                },
                new Menu
                {
                    Id = Guid.Parse("BBC7D071-5F5B-40BE-B25E-3AA07A6C3E7C"),
                    StartTimeService = TimeSpan.Parse("20:00"),
                    EndTimeService = TimeSpan.Parse("00:00")
                },
                new Menu
                {
                    Id = Guid.Parse("4CBF8910-C204-46FE-91D4-E8E4C94FF695"),
                    StartTimeService = TimeSpan.Parse("1:00"),
                    EndTimeService = TimeSpan.Parse("5:00")
                }
            );
        }
    }
}
