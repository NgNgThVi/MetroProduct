using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetroDelivery.Identity.Configurations.EntityConfiguration
{
    public class MenuProductConfiguration : IEntityTypeConfiguration<Menu_Product>
    {
        public void Configure(EntityTypeBuilder<Menu_Product> builder)
        {
            builder.HasData(
                new Menu_Product
                {
                    Id = Guid.Parse("4F42718B-FDCC-457F-975F-6F90A7149CB3"),
                    MenuID = Guid.Parse("56CBA664-CB0A-49C8-A6D6-CBE6A5455EC2"),
                    ProductID = Guid.Parse("45CDF6ED-820F-40DF-8E4B-BAAAD897D8DF")
                },
                new Menu_Product
                {
                    Id = Guid.Parse("FAD17A59-5593-4F80-ABC8-852A7670EA03"),
                    MenuID = Guid.Parse("56CBA664-CB0A-49C8-A6D6-CBE6A5455EC2"),
                    ProductID = Guid.Parse("DC38C67E-7B6B-45AF-95A9-FC8B0097C2C8")
                }
                );
        }
    }
}
