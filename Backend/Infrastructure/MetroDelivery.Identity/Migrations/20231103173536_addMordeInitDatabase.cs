using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetroDelivery.Identity.Migrations
{
    public partial class addMordeInitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("02b2b1e4-c69b-446e-b947-fb4f97fced22"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("0799d3bf-fce4-4beb-9d7c-a8b75d0da8d0"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("097fae11-cfae-42c2-9d24-60a0a99a79ae"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("0d7e43c8-e867-482c-92d5-8e61512375e8"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("1b07514e-0bb5-4419-a9b8-d813fa7defcc"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("1f53acc2-311d-4520-bcc6-10ef554f815e"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("27efc3db-cc5e-4117-82a6-700e62484df1"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("57806c63-11d9-47aa-8121-19dcb0273bfd"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("5eb7e743-a73e-45d8-976b-d1bf8507243d"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("6e3aedc5-7ce4-4164-ac24-913eab57cc4b"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("6f61694e-dba2-496c-a43b-324b7bf41068"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("88e77c64-49cf-4317-babf-7d9e18bbb74d"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("92a60078-d66f-45d8-b0dd-479152dc256d"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("977329f2-73c8-4414-9152-450adae3288f"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("97fcbf0c-c5b4-41fd-8259-1a257ad6a4dc"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("afd24425-af86-4f36-be29-94a74fb40ea1"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("c8b1499f-5fdc-4b94-80e9-8b24caa9769a"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("cd6aba01-b0a3-496c-88bd-bc1b213ec862"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("dd380cb7-ab68-42fc-af19-8832bce4777b"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("0220c6e4-0522-47e7-9917-122cdc9d0e34"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("09bfd884-fdf4-4eab-939b-010e473f335c"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("13a2bbe9-aaab-4e33-8b89-8cf21a35ec53"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("3af56b71-9e32-4f78-9f0e-47de3e884b6b"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("6d045315-1088-4c56-a547-6abf6eff062e"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("81c4b612-80aa-48bb-b1cb-18d7857df73e"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("8b7fb6c6-7736-4775-b6f0-a589289ebdfc"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("8be71fea-bbac-498e-b4ce-988596f7cd3c"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("93f6f044-e9bd-43ce-8314-098a8bab5363"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("a8aa259f-b090-4a13-b88e-c1bd0c436ca3"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("babb442a-f5c0-4cad-9411-1165227b626f"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("bf196c7e-edc1-453b-a129-e8c8bd230614"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("d5caf86b-0ac8-412b-b009-75b9b67a0ba3"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("3116cb26-04b1-4708-8851-79a888d09a9d"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("3b0e4d73-e3e0-47fd-90e4-d84a40a9737e"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("8b120e2f-d765-4c5b-a984-f406669b0e9e"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("96d58e01-6b15-4649-b3e5-492d57a05456"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("98163365-db2b-42e1-8aca-0593bddfc45f"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("da3d977e-d51d-4f41-a6bf-fbc05ec62c02"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("f45764e4-1dc4-4f23-acc9-ae0db407c658"));

            migrationBuilder.CreateTable(
                name: "PaymentHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Success = table.Column<bool>(type: "bit", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VnPayResponseCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentHistory", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04D67210-257D-4DD5-BAFC-13DDE8CA0DFE",
                column: "ConcurrencyStamp",
                value: "3b8d8c34-3ea3-48b8-aafc-05c3e42bd651");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "647D9649-F5A2-4F24-808F-6FC326EC2AA3",
                column: "ConcurrencyStamp",
                value: "40e85d71-b33a-4b6a-a13a-bba461a27ffa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AF5EB4AC-219A-4BC1-99FE-8C23876536EA",
                column: "ConcurrencyStamp",
                value: "d4d80e89-bcc6-42d5-a212-39ffe5fe8c3d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "CF531396-C1CD-427B-9D17-0383B7675394",
                column: "ConcurrencyStamp",
                value: "61c1a510-4b09-4399-90fe-b63400bc3382");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1F11BA64-2870-43F7-BB03-867112867F25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "660c9581-1245-452d-bf94-a55f053eb017", "AQAAAAEAACcQAAAAENi5H9qdsCp44Mk/4vIA1zsckkmFg+ac5SaTXK9+gcPpB/V+RsHyziHLWuhdRpVzVw==", "ccb0e7bc-d64b-4253-9540-1ace106951e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2198E4CD-3305-49C5-B78A-0B54DD76898F",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0381e23c-26ac-415d-aa01-f85a07d65e22", "AQAAAAEAACcQAAAAEGsIe7A6xUdV97mGiv6YXpekrjsTcKYZ7+hUND6Ei6rwfXTswPKB0tQjL68wUQzywg==", "820a3461-1e1a-4ede-a6eb-bed7c99b4bf8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StoreId" },
                values: new object[] { "40500f5a-201f-454a-8717-3e67f7caf944", "AQAAAAEAACcQAAAAEJ8+E1eIbu8Tr9biD58lOmzypn/Y6sD2vysJpW8RVbSbJej1D11QMKYrZebTmKwOqQ==", "fd6aea9f-1dce-4cf0-8e50-eb2a904fad0e", new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2E089AF6-3437-4DD6-9956-BB792E783AFB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4843377-1750-46cc-b30b-71bf0fbf6e8d", "AQAAAAEAACcQAAAAEGyqxrejc42LFhqAVk+59+dnpOdwf92QkLB3mn11vxM4WOeodjuwS9nL1JXFmYguKQ==", "9e59731e-d189-41d0-a070-e05370a99f75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8E48858E-7089-4512-BB79-75AEDC2003D6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a96c9446-5d55-4b0a-91ff-29f2211d55ac", "AQAAAAEAACcQAAAAECkiO8HJowYe7Em/RJwsb/gearSG4sSVzX3KfYPjsMybNcrFyzTPWNmwi/jl6BJF/A==", "77b3589d-dc9a-42e5-923e-53fdbbed9de2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B76C9C1E-7F7F-4175-93B3-39B1285F0E71",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f0e727c-6a62-4209-ac24-84e6dd5ddccf", "AQAAAAEAACcQAAAAEKFqNZaWMqd9PnY7+tv7kdGGgU4x2qq1M3L4e4CwfMxr9kF1TqBWcyHWIr7ChayIxw==", "c8234bca-fc11-47f4-ae0f-5f59ecc7e6ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1943e90e-f255-431e-8357-6086fa33cfa7", "AQAAAAEAACcQAAAAEBNkGU+01qhtaKVtxge80AFHotkrE0lhYpbKNWNezpNkmfcWUSV5S1ALHrViEZ830w==", "acc8f6c1-757a-4f2f-aecc-83999ba8208b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DB903C85-4C75-428B-A7B0-9B56130F4813",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d8a32ced-f2cd-4b81-8dcd-7343f12dc8c9", "AQAAAAEAACcQAAAAEJZ8bcp5C4UR6agNlNaLbYEjHJmqHErv4fI1fsBTDHCAWcBqv6QH8ZX0slCfKvefVQ==", "044b0297-9c32-49a3-809d-7d3dbda21038" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E6DE8827-B7C2-46E9-9227-66E6ECE676A8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f94c1bb2-5f3e-4ca3-9362-68312c1abaa0", "AQAAAAEAACcQAAAAELHLrEOLhnnedhI7mtZTgarRAmFh8J86O2Lmz7VEOz++OViwko1v9bBQsBdLY3nClQ==", "3f504190-b060-4c9a-bcc0-79f796d92901" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9404));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39696f0c-2c8a-480f-b917-141b7da708e4"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4078ef19-ba53-481d-9c5a-1c37dfe0e0dc"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8908ea98-b421-420b-9634-03ed356bb921"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9407));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9388));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("5263453c-dae9-45e4-8204-5430a7256cde"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.InsertData(
                table: "Menu_Product",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuID", "PriceOfProductBelongToTimeService", "ProductID" },
                values: new object[,]
                {
                    { new Guid("0138245f-80d7-45ef-95db-a708b3071ce1"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9577), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("186a4e80-d8d1-4bb8-a546-28fa3ea6bc85"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9589), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("2976a0b4-d247-4b3f-b90d-4fe019f01b2c"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9555), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("2f20bcf7-34af-4a9a-80c2-3d859ac7c705"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9560), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("313266b2-e9de-4b67-94c5-64cde7cbcf59"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9596), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") },
                    { new Guid("37c4f8de-8d19-4e9e-8fcf-9704ab236dd5"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9582), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") },
                    { new Guid("38fad766-2e77-4950-957d-087717d077cb"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9603), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") },
                    { new Guid("408ef845-ff6e-4504-b5c1-7e1537aaf6c9"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9572), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") },
                    { new Guid("5a379335-f17f-4ec2-8285-2e0011a2835b"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9605), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") },
                    { new Guid("80923d73-182a-4e14-801e-4ea474dec7e2"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9586), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") },
                    { new Guid("8cae4281-df88-4085-92e8-ce570a97c9e7"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9579), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") },
                    { new Guid("8e16b059-ed23-4c1f-b2a9-e04c56084d47"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9563), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") },
                    { new Guid("9b38a37b-52a5-418f-8795-7e49d0b0a0f8"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9584), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("ad52a5ee-ce2e-4238-b4f7-427b2a4c0359"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9566), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") },
                    { new Guid("ad6b6fce-70c0-4a26-8118-8cb254c2c6e2"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9600), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("b90b51f5-fa0c-42d7-bc47-6aeeb03b1e1f"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9598), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("c7e9e897-b1b6-45ae-85c4-30ffa4fc8267"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9593), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("cbb0ccc0-ac64-4323-a767-4295d82ed6f6"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9608), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") },
                    { new Guid("d8dc33dd-2755-493d-a4ac-cc776eba0134"), null, new DateTime(2023, 11, 4, 0, 35, 34, 84, DateTimeKind.Local).AddTicks(9575), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 35000.0, new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38") }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(188));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("05a027a2-01b0-40d2-91f7-2a33fc29753f"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("a8b7026d-5def-44ef-9666-6b78682a77cc"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("f6d015a9-d5bb-40e8-a287-623f0af19fc9"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("36672051-5437-4d2c-a42e-c71a9b67a2b1"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("47bd4dd4-3fb4-463e-b9b9-5ebfb7e1f960"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("7db43916-e061-42cb-b0a7-9734423d00cd"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0c308b93-b26a-4224-9d63-28294711aa15"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("45da4260-ba13-489b-995a-1f6adb13ab75"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4ecd72e3-f43d-490f-8b46-8e92ea29f85c"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55265d3b-fa02-4e09-84db-d4e8c8a9a9b5"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6d60bf44-b775-4d87-bb47-aace85d49ac4"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7d661a30-e180-498c-9a77-cb6112a7cb22"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7da34092-5747-42b7-b059-4a5aad57e740"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d4fe048d-ff12-4715-93e7-3250f49c15c8"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f31c789c-4a46-45c7-9009-d36681d788c5"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ffb05663-954d-4af3-8a41-91af39446f81"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1023));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("15fefdbf-b178-49ba-aa7c-7b3e2dd575bc"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("1b22bdb7-1688-42fa-8fae-4af92e32df7f"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("2ff9d0d9-474c-4466-b9a8-707b730f415c"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("5004477e-1446-467d-8157-972185d64290"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(895));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6a82db5a-23cf-4764-b7d1-ccabce5cc317"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6e841857-2712-4da3-a15f-aed820adef5a"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("8de6ed00-50c8-434e-95ce-cc921426e697"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("ab2099b4-e511-42ff-9e6a-ee71bddcd482"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1510));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1518));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1524));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.InsertData(
                table: "Station_Trip",
                columns: new[] { "Id", "Arrived", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StationID", "TripID" },
                values: new object[,]
                {
                    { new Guid("19cfe72e-6e13-4435-9faa-08a24548d305"), new DateTime(2023, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1230), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("02859382-d88c-4e69-8c47-b8e0456677d5") },
                    { new Guid("2df45c34-36e4-4dc7-9a68-4f6912261796"), new DateTime(2023, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1303), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("31c4f017-3295-4193-82d4-a86503f33948"), new DateTime(2023, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1248), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7") },
                    { new Guid("3e49df58-a575-4bfe-8e01-05b9f63a6e85"), new DateTime(2023, 10, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1349), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("6c1ce6d7-73ef-47ea-8ae2-4152ebb257cf"), new DateTime(2023, 10, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1363), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("74658919-7a4b-4263-8065-c0096c4b8bef"), new DateTime(2023, 6, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1321), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("88a8d2d5-3954-4217-9e6b-d5c652dfb963"), new DateTime(2023, 11, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1241), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") },
                    { new Guid("9e6206cf-f64e-4e4d-8532-bc69446b31c3"), new DateTime(2023, 10, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1356), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("a28492d5-71e6-4312-be91-4eee21d24802"), new DateTime(2023, 5, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1312), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("a4a433da-c76c-4e09-bd72-c9f2a9083327"), new DateTime(2023, 10, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1335), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("aef68ee8-e4c2-45a7-aa3e-11c93e4dfea3"), new DateTime(2023, 6, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1328), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52") },
                    { new Guid("bb2d31b9-3181-4846-be3e-00c35d824b0b"), new DateTime(2023, 10, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1342), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("c22dcc07-337d-4ae2-aa75-983719aa454e"), new DateTime(2023, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1140), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") }
                });

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.InsertData(
                table: "Store_Menu",
                columns: new[] { "Id", "ApplyDate", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuId", "Priority", "StoreId" },
                values: new object[,]
                {
                    { new Guid("04757619-171a-47d2-87ce-a6bb5138f9d1"), "Thursday", null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1667), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), false, new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4") },
                    { new Guid("431393a0-5070-40e8-978c-11a3badd5382"), "Monday", null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1678), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), false, new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("4348c021-5eb9-407b-9bd3-5fe4cf0d1aa0"), "Monday", null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1675), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), false, new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("6b0ddd1c-93af-48b5-834f-e2a2f8638a4d"), "Monday", null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1672), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), false, new Guid("d3599df7-877e-41c7-832d-14850e5c88bd") },
                    { new Guid("84214331-3049-4169-8264-4ae78ac46a68"), "Monday", null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1680), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), false, new Guid("ef443e4b-886c-4c06-8528-51e9cf623867") },
                    { new Guid("a538e839-40e6-40cf-9024-45eb2a3aa5ca"), "Thursday", null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1664), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), false, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("af7d167c-9c9f-4be1-add8-46dc8703d542"), "Thursday", null, new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(1659), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") }
                });

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("02859382-d88c-4e69-8c47-b8e0456677d5"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("bf736039-33e9-466f-ac4e-78c89f3317e6"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("d9852f0d-e836-4a6e-94f4-d229b297933d"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("0bd9818a-5ef1-45e3-a6fe-0c932f970fe8"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("4e917707-0edb-49da-b6f4-804d2c52821b"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("8efb8acc-2eb9-448d-bfa2-825995f50b59"),
                column: "Created",
                value: new DateTime(2023, 11, 4, 0, 35, 34, 85, DateTimeKind.Local).AddTicks(2866));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentHistory");

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("0138245f-80d7-45ef-95db-a708b3071ce1"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("186a4e80-d8d1-4bb8-a546-28fa3ea6bc85"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("2976a0b4-d247-4b3f-b90d-4fe019f01b2c"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("2f20bcf7-34af-4a9a-80c2-3d859ac7c705"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("313266b2-e9de-4b67-94c5-64cde7cbcf59"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("37c4f8de-8d19-4e9e-8fcf-9704ab236dd5"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("38fad766-2e77-4950-957d-087717d077cb"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("408ef845-ff6e-4504-b5c1-7e1537aaf6c9"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("5a379335-f17f-4ec2-8285-2e0011a2835b"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("80923d73-182a-4e14-801e-4ea474dec7e2"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("8cae4281-df88-4085-92e8-ce570a97c9e7"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("8e16b059-ed23-4c1f-b2a9-e04c56084d47"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("9b38a37b-52a5-418f-8795-7e49d0b0a0f8"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("ad52a5ee-ce2e-4238-b4f7-427b2a4c0359"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("ad6b6fce-70c0-4a26-8118-8cb254c2c6e2"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("b90b51f5-fa0c-42d7-bc47-6aeeb03b1e1f"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("c7e9e897-b1b6-45ae-85c4-30ffa4fc8267"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("cbb0ccc0-ac64-4323-a767-4295d82ed6f6"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("d8dc33dd-2755-493d-a4ac-cc776eba0134"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("19cfe72e-6e13-4435-9faa-08a24548d305"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("2df45c34-36e4-4dc7-9a68-4f6912261796"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("31c4f017-3295-4193-82d4-a86503f33948"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("3e49df58-a575-4bfe-8e01-05b9f63a6e85"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("6c1ce6d7-73ef-47ea-8ae2-4152ebb257cf"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("74658919-7a4b-4263-8065-c0096c4b8bef"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("88a8d2d5-3954-4217-9e6b-d5c652dfb963"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("9e6206cf-f64e-4e4d-8532-bc69446b31c3"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("a28492d5-71e6-4312-be91-4eee21d24802"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("a4a433da-c76c-4e09-bd72-c9f2a9083327"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("aef68ee8-e4c2-45a7-aa3e-11c93e4dfea3"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("bb2d31b9-3181-4846-be3e-00c35d824b0b"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("c22dcc07-337d-4ae2-aa75-983719aa454e"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("04757619-171a-47d2-87ce-a6bb5138f9d1"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("431393a0-5070-40e8-978c-11a3badd5382"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("4348c021-5eb9-407b-9bd3-5fe4cf0d1aa0"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("6b0ddd1c-93af-48b5-834f-e2a2f8638a4d"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("84214331-3049-4169-8264-4ae78ac46a68"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("a538e839-40e6-40cf-9024-45eb2a3aa5ca"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("af7d167c-9c9f-4be1-add8-46dc8703d542"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04D67210-257D-4DD5-BAFC-13DDE8CA0DFE",
                column: "ConcurrencyStamp",
                value: "ff48fa7c-1cb3-4953-a251-73b54b48a2e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "647D9649-F5A2-4F24-808F-6FC326EC2AA3",
                column: "ConcurrencyStamp",
                value: "94e1d93a-0299-4e3d-a228-63355296142d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AF5EB4AC-219A-4BC1-99FE-8C23876536EA",
                column: "ConcurrencyStamp",
                value: "f15e6413-a4f9-4d3d-8622-1eece27508a1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "CF531396-C1CD-427B-9D17-0383B7675394",
                column: "ConcurrencyStamp",
                value: "b9cab34e-26e6-4a21-891d-5866b5d66fe8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1F11BA64-2870-43F7-BB03-867112867F25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e66da48a-c340-4ffa-9763-9f4bac06d4f3", "AQAAAAEAACcQAAAAEB99B4lgKiPUyLNph0WyPsGVaYsUH4dcOuXzObI5c9V+kREgMHhJwTuHQ/GHtMBjDA==", "a7dd3412-ee8c-42cd-81d4-d5d30fe128ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2198E4CD-3305-49C5-B78A-0B54DD76898F",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ee7f1da-de47-4034-b4ad-4d8dff413056", "AQAAAAEAACcQAAAAECS8GnhA+HIq1QGYGqCxaHF0rhXY6A/K2m7Z4PPcekVWWXjfAi8Ak4T16PuUN8rHuQ==", "83dfc247-8d8a-4aa5-8094-15dc4f7065ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StoreId" },
                values: new object[] { "8fc54e04-9e01-4203-abcb-d5f842751fbb", "AQAAAAEAACcQAAAAEAb846INbwHr+VHDeM2iKgIJmKE6kI6St3TfuV+4ksbJCehgvKWudKZcTlTgMZH3xg==", "ca5e6cbc-69fe-4192-abdb-501e92e7e07a", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2E089AF6-3437-4DD6-9956-BB792E783AFB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "654fd1e2-adba-43eb-9a48-3db6bfa9d24d", "AQAAAAEAACcQAAAAELk04N3ka7iFqEPqEfkiONrXn+WBW48flxyw9McV4gwio8JKACcwCPO+VVFxggCXNw==", "c71376fe-f3ba-4663-969a-a56674e09095" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8E48858E-7089-4512-BB79-75AEDC2003D6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b58b8246-b79c-420b-a49c-543b62908a61", "AQAAAAEAACcQAAAAEFLWLj90BHcreaaiz5li3DxtMdMkZG9o5iPhkxRx9v3drH4HV7PrZl9AvXKJxObqrg==", "b76a64cc-467d-4250-a775-5b1f6504926d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "B76C9C1E-7F7F-4175-93B3-39B1285F0E71",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "900fab7f-43de-4653-b111-ab66784bb631", "AQAAAAEAACcQAAAAEK+VPnpi4eOutoriMRAJAn9Ttd/A9HhtcTeAi3ium3weBLVE95NTP2GCNTkt6UWAJw==", "f24b7d3f-cfcd-48b5-8beb-a8921e5cab33" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ce51ac6-aa19-4d07-b72c-7fa998f6917e", "AQAAAAEAACcQAAAAEKBmjTilmURZ0xO3HR1Z+fX8VtfA8C19E/fN8cX9rpMlCKzj9KB0U0U6nJ2Lg2UTzw==", "f8d91972-e949-4b8c-a61d-f9876a177441" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DB903C85-4C75-428B-A7B0-9B56130F4813",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbbe7c93-32f1-45dc-b717-a7f4e5587daa", "AQAAAAEAACcQAAAAEEz4CIDg2J2Lci7mtpixhqJkh1yldh4yWmozf2LtsWSmonDPxVIOfh/zjK8zj31pwA==", "363db6cb-38f1-45f6-8c04-7c6005a93fa0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E6DE8827-B7C2-46E9-9227-66E6ECE676A8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f210786f-d12e-4b9f-9a70-0b63a57bc776", "AQAAAAEAACcQAAAAEELKwmgCLtHYSap8ZKI8j5PmDyamGISX68qxT6OvRqaUxCMBcI9GNXJcPpqBgswoEQ==", "db331123-92ac-4a21-af9a-f9ccb3feec5c" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39696f0c-2c8a-480f-b917-141b7da708e4"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4078ef19-ba53-481d-9c5a-1c37dfe0e0dc"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8908ea98-b421-420b-9634-03ed356bb921"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("5263453c-dae9-45e4-8204-5430a7256cde"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.InsertData(
                table: "Menu_Product",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuID", "PriceOfProductBelongToTimeService", "ProductID" },
                values: new object[,]
                {
                    { new Guid("02b2b1e4-c69b-446e-b947-fb4f97fced22"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4311), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") },
                    { new Guid("0799d3bf-fce4-4beb-9d7c-a8b75d0da8d0"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4471), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") },
                    { new Guid("097fae11-cfae-42c2-9d24-60a0a99a79ae"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4479), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") },
                    { new Guid("0d7e43c8-e867-482c-92d5-8e61512375e8"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4475), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") },
                    { new Guid("1b07514e-0bb5-4419-a9b8-d813fa7defcc"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4347), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") },
                    { new Guid("1f53acc2-311d-4520-bcc6-10ef554f815e"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4343), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("27efc3db-cc5e-4117-82a6-700e62484df1"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4296), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("57806c63-11d9-47aa-8121-19dcb0273bfd"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4327), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 35000.0, new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38") },
                    { new Guid("5eb7e743-a73e-45d8-976b-d1bf8507243d"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4335), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") },
                    { new Guid("6e3aedc5-7ce4-4164-ac24-913eab57cc4b"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4315), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") },
                    { new Guid("6f61694e-dba2-496c-a43b-324b7bf41068"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4319), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") },
                    { new Guid("88e77c64-49cf-4317-babf-7d9e18bbb74d"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4306), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("92a60078-d66f-45d8-b0dd-479152dc256d"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4467), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("977329f2-73c8-4414-9152-450adae3288f"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4339), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") },
                    { new Guid("97fcbf0c-c5b4-41fd-8259-1a257ad6a4dc"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4451), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("afd24425-af86-4f36-be29-94a74fb40ea1"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4446), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("c8b1499f-5fdc-4b94-80e9-8b24caa9769a"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4463), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("cd6aba01-b0a3-496c-88bd-bc1b213ec862"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4331), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("dd380cb7-ab68-42fc-af19-8832bce4777b"), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(4459), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("05a027a2-01b0-40d2-91f7-2a33fc29753f"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5342));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("a8b7026d-5def-44ef-9666-6b78682a77cc"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("f6d015a9-d5bb-40e8-a287-623f0af19fc9"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5328));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("36672051-5437-4d2c-a42e-c71a9b67a2b1"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("47bd4dd4-3fb4-463e-b9b9-5ebfb7e1f960"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5513));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("7db43916-e061-42cb-b0a7-9734423d00cd"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5522));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0c308b93-b26a-4224-9d63-28294711aa15"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5908));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5949));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("45da4260-ba13-489b-995a-1f6adb13ab75"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5946));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4ecd72e3-f43d-490f-8b46-8e92ea29f85c"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55265d3b-fa02-4e09-84db-d4e8c8a9a9b5"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5936));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6d60bf44-b775-4d87-bb47-aace85d49ac4"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5899));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7d661a30-e180-498c-9a77-cb6112a7cb22"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5885));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7da34092-5747-42b7-b059-4a5aad57e740"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5895));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d4fe048d-ff12-4715-93e7-3250f49c15c8"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5952));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f31c789c-4a46-45c7-9009-d36681d788c5"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ffb05663-954d-4af3-8a41-91af39446f81"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7297));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7285));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7290));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("15fefdbf-b178-49ba-aa7c-7b3e2dd575bc"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("1b22bdb7-1688-42fa-8fae-4af92e32df7f"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("2ff9d0d9-474c-4466-b9a8-707b730f415c"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(6306));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("5004477e-1446-467d-8157-972185d64290"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6a82db5a-23cf-4764-b7d1-ccabce5cc317"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(6339));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6e841857-2712-4da3-a15f-aed820adef5a"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("8de6ed00-50c8-434e-95ce-cc921426e697"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("ab2099b4-e511-42ff-9e6a-ee71bddcd482"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7829));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7832));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.InsertData(
                table: "Station_Trip",
                columns: new[] { "Id", "Arrived", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StationID", "TripID" },
                values: new object[,]
                {
                    { new Guid("0220c6e4-0522-47e7-9917-122cdc9d0e34"), new DateTime(2023, 10, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7672), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("09bfd884-fdf4-4eab-939b-010e473f335c"), new DateTime(2023, 11, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7601), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") },
                    { new Guid("13a2bbe9-aaab-4e33-8b89-8cf21a35ec53"), new DateTime(2023, 5, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7622), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("3af56b71-9e32-4f78-9f0e-47de3e884b6b"), new DateTime(2023, 6, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7637), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52") },
                    { new Guid("6d045315-1088-4c56-a547-6abf6eff062e"), new DateTime(2023, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7500), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") },
                    { new Guid("81c4b612-80aa-48bb-b1cb-18d7857df73e"), new DateTime(2023, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7590), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("02859382-d88c-4e69-8c47-b8e0456677d5") },
                    { new Guid("8b7fb6c6-7736-4775-b6f0-a589289ebdfc"), new DateTime(2023, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7608), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7") },
                    { new Guid("8be71fea-bbac-498e-b4ce-988596f7cd3c"), new DateTime(2023, 10, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7644), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("93f6f044-e9bd-43ce-8314-098a8bab5363"), new DateTime(2023, 6, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7628), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("a8aa259f-b090-4a13-b88e-c1bd0c436ca3"), new DateTime(2023, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7615), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("babb442a-f5c0-4cad-9411-1165227b626f"), new DateTime(2023, 10, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7665), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("bf196c7e-edc1-453b-a129-e8c8bd230614"), new DateTime(2023, 10, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7652), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("d5caf86b-0ac8-412b-b009-75b9b67a0ba3"), new DateTime(2023, 10, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7658), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") }
                });

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.InsertData(
                table: "Store_Menu",
                columns: new[] { "Id", "ApplyDate", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuId", "Priority", "StoreId" },
                values: new object[,]
                {
                    { new Guid("3116cb26-04b1-4708-8851-79a888d09a9d"), "Monday", null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8129), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), false, new Guid("ef443e4b-886c-4c06-8528-51e9cf623867") },
                    { new Guid("3b0e4d73-e3e0-47fd-90e4-d84a40a9737e"), "Thursday", null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7966), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), false, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("8b120e2f-d765-4c5b-a984-f406669b0e9e"), "Thursday", null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7970), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), false, new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4") },
                    { new Guid("96d58e01-6b15-4649-b3e5-492d57a05456"), "Monday", null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8126), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), false, new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("98163365-db2b-42e1-8aca-0593bddfc45f"), "Monday", null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8122), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), false, new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("da3d977e-d51d-4f41-a6bf-fbc05ec62c02"), "Thursday", null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7960), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("f45764e4-1dc4-4f23-acc9-ae0db407c658"), "Monday", null, new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(7973), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), false, new Guid("d3599df7-877e-41c7-832d-14850e5c88bd") }
                });

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("02859382-d88c-4e69-8c47-b8e0456677d5"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8503));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("bf736039-33e9-466f-ac4e-78c89f3317e6"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("d9852f0d-e836-4a6e-94f4-d229b297933d"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("0bd9818a-5ef1-45e3-a6fe-0c932f970fe8"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("4e917707-0edb-49da-b6f4-804d2c52821b"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("8efb8acc-2eb9-448d-bfa2-825995f50b59"),
                column: "Created",
                value: new DateTime(2023, 10, 30, 21, 11, 17, 702, DateTimeKind.Local).AddTicks(8747));
        }
    }
}
