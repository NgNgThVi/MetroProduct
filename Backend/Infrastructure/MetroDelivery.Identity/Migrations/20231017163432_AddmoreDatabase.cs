using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetroDelivery.Identity.Migrations
{
    public partial class AddmoreDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("20af074e-7279-40d1-83f8-5e45ed63df6f"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("249bb782-77a6-477b-b129-3028b507959b"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("4d5eabe6-0096-4a4e-9e47-ea4cb3efd740"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("61a73ef4-67b2-433c-9dad-66eeea446a10"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("7c999e10-cc4e-487c-ab5d-ff463c86c4b9"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("8c318ef6-e78b-4013-ba71-d525a167f18b"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("b964fc1c-d875-40e4-bd15-36dc7c7d45d3"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("c79f6284-ca72-4bf0-a9cf-74e555e4088f"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("ea8342af-8b9c-4ee5-b549-86d73ab6cdf9"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("f9fd9a11-ef45-4f59-9ebb-fa65fd810562"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("3fcecee0-5e0b-48c8-91ca-ac50f0d25e86"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("72462d68-6ca2-4f22-9f60-85321e3eafed"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("990c6758-35b5-48ad-9152-7f140bf462a9"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("a05b099b-63d1-4e08-9bc6-91e5fcf70d25"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("e1853150-d7e5-44f1-af9b-e7048b792343"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("e63fdb64-4445-4e49-a372-af0abcfec5b2"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("f7c9daba-7c20-406c-a752-04305d97a598"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("4ec5e41a-4481-415d-b9fc-ca1a8627b745"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("7860d205-6e69-456e-ba3b-3bb5dbb8b44e"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("7f1b4fae-81a1-4de5-b1c2-95ad60af4c27"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("885d8f26-64f2-4ca8-990a-1c4d040a7f79"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("9f0ced7a-33a8-444c-b73d-4808372315d8"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("b79065f8-36f0-4a27-a968-20a9aee4b834"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("c8c78bcd-e951-4596-a1a2-53ed033575ec"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("cdfe80e6-7610-476e-a8da-288bacfa47bf"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("d78230d2-a0dc-49d8-b113-810f51be8bd4"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "647D9649-F5A2-4F24-808F-6FC326EC2AA3",
                column: "ConcurrencyStamp",
                value: "98773c31-9961-461c-a0e7-c3344f0a6410");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AF5EB4AC-219A-4BC1-99FE-8C23876536EA",
                column: "ConcurrencyStamp",
                value: "e7110790-9b06-417e-b509-997c6d04a21c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "CF531396-C1CD-427B-9D17-0383B7675394",
                column: "ConcurrencyStamp",
                value: "229d6885-95a9-4acf-a0a6-2873df340983");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1F11BA64-2870-43F7-BB03-867112867F25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3fc8bd2d-786f-44e4-afd6-c00377f15102", "AQAAAAEAACcQAAAAEGzIyKvUqIuH6yLAdheF6UBJdMFcWMTkCIdZarIleGe6a1pwwGQE0qBecqu5d6LHYQ==", "122fe8d5-c2a8-4e7e-afe5-4235eed1456f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2198E4CD-3305-49C5-B78A-0B54DD76898F",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31ec3c92-509f-4294-b5e0-17920f544158", "AQAAAAEAACcQAAAAEAw3Wxioc4AZmaq2XYse/7uwvhAGpULdmLFpLJdFJTtjObuXoiEcVHmjkg1Tnkp/EQ==", "0a5ff3fe-75b0-45d2-90fe-5439c248744a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a7593cce-8e2c-48e6-b622-75bf46e3bb4f", "AQAAAAEAACcQAAAAEP1CvwhswvTMkotWoE1TrSez8WASIIkFSkjPPBw3quzfz6MefvpKWzrHX6Jr7KU9rA==", "08a91e75-d42b-45a3-ae6a-1cdfa87690db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2E089AF6-3437-4DD6-9956-BB792E783AFB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92b00cd1-a79a-458d-bd7e-59ca3a75552a", "AQAAAAEAACcQAAAAEH7npAVqat5yjhpkGPrefyr2MQtnLTJu1mTHcU/UrtbyebXIeeuqNLj7KSOx4WwG4Q==", "73c7bf8d-d745-4a61-983f-ed076f96252d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e791b0a1-75b0-455a-989e-edae027b7140", "AQAAAAEAACcQAAAAEGynGsUMy9lZ20JZrwmfSeOxvMj7KjSNPlHgXq+SiHXN0AXejo3XxiImn8dXCqh6uw==", "a74538d3-2baf-4e18-9366-cb3b19951fda" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E6DE8827-B7C2-46E9-9227-66E6ECE676A8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10b3f03f-071a-495d-ade8-18322aa7a503", "AQAAAAEAACcQAAAAEEfwINtkr4Fm4Y1hcyr4a5OuG+8GIpniFEW7zE/GtKKpxbsEBfy/VSVQk/lIYzS3+A==", "6cce7f81-05ec-40dd-bb39-3f83281c1f42" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39696f0c-2c8a-480f-b917-141b7da708e4"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4078ef19-ba53-481d-9c5a-1c37dfe0e0dc"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8908ea98-b421-420b-9634-03ed356bb921"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("01d31c40-14c9-444c-a2fe-f58ea0fbc08a"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("0512a248-0054-4616-ade5-ae412f4f07bd"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("ecf95bf5-d766-4b6e-94a7-d33ea29c0618"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719440"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("47a91dd5-f999-461a-8f80-935d169ca0c3"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("4cbf8910-c204-46fe-91d4-e8e4c94ff695"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("5263453c-dae9-45e4-8204-5430a7256cde"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("bbc7d071-5f5b-40be-b25e-3aa07a6c3e7c"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2600));

            migrationBuilder.InsertData(
                table: "Menu_Product",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuID", "PriceOfProductBelongToTimeService", "ProductID" },
                values: new object[,]
                {
                    { new Guid("0545878c-542e-481c-842a-77c142115ec6"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2437), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") },
                    { new Guid("3b787691-4a25-4399-ae16-2f089391904b"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2460), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("47219037-e941-4107-b3e2-67beb7c2e48c"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2456), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") },
                    { new Guid("501fc316-ee1a-47b1-a512-c4e7d769ed61"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2426), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") },
                    { new Guid("51479834-4f47-4a75-a293-3d9dfcc9a59c"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2450), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("5b252cd7-25ad-4936-913f-6bcf23e3bad4"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2363), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("5e14d79f-b76d-480f-9d72-240e2ccc43ec"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2421), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("68652742-6293-4c47-8f85-17b81a393196"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2435), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") },
                    { new Guid("ba208184-711b-4e46-8aaf-3db9b72d11dc"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2454), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") },
                    { new Guid("ea02669f-60d1-4122-900d-5225d2b2b225"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2441), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 35000.0, new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38") }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("05a027a2-01b0-40d2-91f7-2a33fc29753f"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2941));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("a8b7026d-5def-44ef-9666-6b78682a77cc"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("f6d015a9-d5bb-40e8-a287-623f0af19fc9"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("36672051-5437-4d2c-a42e-c71a9b67a2b1"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("47bd4dd4-3fb4-463e-b9b9-5ebfb7e1f960"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3306));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3203));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("7db43916-e061-42cb-b0a7-9734423d00cd"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0c308b93-b26a-4224-9d63-28294711aa15"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("45da4260-ba13-489b-995a-1f6adb13ab75"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4ecd72e3-f43d-490f-8b46-8e92ea29f85c"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55265d3b-fa02-4e09-84db-d4e8c8a9a9b5"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6d60bf44-b775-4d87-bb47-aace85d49ac4"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3441));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7d661a30-e180-498c-9a77-cb6112a7cb22"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7da34092-5747-42b7-b059-4a5aad57e740"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3438));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d4fe048d-ff12-4715-93e7-3250f49c15c8"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3475));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f31c789c-4a46-45c7-9009-d36681d788c5"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ffb05663-954d-4af3-8a41-91af39446f81"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3841));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("15fefdbf-b178-49ba-aa7c-7b3e2dd575bc"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3658));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("1b22bdb7-1688-42fa-8fae-4af92e32df7f"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("2ff9d0d9-474c-4466-b9a8-707b730f415c"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("5004477e-1446-467d-8157-972185d64290"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3678));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6a82db5a-23cf-4764-b7d1-ccabce5cc317"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6e841857-2712-4da3-a15f-aed820adef5a"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("8de6ed00-50c8-434e-95ce-cc921426e697"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("ab2099b4-e511-42ff-9e6a-ee71bddcd482"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(3652));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4397));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4402));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4405));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.InsertData(
                table: "Station_Trip",
                columns: new[] { "Id", "Arrived", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StationID", "TripID" },
                values: new object[,]
                {
                    { new Guid("27b72aa1-64ea-425b-95cf-56dd911e2f58"), new DateTime(2023, 11, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4189), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") },
                    { new Guid("38aaeb28-0c54-4f08-923c-edbfce7c445d"), new DateTime(2023, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4197), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7") },
                    { new Guid("4b982542-c54a-4ea8-8396-db66d1caeb99"), new DateTime(2023, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4083), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") },
                    { new Guid("538f22bc-e7f9-4624-95ce-d935ed8430c4"), new DateTime(2023, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4204), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("57b6be5e-dcaf-41ac-af40-1a3a0322dba3"), new DateTime(2023, 5, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4215), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("762cbce8-7864-49cc-9d25-f86933d39767"), new DateTime(2023, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4179), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("02859382-d88c-4e69-8c47-b8e0456677d5") },
                    { new Guid("7ccc4c3e-7263-4ac4-807b-0b4c2f160c7f"), new DateTime(2023, 6, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4229), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52") },
                    { new Guid("f6b19830-a444-4a81-bbfb-df6820a8eedc"), new DateTime(2023, 6, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4222), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") }
                });

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4734));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4740));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4728));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4745));

            migrationBuilder.InsertData(
                table: "Store_Menu",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuId", "StoreId" },
                values: new object[,]
                {
                    { new Guid("08b2a524-a3d7-44e8-9470-4f54a06edd08"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4538), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("1ade5089-954e-4078-86ac-f19c5bfc8afd"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4596), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("404ae956-8f4b-4b60-ab49-6256771b26ef"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4552), false, null, null, new Guid("4cbf8910-c204-46fe-91d4-e8e4c94ff695"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("44851f13-968f-47b7-bb2a-a74a38357547"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4541), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("908e5378-2147-43ab-8dba-1b65d0bc0427"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4544), false, null, null, new Guid("47a91dd5-f999-461a-8f80-935d169ca0c3"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("95638fc7-023f-4b90-861e-eac9f0cd7c8b"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4547), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("afd59540-0043-4edb-900a-9daeb6cbc955"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4535), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("decb10a3-c816-4654-aa55-59f687cc5664"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4550), false, null, null, new Guid("bbc7d071-5f5b-40be-b25e-3aa07a6c3e7c"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("fa768adc-aeab-4ab9-b36c-cbb39f23e084"), null, new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4599), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") }
                });

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("02859382-d88c-4e69-8c47-b8e0456677d5"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4881));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("bf736039-33e9-466f-ac4e-78c89f3317e6"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4961));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("d9852f0d-e836-4a6e-94f4-d229b297933d"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("0bd9818a-5ef1-45e3-a6fe-0c932f970fe8"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("4e917707-0edb-49da-b6f4-804d2c52821b"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("8efb8acc-2eb9-448d-bfa2-825995f50b59"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 23, 34, 31, 407, DateTimeKind.Local).AddTicks(5343));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("0545878c-542e-481c-842a-77c142115ec6"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("3b787691-4a25-4399-ae16-2f089391904b"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("47219037-e941-4107-b3e2-67beb7c2e48c"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("501fc316-ee1a-47b1-a512-c4e7d769ed61"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("51479834-4f47-4a75-a293-3d9dfcc9a59c"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("5b252cd7-25ad-4936-913f-6bcf23e3bad4"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("5e14d79f-b76d-480f-9d72-240e2ccc43ec"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("68652742-6293-4c47-8f85-17b81a393196"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("ba208184-711b-4e46-8aaf-3db9b72d11dc"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("ea02669f-60d1-4122-900d-5225d2b2b225"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("27b72aa1-64ea-425b-95cf-56dd911e2f58"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("38aaeb28-0c54-4f08-923c-edbfce7c445d"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("4b982542-c54a-4ea8-8396-db66d1caeb99"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("538f22bc-e7f9-4624-95ce-d935ed8430c4"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("57b6be5e-dcaf-41ac-af40-1a3a0322dba3"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("762cbce8-7864-49cc-9d25-f86933d39767"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("7ccc4c3e-7263-4ac4-807b-0b4c2f160c7f"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("f6b19830-a444-4a81-bbfb-df6820a8eedc"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("08b2a524-a3d7-44e8-9470-4f54a06edd08"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("1ade5089-954e-4078-86ac-f19c5bfc8afd"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("404ae956-8f4b-4b60-ab49-6256771b26ef"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("44851f13-968f-47b7-bb2a-a74a38357547"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("908e5378-2147-43ab-8dba-1b65d0bc0427"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("95638fc7-023f-4b90-861e-eac9f0cd7c8b"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("afd59540-0043-4edb-900a-9daeb6cbc955"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("decb10a3-c816-4654-aa55-59f687cc5664"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("fa768adc-aeab-4ab9-b36c-cbb39f23e084"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "647D9649-F5A2-4F24-808F-6FC326EC2AA3",
                column: "ConcurrencyStamp",
                value: "bed37c01-16d7-411f-9eb4-2eebd3565bde");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AF5EB4AC-219A-4BC1-99FE-8C23876536EA",
                column: "ConcurrencyStamp",
                value: "16bcdf85-bdf4-46a8-bfc6-99cbcd62f8cc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "CF531396-C1CD-427B-9D17-0383B7675394",
                column: "ConcurrencyStamp",
                value: "8c65f54f-6322-4d7a-b1a3-589d08d8016f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1F11BA64-2870-43F7-BB03-867112867F25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "487b3bf4-08ab-4b4a-8110-fe95371b3fc2", "AQAAAAEAACcQAAAAEHOpkMueqjazVWiCNcTjGYKYpyXVjLrP6nRiDOH+NaYpygyFWZdw5jb6fO/2WHF5eA==", "5375ea16-16e9-422e-b066-675debb330de" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2198E4CD-3305-49C5-B78A-0B54DD76898F",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73cf226a-4ec5-4dab-a038-1561fe7dad47", "AQAAAAEAACcQAAAAELVMM545M79C1nBxD/Yy9zP2mwssQFMJLH0IdBnfOIKxyqVSE0XZ9axiZMN6d/uVaw==", "5f4f2405-3f10-473c-8d3a-2115132135b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9f60228-71d1-4cbb-a0ca-d7a7a52827f7", "AQAAAAEAACcQAAAAENDeQMPaL1iBKrhPX4MLSnqEH4NTmcLyIJh2eggNjpQmKCgok7CFmqv8DmyVGeT0nw==", "12cf9893-2fd2-4ba8-9c63-b0364b4581d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2E089AF6-3437-4DD6-9956-BB792E783AFB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb86872e-63e2-446b-8a29-4a5b3011cd95", "AQAAAAEAACcQAAAAEG9/DT39QRBwjhcZm6GymRXkKTyTIraAyDg0ptZBBmR+zz5TDP63/W49J1LEHrhUIA==", "085e8d2c-c098-4e46-9d51-4a0b9e495e45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bd4283a-ce1b-4682-a572-d128f39109be", "AQAAAAEAACcQAAAAECGEmMWcdQxlJQ7D0WQ3bBDW284yZZK6UnXhANgGvZDYXCxgFqPqFrtMLPioosmmpQ==", "d7fa4efb-8d32-4856-8613-c33f28d7e587" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E6DE8827-B7C2-46E9-9227-66E6ECE676A8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c6904f4-f4f2-423a-8f09-13b03618e3c9", "AQAAAAEAACcQAAAAELkrMLbP7exyylpKNTwZ9FqzIekdsWAOqib7NX4EfVeH2Fsa3R5FSQYqwwCe1JWjZQ==", "29ff9d31-d9ff-44bc-b3c1-51f39a871d36" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 440, DateTimeKind.Local).AddTicks(9902));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39696f0c-2c8a-480f-b917-141b7da708e4"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4078ef19-ba53-481d-9c5a-1c37dfe0e0dc"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 440, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8908ea98-b421-420b-9634-03ed356bb921"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 440, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 440, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("01d31c40-14c9-444c-a2fe-f58ea0fbc08a"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3205));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("0512a248-0054-4616-ade5-ae412f4f07bd"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("ecf95bf5-d766-4b6e-94a7-d33ea29c0618"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719440"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("47a91dd5-f999-461a-8f80-935d169ca0c3"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("4cbf8910-c204-46fe-91d4-e8e4c94ff695"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("5263453c-dae9-45e4-8204-5430a7256cde"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(424));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("bbc7d071-5f5b-40be-b25e-3aa07a6c3e7c"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(443));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.InsertData(
                table: "Menu_Product",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuID", "PriceOfProductBelongToTimeService", "ProductID" },
                values: new object[,]
                {
                    { new Guid("20af074e-7279-40d1-83f8-5e45ed63df6f"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(212), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") },
                    { new Guid("249bb782-77a6-477b-b129-3028b507959b"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(214), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 35000.0, new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38") },
                    { new Guid("4d5eabe6-0096-4a4e-9e47-ea4cb3efd740"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(217), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("61a73ef4-67b2-433c-9dad-66eeea446a10"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(198), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("7c999e10-cc4e-487c-ab5d-ff463c86c4b9"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(206), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") },
                    { new Guid("8c318ef6-e78b-4013-ba71-d525a167f18b"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(222), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") },
                    { new Guid("b964fc1c-d875-40e4-bd15-36dc7c7d45d3"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(225), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("c79f6284-ca72-4bf0-a9cf-74e555e4088f"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(184), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("ea8342af-8b9c-4ee5-b549-86d73ab6cdf9"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(209), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") },
                    { new Guid("f9fd9a11-ef45-4f59-9ebb-fa65fd810562"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(219), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(597));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("05a027a2-01b0-40d2-91f7-2a33fc29753f"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("a8b7026d-5def-44ef-9666-6b78682a77cc"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(794));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("f6d015a9-d5bb-40e8-a287-623f0af19fc9"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("36672051-5437-4d2c-a42e-c71a9b67a2b1"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("47bd4dd4-3fb4-463e-b9b9-5ebfb7e1f960"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("7db43916-e061-42cb-b0a7-9734423d00cd"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0c308b93-b26a-4224-9d63-28294711aa15"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("45da4260-ba13-489b-995a-1f6adb13ab75"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1216));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4ecd72e3-f43d-490f-8b46-8e92ea29f85c"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55265d3b-fa02-4e09-84db-d4e8c8a9a9b5"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1206));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6d60bf44-b775-4d87-bb47-aace85d49ac4"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7d661a30-e180-498c-9a77-cb6112a7cb22"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7da34092-5747-42b7-b059-4a5aad57e740"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d4fe048d-ff12-4715-93e7-3250f49c15c8"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1182));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1224));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f31c789c-4a46-45c7-9009-d36681d788c5"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1191));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ffb05663-954d-4af3-8a41-91af39446f81"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1211));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1686));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("15fefdbf-b178-49ba-aa7c-7b3e2dd575bc"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("1b22bdb7-1688-42fa-8fae-4af92e32df7f"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("2ff9d0d9-474c-4466-b9a8-707b730f415c"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("5004477e-1446-467d-8157-972185d64290"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6a82db5a-23cf-4764-b7d1-ccabce5cc317"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1513));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6e841857-2712-4da3-a15f-aed820adef5a"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1407));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("8de6ed00-50c8-434e-95ce-cc921426e697"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1506));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("ab2099b4-e511-42ff-9e6a-ee71bddcd482"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1446));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2300));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.InsertData(
                table: "Station_Trip",
                columns: new[] { "Id", "Arrived", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StationID", "TripID" },
                values: new object[,]
                {
                    { new Guid("3fcecee0-5e0b-48c8-91ca-ac50f0d25e86"), new DateTime(2023, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2109), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("72462d68-6ca2-4f22-9f60-85321e3eafed"), new DateTime(2023, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2081), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("02859382-d88c-4e69-8c47-b8e0456677d5") },
                    { new Guid("990c6758-35b5-48ad-9152-7f140bf462a9"), new DateTime(2023, 11, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2093), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") },
                    { new Guid("a05b099b-63d1-4e08-9bc6-91e5fcf70d25"), new DateTime(2023, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1965), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") },
                    { new Guid("e1853150-d7e5-44f1-af9b-e7048b792343"), new DateTime(2023, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2101), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7") },
                    { new Guid("e63fdb64-4445-4e49-a372-af0abcfec5b2"), new DateTime(2023, 6, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2124), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("f7c9daba-7c20-406c-a752-04305d97a598"), new DateTime(2023, 5, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2117), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") }
                });

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.InsertData(
                table: "Store_Menu",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuId", "StoreId" },
                values: new object[,]
                {
                    { new Guid("4ec5e41a-4481-415d-b9fc-ca1a8627b745"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2502), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("7860d205-6e69-456e-ba3b-3bb5dbb8b44e"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2474), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("7f1b4fae-81a1-4de5-b1c2-95ad60af4c27"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2496), false, null, null, new Guid("4cbf8910-c204-46fe-91d4-e8e4c94ff695"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("885d8f26-64f2-4ca8-990a-1c4d040a7f79"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2479), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("9f0ced7a-33a8-444c-b73d-4808372315d8"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2499), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("b79065f8-36f0-4a27-a968-20a9aee4b834"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2484), false, null, null, new Guid("47a91dd5-f999-461a-8f80-935d169ca0c3"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("c8c78bcd-e951-4596-a1a2-53ed033575ec"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2493), false, null, null, new Guid("bbc7d071-5f5b-40be-b25e-3aa07a6c3e7c"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("cdfe80e6-7610-476e-a8da-288bacfa47bf"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2482), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("d78230d2-a0dc-49d8-b113-810f51be8bd4"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2490), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") }
                });

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("02859382-d88c-4e69-8c47-b8e0456677d5"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2865));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("bf736039-33e9-466f-ac4e-78c89f3317e6"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("d9852f0d-e836-4a6e-94f4-d229b297933d"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("0bd9818a-5ef1-45e3-a6fe-0c932f970fe8"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("4e917707-0edb-49da-b6f4-804d2c52821b"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("8efb8acc-2eb9-448d-bfa2-825995f50b59"),
                column: "Created",
                value: new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3354));
        }
    }
}
