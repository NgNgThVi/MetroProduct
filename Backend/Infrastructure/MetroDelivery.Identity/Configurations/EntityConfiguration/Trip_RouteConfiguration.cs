using MetroDelivery.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MetroDelivery.Identity.Configurations.EntityConfiguration
{
    public class Trip_RouteConfiguration : IEntityTypeConfiguration<Trip_Route>
    {
        public void Configure(EntityTypeBuilder<Trip_Route> builder)
        {
            builder.HasData(
                new Trip_Route
                {
                    TripID = Guid.Parse("823ad122-7b51-4dab-9d37-b0f238d4a2ff"),
                    RouteID = Guid.Parse("001A254C-02D4-40E7-A01F-95F393FB41EF")
                },
                new Trip_Route
                {
                    TripID = Guid.Parse("02859382-d88c-4e69-8c47-b8e0456677d5"),
                    RouteID = Guid.Parse("A437B242-55FC-4146-A2B9-8C952B107E3A")
                },
                new Trip_Route
                {
                    TripID = Guid.Parse("27421cac-1da7-4df8-9928-7fb636ca42aa"),
                    RouteID = Guid.Parse("CCC66514-0597-4D43-AAFF-0C5D8EE59FFA")
                },
                new Trip_Route
                {
                    TripID = Guid.Parse("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"),
                    RouteID = Guid.Parse("B9F8F712-92EE-4611-AD55-000A8E1B84C6")
                }
            );
        }
    }

}
