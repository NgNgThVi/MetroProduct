﻿/*using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetroDelivery.Identity.Configurations.EntityConfiguration
{
    public class Route_StationConfiguration : IEntityTypeConfiguration<Route_Station>
    {
        public void Configure(EntityTypeBuilder<Route_Station> builder)
        {
            builder.HasData(
                new Route_Station
                {
                    // bến thành -> quận 9, tại ga quận 1
                    Id = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4"),
                    RouteID = Guid.Parse("EA675490-EECD-4308-BB71-61B72A9C979F"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4")
                },
                new Route_Station
                {
                    // bến thành -> quận bình thạnh, tại ga quận 1
                    Id = Guid.Parse("1B22BDB7-1688-42FA-8FAE-4AF92E32DF7F"),
                    RouteID = Guid.Parse("CCC66514-0597-4D43-AAFF-0C5D8EE59FFA"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4")
                }
                ,
                new Route_Station
                {
                    // bến thành -> quận thủ đức, tại ga quận 1
                    Id = Guid.Parse("2FF9D0D9-474C-4466-B9A8-707B730F415C"),
                    RouteID = Guid.Parse("A437B242-55FC-4146-A2B9-8C952B107E3A"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4")
                },
                new Route_Station
                {
                    // bến thành -> quận Ga Metro Suối Tiên, tại ga quận 1
                    Id = Guid.Parse("AB2099B4-E511-42FF-9E6A-EE71BDDCD482"),
                    RouteID = Guid.Parse("001A254C-02D4-40E7-A01F-95F393FB41EF"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4")
                },
                new Route_Station
                {
                    // bến thành -> quận Ga Metro Bến xe Miền Đông tại ga quận 1
                    Id = Guid.Parse("6A82DB5A-23CF-4764-B7D1-CCABCE5CC317"),
                    RouteID = Guid.Parse("B9F8F712-92EE-4611-AD55-000A8E1B84C6"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4")
                },
                new Route_Station
                {
                    // bến thành -> quận bình thạnh, tại ga quận bình thạnh
                    Id = Guid.Parse("5004477E-1446-467D-8157-972185D64290"),
                    RouteID = Guid.Parse("CCC66514-0597-4D43-AAFF-0C5D8EE59FFA"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C5")
                }
                );
        }
    }

}
*/