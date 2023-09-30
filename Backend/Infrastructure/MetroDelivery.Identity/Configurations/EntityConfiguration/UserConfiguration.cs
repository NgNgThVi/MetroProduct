using MetroDelivery.Domain.Entities;
using MetroDelivery.Domain.IdentityModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroDelivery.Identity.Configurations.EntityConfiguration
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
                    Role = "1",
                    /*ApplicationUserId = "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84"*/
                },
            new User
            {
                Id = Guid.Parse("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                UserName = "Manager",
                Password = "MANAGER",
                Email = "Manager@gmail.com",
                Phone = "03030303",
                Address = "hcm",
                Role = "2",
                /*ApplicationUserId = "2198E4CD-3305-49C5-B78A-0B54DD76898F"*/
            }
            );
        }
    }

    /*public class TripConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasData(
                new Trip
                {
                    Id = Guid.Parse("098ab7c2-6db5-4294-8531-7cfe3bc9f249"),
                    TripName = "Beach Vacation",
                    TripStartTime = DateTime.Parse("6/1/2023 12:00 PM"),
                    TripEndTime = DateTime.Parse("6/5/2023 2:00 PM"),

                },
            new Trip
            {
                Id = Guid.Parse("823ad122-7b51-4dab-9d37-b0f238d4a2ff"),
                TripName = "Camping Trip",
                TripStartTime = DateTime.Parse("7/15/2023 8:00 AM"),
                TripEndTime = DateTime.Parse("7/17/2023 12:00 PM"),

            },
            new Trip
            {
                Id = Guid.Parse("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00"),
                TripName = "Road Trip",
                TripStartTime = DateTime.Parse("5/20/2023 9:00 AM"),
                TripEndTime = DateTime.Parse("5/25/2023 8:00 PM"),

            },
            new Trip
            {
                Id = Guid.Parse("02859382-d88c-4e69-8c47-b8e0456677d5"),
                TripName = "Cruise Vacation",
                TripStartTime = DateTime.Parse("9/10/2023 3:00 PM"),
                TripEndTime = DateTime.Parse("9/15/2023 1:00 PM"),

            },
            new Trip
            {
                Id = Guid.Parse("27421cac-1da7-4df8-9928-7fb636ca42aa"),
                TripName = "Hiking Adventure",
                TripStartTime = DateTime.Parse("11/12/2023 9:00 AM"),
                TripEndTime = DateTime.Parse("11/14/2023 5:00 PM"),

            },
            new Trip
            {
                Id = Guid.Parse("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"),
                TripName = "Ski Getaway",
                TripStartTime = DateTime.Parse("12/20/2023 8:00 AM"),
                TripEndTime = DateTime.Parse("12/23/2023 2:00 PM"),

            },
            new Trip
            {
                Id = Guid.Parse("9b4d232c-0fda-4ec0-beed-ecd649ee9c52"),
                TripName = "Tropical Vacation",
                TripStartTime = DateTime.Parse("8/13/2023 11:00 AM"),
                TripEndTime = DateTime.Parse("8/18/2023 9:00 PM"),

            },
            new Trip
            {
                Id = Guid.Parse("bf736039-33e9-466f-ac4e-78c89f3317e6"),
                TripName = "Amusement Park Fun",
                TripStartTime = DateTime.Parse("7/4/2023 9:00 AM"),
                TripEndTime = DateTime.Parse("7/6/2023 11:00 PM"),

            },
            new Trip
            {
                Id = Guid.Parse("8a2ba7d5-7019-49c6-a47d-ab0a072e7932"),
                TripName = "African Safari",
                TripStartTime = DateTime.Parse("9/28/2023 7:00 AM"),
                TripEndTime = DateTime.Parse("10/3/2023 5:00 PM"),

            },
            new Trip
            {
                Id = Guid.Parse("d9852f0d-e836-4a6e-94f4-d229b297933d"),
                TripName = "Botanical Gardens Tour",
                TripStartTime = DateTime.Parse("5/6/2023 1:00 PM"),
                TripEndTime = DateTime.Parse("5/8/2023 3:00 PM"),

            }
            );
        }
    }

    public class RouteConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.HasData(
                new Route
                {
                    Id = Guid.Parse("EA675490-EECD-4308-BB71-61B72A9C979F"),
                    FromLocation = "Quận 1, Tp.Hcm",
                    ToLocation = "Quận 9, Tp.Hcm",
                },
                new Route
                {
                    Id = Guid.Parse("001A254C-02D4-40E7-A01F-95F393FB41EF"),
                    FromLocation = "Quận 1, Tp.Hcm",
                    ToLocation = "Suối Tiên, Đồng Nai",
                },
                new Route
                {
                    Id = Guid.Parse("A437B242-55FC-4146-A2B9-8C952B107E3A"),
                    FromLocation = "Quận 1, Tp.Hcm",
                    ToLocation = "Quận Thủ Đức, Tp.Hcm",
                },
                new Route
                {
                    Id = Guid.Parse("CCC66514-0597-4D43-AAFF-0C5D8EE59FFA"),
                    FromLocation = "Quận 1, Tp.Hcm",
                    ToLocation = "Quận Bình Thạnh, Tp.Hcm",
                },
                new Route
                {
                    Id = Guid.Parse("B9F8F712-92EE-4611-AD55-000A8E1B84C6"),
                    FromLocation = "Quận 1, Tp.Hcm",
                    ToLocation = "Bến xe Miền Đông",
                });
        }
    }

    public class StationConfiguration : IEntityTypeConfiguration<Station>
    {
        public void Configure(EntityTypeBuilder<Station> builder)
        {
            builder.HasData(
                new Station
                {
                    Id = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4"),
                    StationName = "Ga Metro Bến Thành",
                    StoreID = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8")
                },
                new Station
                {
                    Id = Guid.Parse("573bbaf0-ee3e-4a09-b3f5-6a7d3b5c2e0a"),
                    StationName = "Ga Metro Vincom Bình Thạnh",
                    StoreID = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8")
                },
                new Station
                {
                    Id = Guid.Parse("faa423e3-8a45-4a18-b9fc-9c05b804e6c1"),
                    StationName = "Ga Metro Thủ Đức",
                    StoreID = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8")
                },
                new Station
                {
                    Id = Guid.Parse("e1f69d7c-0df1-41fb-a4ac-7e34bcb1f28e"),
                    StationName = "Ga Metro Khu Công Nghệ Cao",
                    StoreID = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8")
                },
                new Station
                {
                    Id = Guid.Parse("b84dbb16-7c27-44a2-b39d-5a4f8ab8706d"),
                    StationName = "Ga Metro Suối Tiên",
                    StoreID = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8")
                },
                new Station
                {
                    Id = Guid.Parse("c9e5e4a8-1c82-4d27-8e64-6176d6ac8dcb"),
                    StationName = "Ga Metro Bến xe Miền Đông",
                    StoreID = Guid.Parse("AA2610A8-DE94-42B7-B12B-1CF8710E05D8")
                });
        }
    }


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
                    Id = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4"),
                    RouteID = Guid.Parse("EA675490-EECD-4308-BB71-61B72A9C979F"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4")
                }
                ,
                new Route_Station
                {
                    // bến thành -> quận thủ đức, tại ga quận 1
                    Id = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4"),
                    RouteID = Guid.Parse("A437B242-55FC-4146-A2B9-8C952B107E3A"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4")
                },
                new Route_Station
                {
                    // bến thành -> quận Ga Metro Suối Tiên, tại ga quận 1
                    Id = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4"),
                    RouteID = Guid.Parse("001A254C-02D4-40E7-A01F-95F393FB41EF"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4")
                },
                new Route_Station
                {
                    // bến thành -> quận Ga Metro Bến xe Miền Đông tại ga quận 1
                    Id = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4"),
                    RouteID = Guid.Parse("B9F8F712-92EE-4611-AD55-000A8E1B84C6"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4")
                },
                new Route_Station
                {
                    // bến thành -> quận bình thạnh, tại ga quận bình thạnh
                    Id = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4"),
                    RouteID = Guid.Parse("CCC66514-0597-4D43-AAFF-0C5D8EE59FFA"),
                    StationID = Guid.Parse("50CB67F8-421E-4AEC-85ED-7114E763D6C4")
                }
                );
        }
    }*/
}
