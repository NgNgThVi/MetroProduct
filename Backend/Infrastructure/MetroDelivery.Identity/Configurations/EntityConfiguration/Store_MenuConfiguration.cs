using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetroDelivery.Identity.Configurations.EntityConfiguration
{
    public class Store_MenuConfiguration : IEntityTypeConfiguration<Store_Menu>
    {
        public void Configure(EntityTypeBuilder<Store_Menu> builder)
        {
            builder.HasData(
                new Store_Menu
                {
                    StoreId = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8"),
                    MenuId = Guid.Parse("E7A15238-5DB0-49BD-94E6-D5F8B77AE6CE")
                },
                new Store_Menu
                {
                    StoreId = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8"),
                    MenuId = Guid.Parse("5263453C-DAE9-45E4-8204-5430A7256CDE")
                },
                new Store_Menu
                {
                    StoreId = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8"),
                    MenuId = Guid.Parse("9B08173A-E338-45EF-B479-6B0E95F2B055")
                },
                new Store_Menu
                {
                    StoreId = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8"),
                    MenuId = Guid.Parse("47A91DD5-F999-461A-8F80-935D169CA0C3")
                },
                new Store_Menu
                {
                    StoreId = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8"),
                    MenuId = Guid.Parse("D6184EA2-9833-499F-9A56-8138C3B60C78")
                },
                new Store_Menu
                {
                    StoreId = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8"),
                    MenuId = Guid.Parse("BBC7D071-5F5B-40BE-B25E-3AA07A6C3E7C")
                },
                new Store_Menu
                {
                    StoreId = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8"),
                    MenuId = Guid.Parse("4CBF8910-C204-46FE-91D4-E8E4C94FF695")
                }
            );
        }
    }
}
