using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetroDelivery.Identity.Migrations
{
    public partial class addmoreDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("0453baf2-3266-45d3-a44f-cd89f3c8343d"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("112c6339-52e6-470e-a53c-a9f7f22899f2"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("13503007-ea15-4562-b8c3-173c7bc84133"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("1fbf8ba9-70f4-491a-a287-718593c919d7"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("222f14fc-d016-4b6d-b88a-5734d73fe7c9"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("457458bc-ef88-4ffc-8910-e2f107329868"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("4d829e53-06ad-48d8-b199-6615a078be63"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("853ccee8-0a99-4a5a-9011-6e0b994ca451"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("87354550-1599-476b-a22f-69ad6732ac30"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("8c76f4fc-6d43-4f0e-a074-776069add351"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("9d5b3479-8aae-4d9e-9819-e000ed9f55fb"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("aa0806b3-7e6e-40e5-bcc6-90d3e6aab24c"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("ab03b634-97b3-46a5-b08d-5e03968402f8"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("b87351e3-8e08-4b9c-8235-852feba9f9ff"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("c9b2882f-141c-43bf-908c-c13e5e7d3ed6"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("d070a459-3be4-4e7e-8b29-a05ed3fc3cd9"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("d542e564-848d-42d3-8262-3320e3bd6464"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("dce6f91c-d215-4fb0-bc3a-544f32b3f82e"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("f3858fec-4590-4445-8975-5539a0ed1a65"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("27c006d8-28e1-4e66-8530-5db0df67b563"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("4d330cac-659a-4361-a04c-29a847c8c470"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("530684b3-c8be-4ea1-a475-011f7a0b7d60"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("5439901a-dc7a-48e1-8275-19f4a7641576"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("90bbeee4-3f5b-4472-a462-7b82a54d3c2c"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("b0c366a9-7866-4ee3-9b29-9e62e91de477"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("b339e4f5-0026-485c-ae63-ee2092dfde33"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("bd973f30-c310-4a27-b519-688e3f20b762"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("ca1de47e-b38d-4fd8-8360-3aa09e544e14"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("d439cef0-4d95-49be-b444-7b1659b706c8"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("dc04e152-75dd-42a7-9192-5a66e8490728"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("e48aedf1-3a84-48b3-9d80-492b17de8fd5"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("f86372c6-6d6f-41eb-b3b0-24acb497eeb7"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("13fadf49-f850-4b4c-86de-9ee45ef018d1"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("3a41590e-001c-4b1a-93b6-165b992e655a"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("4278ec8b-2593-4f63-9136-959bdbef1891"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("527ada95-ca3d-4973-90da-de22a3bf09a6"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("5818326a-b1b1-4e7d-940e-7d5e29fec3b1"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("5cc99121-107e-4ed6-b17a-c611468bf453"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("ddb1d498-545d-4d77-92c6-6081ba6e41e6"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "647D9649-F5A2-4F24-808F-6FC326EC2AA3",
                column: "ConcurrencyStamp",
                value: "f3aaf774-0d4e-4a31-8da8-bcb1b2ca6a42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AF5EB4AC-219A-4BC1-99FE-8C23876536EA",
                column: "ConcurrencyStamp",
                value: "da255018-fae8-472b-b269-e958e4e3ea23");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "CF531396-C1CD-427B-9D17-0383B7675394",
                column: "ConcurrencyStamp",
                value: "c1ba3306-bc58-4190-9fde-b1b788bfbe21");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1F11BA64-2870-43F7-BB03-867112867F25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bba2ee5-049a-42ca-b725-853358769da4", "AQAAAAEAACcQAAAAEAQtyyRAgg7jFS+2kv1y7iOdHQ3PmwTL9jft7aO3XmZHX9sGsRAa4Oxd5yZm9HMeNg==", "b8c4da39-21ba-4b75-b660-cf79be2d4fbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2198E4CD-3305-49C5-B78A-0B54DD76898F",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f902a102-6dad-4d1c-975e-592cda71a58d", "AQAAAAEAACcQAAAAEBIlTeOoaDbCne7Mh65wGrB7yrg51dadLkaAOy2BZlFJ3QYW1sFmqkUcthCD/7JdYg==", "66f20328-101c-4cbf-ac6a-29c566ad7962" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf5d9c71-bec0-464d-a7a3-adcf2063431f", "AQAAAAEAACcQAAAAEIpmBMrdQwJKoVG6FxU1UWYyzcDO/rmlsVmxb7VvErOAb2Bo2V3nZFAZ0XCVZiE9JA==", "530bc90e-794d-477f-b16a-506b55513985" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2E089AF6-3437-4DD6-9956-BB792E783AFB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0800fb5-e9a3-4e11-b09e-714dde3fdf97", "AQAAAAEAACcQAAAAEJa2wTnvIyN63ed505BYE4+9bPyvCJSaPuvhfQpUTxwl/GbqhAyRLhbrn7iHvnCgDw==", "1ef22f89-e199-4564-8bf1-0e5c14084bf3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8E48858E-7089-4512-BB79-75AEDC2003D6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31dbff7f-f1e1-4edf-98ba-f69b45a17e14", "AQAAAAEAACcQAAAAEGsykANAZBs48QbFIsPNZWkdkMYLsv8NxAqjdkB8hPEH8txdfy4AqpHxHAiJ8Wj+mQ==", "630f8cd8-c161-45e1-8b5a-2567f035dfc8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2f766a0-94dc-4246-9f20-5ead8f296fee", "AQAAAAEAACcQAAAAEO2W+4QnqYt0suZve/wBKL1iQrftB7eWrRM24K3JntLqk77xidNEZ3UqgCE62IQx0Q==", "15bfc20a-20db-4b7e-a428-ef228fb93961" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DB903C85-4C75-428B-A7B0-9B56130F4813",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5161ee1c-bc61-4ccb-a0f4-e69da3665213", "AQAAAAEAACcQAAAAEOzAIKS8hfHvdPUVoRnt4fejH1uQlmPqib3TwI0awqI+pnULEhXQxhdGliAPO5bo7g==", "b0518f12-7878-4969-b232-2b86e214bb56" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E6DE8827-B7C2-46E9-9227-66E6ECE676A8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d52f3f4c-9b0f-4591-bb5a-25e8da1d0978", "AQAAAAEAACcQAAAAEG30iPyYLXGWSLMPsQ/alt0e3lybH4Xsnqv3w83GCdhvYFDPFn3SuJPA5h8QBagAlw==", "6f134ea9-cc06-48de-a907-dcf60900b37b" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39696f0c-2c8a-480f-b917-141b7da708e4"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4078ef19-ba53-481d-9c5a-1c37dfe0e0dc"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8908ea98-b421-420b-9634-03ed356bb921"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9794));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9789));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("5263453c-dae9-45e4-8204-5430a7256cde"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(219));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(225));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.InsertData(
                table: "Menu_Product",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuID", "PriceOfProductBelongToTimeService", "ProductID" },
                values: new object[,]
                {
                    { new Guid("07ceaf88-c4b6-4259-9db0-67c667e79aa5"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9929), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("21059172-04bd-4251-a1db-de787f6e7f5e"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9967), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("2109ad50-6c04-4953-99ff-234e52667ff9"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9940), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") },
                    { new Guid("30970015-9ece-4333-8f8c-caaf67ca6f48"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9948), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 35000.0, new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38") },
                    { new Guid("3baedad3-e7e8-4d58-bf2a-5f9dfe059e80"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9965), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("4394d0ea-3733-45d7-9996-16555770baa0"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9945), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") },
                    { new Guid("531c59f1-9cce-4160-96f5-415bb32f5246"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9981), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") },
                    { new Guid("59ffcd03-705b-411a-8cac-afa45564dfb0"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9943), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") },
                    { new Guid("5c5e3ea5-979d-4e0e-82bf-4d814613253e"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9952), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") },
                    { new Guid("a627f9ad-dc31-48c3-9036-eb11a23cd2b1"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9974), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("b1a6054b-b4c3-474a-9a4d-855adfb75549"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9955), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") },
                    { new Guid("b64d8cd7-6c2c-45b1-bcf4-55a3bb2a6be3"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9970), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") },
                    { new Guid("c97df2a2-ca19-4ef0-80ce-e89bc3e77a1e"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9984), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") },
                    { new Guid("cd7b0967-2be2-4ac3-8de6-f4a96e9d736c"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9950), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("ce17fd66-3b9a-49b2-ab6b-ce85a445a550"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9937), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("d258d739-f1f4-40f6-9997-0f6230dbf42c"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9960), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("d5262b3c-562d-4df8-9b1b-de9d1edd5653"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9972), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("d8db2d1c-5324-413b-b2a2-9a91c05af288"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9977), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") },
                    { new Guid("e49946ea-240a-4366-9f4a-a0f3506c64fd"), null, new DateTime(2023, 10, 20, 1, 56, 34, 112, DateTimeKind.Local).AddTicks(9962), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("05a027a2-01b0-40d2-91f7-2a33fc29753f"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("a8b7026d-5def-44ef-9666-6b78682a77cc"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("f6d015a9-d5bb-40e8-a287-623f0af19fc9"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("36672051-5437-4d2c-a42e-c71a9b67a2b1"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(595));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("47bd4dd4-3fb4-463e-b9b9-5ebfb7e1f960"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("7db43916-e061-42cb-b0a7-9734423d00cd"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0c308b93-b26a-4224-9d63-28294711aa15"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(785));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(788));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("45da4260-ba13-489b-995a-1f6adb13ab75"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(797));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4ecd72e3-f43d-490f-8b46-8e92ea29f85c"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(779));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55265d3b-fa02-4e09-84db-d4e8c8a9a9b5"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(790));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6d60bf44-b775-4d87-bb47-aace85d49ac4"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7d661a30-e180-498c-9a77-cb6112a7cb22"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(713));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7da34092-5747-42b7-b059-4a5aad57e740"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d4fe048d-ff12-4715-93e7-3250f49c15c8"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f31c789c-4a46-45c7-9009-d36681d788c5"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(776));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ffb05663-954d-4af3-8a41-91af39446f81"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(795));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1114));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("15fefdbf-b178-49ba-aa7c-7b3e2dd575bc"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("1b22bdb7-1688-42fa-8fae-4af92e32df7f"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("2ff9d0d9-474c-4466-b9a8-707b730f415c"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(951));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("5004477e-1446-467d-8157-972185d64290"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6a82db5a-23cf-4764-b7d1-ccabce5cc317"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6e841857-2712-4da3-a15f-aed820adef5a"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("8de6ed00-50c8-434e-95ce-cc921426e697"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("ab2099b4-e511-42ff-9e6a-ee71bddcd482"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.InsertData(
                table: "Station_Trip",
                columns: new[] { "Id", "Arrived", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StationID", "TripID" },
                values: new object[,]
                {
                    { new Guid("032b693b-e928-429b-8876-2ce2db58c246"), new DateTime(2023, 10, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1428), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("1db6585e-5749-4b9c-80e2-a294840ac211"), new DateTime(2023, 6, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1409), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("3923e7e7-92d2-400d-bf57-2150f95cfcac"), new DateTime(2023, 10, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1444), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("3b7e4731-c1b9-49ea-af1a-f9e03abdbacf"), new DateTime(2023, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1385), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7") },
                    { new Guid("4baa5978-fe1d-46e0-a686-bc212d12f3a6"), new DateTime(2023, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1363), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("02859382-d88c-4e69-8c47-b8e0456677d5") },
                    { new Guid("509372b7-a844-4a91-9477-ecedaf919ba1"), new DateTime(2023, 5, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1402), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("6584fdd6-f9df-4d11-8898-75f648d2a8fb"), new DateTime(2023, 10, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1435), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("8eec3fee-ba90-429f-9178-9e76b1253b1b"), new DateTime(2023, 10, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1450), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("9f80c33f-061c-4954-9756-1e085de0d78f"), new DateTime(2023, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1393), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("cff45ac7-02e9-4800-82a1-5c547cdbc651"), new DateTime(2023, 10, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1422), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("ef1c69d9-5ce6-4869-9331-239379cbed0b"), new DateTime(2023, 6, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1415), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52") },
                    { new Guid("f973704e-768f-4308-83a2-c98366412ecb"), new DateTime(2023, 11, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1375), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") },
                    { new Guid("ff19c16b-fd00-4f93-8eaa-1d3859753873"), new DateTime(2023, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1241), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") }
                });

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.InsertData(
                table: "Store_Menu",
                columns: new[] { "Id", "ApplyDate", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuId", "Priority", "StoreId" },
                values: new object[,]
                {
                    { new Guid("072a4b51-0474-49b3-a307-224b9fc1c15d"), "Tuesday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1885), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("ef443e4b-886c-4c06-8528-51e9cf623867") },
                    { new Guid("07df9ecc-7d79-4971-a57b-55580e257db5"), "Tuesday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1887), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4") },
                    { new Guid("0a84bf68-74ee-46ce-b8fd-b72908b2cf53"), "Saturday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1931), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), false, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("0cd66c9c-af16-40ce-9006-40b2e68df427"), "Thursday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1807), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("ef443e4b-886c-4c06-8528-51e9cf623867") },
                    { new Guid("0d716082-e097-41f7-b416-f0593e2f3b14"), "Saturday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1946), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4") },
                    { new Guid("0f1fd743-7ed6-4f8f-bbff-c3563e2052f4"), "Saturday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1934), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("d3599df7-877e-41c7-832d-14850e5c88bd") },
                    { new Guid("107f8d60-4c03-42f0-a7c9-bce912099f3a"), "Thursday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1792), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("3c43b7af-221c-4585-ab1e-5ba91a7e473c"), "Friday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1909), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("3e2f3867-d054-487e-9ea8-fa2aff69dee6"), "Thursday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1804), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("3f671cd4-49c7-493b-b050-5b9061b27630"), "Sunday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1951), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), false, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("40b8e3e9-9dcd-4081-9e44-d0b5ff251933"), "Friday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1924), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("ef443e4b-886c-4c06-8528-51e9cf623867") },
                    { new Guid("43037bb6-cb3a-412e-93f0-6a370615a5f5"), "Sunday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1948), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("455e9b7e-782b-4996-875a-142092d8760d"), "Sunday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1959), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("4d5a3b42-d17e-4ca0-8490-00b1c8365f68"), "Tuesday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1872), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), false, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("514f5f2d-3236-473b-a202-76a814153688"), "Saturday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1929), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("571f6cea-d1b7-4e00-9e15-d7698b077c22"), "Monday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1812), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("5bf48359-3287-4a1d-88dd-1b850b6054f2"), "Friday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1926), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4") },
                    { new Guid("5dcd79a0-69cc-426d-915b-2fae6dfcf3a2"), "Monday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1861), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("63e7b5b2-ba28-490d-822d-93dad4ebbbd4"), "Saturday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1939), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("66053353-e324-4efa-868e-ad5c6d9c45a7"), "Thursday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1810), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4") },
                    { new Guid("680e3d70-9bf7-4d4e-aaf5-8bb9c2b5204d"), "Tuesday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1870), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") }
                });

            migrationBuilder.InsertData(
                table: "Store_Menu",
                columns: new[] { "Id", "ApplyDate", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuId", "Priority", "StoreId" },
                values: new object[,]
                {
                    { new Guid("6954aca4-e66d-4855-a7a5-f27740537688"), "Tuesday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1882), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("6dba0216-b617-4cce-ba58-26edf187d193"), "Tuesday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1880), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("70164a14-015f-40ea-b5bf-c47329eba7bc"), "Monday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1867), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4") },
                    { new Guid("802cdea6-3f92-433a-87fa-83bfdb2343dc"), "Sunday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1961), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("ef443e4b-886c-4c06-8528-51e9cf623867") },
                    { new Guid("82b05d9c-d011-4112-9052-7857d090681d"), "Tuesday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1876), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("d3599df7-877e-41c7-832d-14850e5c88bd") },
                    { new Guid("8badb5a8-0f81-4989-9c75-2f7c621e49ac"), "Monday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1819), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("d3599df7-877e-41c7-832d-14850e5c88bd") },
                    { new Guid("8bba0302-8ef1-4fcc-9d2b-1ae6eea34e64"), "Thursday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1802), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("92e03aff-f3d9-4715-a5a0-4089dd4b7d75"), "Thursday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1797), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), false, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("9613329a-1687-4654-9fe8-df1731e71aeb"), "Saturday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1936), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("9b6c349b-f45d-489c-89aa-8a9783b2e4ed"), "Wednesday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1892), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), false, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("9c53937b-fe83-4072-928a-f4f30b82d3e1"), "Wednesday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1899), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("9f2a9ef2-fe56-4520-b661-03ebfa31684f"), "Friday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1912), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), false, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("aafbb93f-17ba-4793-bc8b-4e28a6d7dd37"), "Sunday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1966), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4") },
                    { new Guid("b56946f8-54d2-4e0f-a77a-0496fe88b128"), "Sunday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1954), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("d3599df7-877e-41c7-832d-14850e5c88bd") },
                    { new Guid("b5983fca-4afe-46af-aef7-3668fe01828a"), "Monday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1864), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("ef443e4b-886c-4c06-8528-51e9cf623867") },
                    { new Guid("bcfd234a-5152-4480-a332-876956864c10"), "Wednesday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1907), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4") },
                    { new Guid("beb01245-ca1c-49f9-8bdf-f7482ca5070e"), "Wednesday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1902), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("bee92f03-70cf-45d5-81c5-e5a4acaffa57"), "Wednesday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1904), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("ef443e4b-886c-4c06-8528-51e9cf623867") },
                    { new Guid("c59c8198-e772-4491-9bfe-c83a3644ee82"), "Friday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1914), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("d3599df7-877e-41c7-832d-14850e5c88bd") },
                    { new Guid("cc565a9f-4899-4a86-b453-a94d014ca19e"), "Wednesday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1895), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("d3599df7-877e-41c7-832d-14850e5c88bd") },
                    { new Guid("d3048d8e-5e12-41a3-bf4f-7f9aac153f0f"), "Saturday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1943), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("ef443e4b-886c-4c06-8528-51e9cf623867") },
                    { new Guid("d8c5b2b4-3f8c-4aff-84be-16ee717b5b67"), "Monday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1817), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), false, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("e4a50a5d-ed68-4eee-92f8-cc1f3c40fa28"), "Wednesday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1890), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("e55b83dd-cd3d-4f3c-bea9-0e19cd0aeea5"), "Monday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1822), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("ea94844d-d15c-4c9f-8c1b-45779949c9ef"), "Thursday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1799), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("d3599df7-877e-41c7-832d-14850e5c88bd") },
                    { new Guid("ed91010d-705d-4da1-9771-dc6bde737505"), "Friday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1921), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("ef1b206c-d6ba-445f-83f2-5b59ef7c2721"), "Friday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1917), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("fbdb5a0c-0ab5-426c-b979-52f40eb05e82"), "Sunday", null, new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(1956), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") }
                });

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("02859382-d88c-4e69-8c47-b8e0456677d5"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("bf736039-33e9-466f-ac4e-78c89f3317e6"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("d9852f0d-e836-4a6e-94f4-d229b297933d"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("0bd9818a-5ef1-45e3-a6fe-0c932f970fe8"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("4e917707-0edb-49da-b6f4-804d2c52821b"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("8efb8acc-2eb9-448d-bfa2-825995f50b59"),
                column: "Created",
                value: new DateTime(2023, 10, 20, 1, 56, 34, 113, DateTimeKind.Local).AddTicks(2737));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("07ceaf88-c4b6-4259-9db0-67c667e79aa5"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("21059172-04bd-4251-a1db-de787f6e7f5e"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("2109ad50-6c04-4953-99ff-234e52667ff9"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("30970015-9ece-4333-8f8c-caaf67ca6f48"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("3baedad3-e7e8-4d58-bf2a-5f9dfe059e80"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("4394d0ea-3733-45d7-9996-16555770baa0"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("531c59f1-9cce-4160-96f5-415bb32f5246"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("59ffcd03-705b-411a-8cac-afa45564dfb0"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("5c5e3ea5-979d-4e0e-82bf-4d814613253e"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("a627f9ad-dc31-48c3-9036-eb11a23cd2b1"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("b1a6054b-b4c3-474a-9a4d-855adfb75549"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("b64d8cd7-6c2c-45b1-bcf4-55a3bb2a6be3"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("c97df2a2-ca19-4ef0-80ce-e89bc3e77a1e"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("cd7b0967-2be2-4ac3-8de6-f4a96e9d736c"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("ce17fd66-3b9a-49b2-ab6b-ce85a445a550"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("d258d739-f1f4-40f6-9997-0f6230dbf42c"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("d5262b3c-562d-4df8-9b1b-de9d1edd5653"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("d8db2d1c-5324-413b-b2a2-9a91c05af288"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("e49946ea-240a-4366-9f4a-a0f3506c64fd"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("032b693b-e928-429b-8876-2ce2db58c246"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("1db6585e-5749-4b9c-80e2-a294840ac211"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("3923e7e7-92d2-400d-bf57-2150f95cfcac"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("3b7e4731-c1b9-49ea-af1a-f9e03abdbacf"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("4baa5978-fe1d-46e0-a686-bc212d12f3a6"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("509372b7-a844-4a91-9477-ecedaf919ba1"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("6584fdd6-f9df-4d11-8898-75f648d2a8fb"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("8eec3fee-ba90-429f-9178-9e76b1253b1b"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("9f80c33f-061c-4954-9756-1e085de0d78f"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("cff45ac7-02e9-4800-82a1-5c547cdbc651"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("ef1c69d9-5ce6-4869-9331-239379cbed0b"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("f973704e-768f-4308-83a2-c98366412ecb"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("ff19c16b-fd00-4f93-8eaa-1d3859753873"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("072a4b51-0474-49b3-a307-224b9fc1c15d"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("07df9ecc-7d79-4971-a57b-55580e257db5"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("0a84bf68-74ee-46ce-b8fd-b72908b2cf53"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("0cd66c9c-af16-40ce-9006-40b2e68df427"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("0d716082-e097-41f7-b416-f0593e2f3b14"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("0f1fd743-7ed6-4f8f-bbff-c3563e2052f4"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("107f8d60-4c03-42f0-a7c9-bce912099f3a"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("3c43b7af-221c-4585-ab1e-5ba91a7e473c"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("3e2f3867-d054-487e-9ea8-fa2aff69dee6"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("3f671cd4-49c7-493b-b050-5b9061b27630"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("40b8e3e9-9dcd-4081-9e44-d0b5ff251933"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("43037bb6-cb3a-412e-93f0-6a370615a5f5"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("455e9b7e-782b-4996-875a-142092d8760d"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("4d5a3b42-d17e-4ca0-8490-00b1c8365f68"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("514f5f2d-3236-473b-a202-76a814153688"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("571f6cea-d1b7-4e00-9e15-d7698b077c22"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("5bf48359-3287-4a1d-88dd-1b850b6054f2"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("5dcd79a0-69cc-426d-915b-2fae6dfcf3a2"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("63e7b5b2-ba28-490d-822d-93dad4ebbbd4"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("66053353-e324-4efa-868e-ad5c6d9c45a7"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("680e3d70-9bf7-4d4e-aaf5-8bb9c2b5204d"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("6954aca4-e66d-4855-a7a5-f27740537688"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("6dba0216-b617-4cce-ba58-26edf187d193"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("70164a14-015f-40ea-b5bf-c47329eba7bc"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("802cdea6-3f92-433a-87fa-83bfdb2343dc"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("82b05d9c-d011-4112-9052-7857d090681d"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("8badb5a8-0f81-4989-9c75-2f7c621e49ac"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("8bba0302-8ef1-4fcc-9d2b-1ae6eea34e64"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("92e03aff-f3d9-4715-a5a0-4089dd4b7d75"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("9613329a-1687-4654-9fe8-df1731e71aeb"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("9b6c349b-f45d-489c-89aa-8a9783b2e4ed"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("9c53937b-fe83-4072-928a-f4f30b82d3e1"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("9f2a9ef2-fe56-4520-b661-03ebfa31684f"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("aafbb93f-17ba-4793-bc8b-4e28a6d7dd37"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("b56946f8-54d2-4e0f-a77a-0496fe88b128"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("b5983fca-4afe-46af-aef7-3668fe01828a"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("bcfd234a-5152-4480-a332-876956864c10"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("beb01245-ca1c-49f9-8bdf-f7482ca5070e"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("bee92f03-70cf-45d5-81c5-e5a4acaffa57"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("c59c8198-e772-4491-9bfe-c83a3644ee82"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("cc565a9f-4899-4a86-b453-a94d014ca19e"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("d3048d8e-5e12-41a3-bf4f-7f9aac153f0f"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("d8c5b2b4-3f8c-4aff-84be-16ee717b5b67"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("e4a50a5d-ed68-4eee-92f8-cc1f3c40fa28"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("e55b83dd-cd3d-4f3c-bea9-0e19cd0aeea5"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("ea94844d-d15c-4c9f-8c1b-45779949c9ef"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("ed91010d-705d-4da1-9771-dc6bde737505"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("ef1b206c-d6ba-445f-83f2-5b59ef7c2721"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("fbdb5a0c-0ab5-426c-b979-52f40eb05e82"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "647D9649-F5A2-4F24-808F-6FC326EC2AA3",
                column: "ConcurrencyStamp",
                value: "09103b3b-64b1-41d1-9c71-dd211956ff6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AF5EB4AC-219A-4BC1-99FE-8C23876536EA",
                column: "ConcurrencyStamp",
                value: "5fec4c9e-89c4-42b5-b5c7-2ac317a38549");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "CF531396-C1CD-427B-9D17-0383B7675394",
                column: "ConcurrencyStamp",
                value: "52ac756a-4029-4e25-9e0d-4495bd6d33f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1F11BA64-2870-43F7-BB03-867112867F25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef8e236b-527f-4506-a9c6-904b4757985f", "AQAAAAEAACcQAAAAEGosw6FcJrYUV9ClogMwlu0X+ZLD45hTpZvnMbXNKH1p+McZz25oaahlWwEYy+vAEA==", "12ff0098-a861-4910-b659-83a1951e2e0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2198E4CD-3305-49C5-B78A-0B54DD76898F",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7abeeee-fa54-409d-909f-cd7e3ec4a0b0", "AQAAAAEAACcQAAAAEM5hh+QraMJWn4jH0OxG+CPfChhtdaBi5SqoPJQMIwrHZ/LHUL5HPzPZ9JgeuKLrKA==", "daf655ec-af42-494f-8169-c526e086dd5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64e32953-9311-418d-a9f5-d03c9e249878", "AQAAAAEAACcQAAAAEDR84h1U7alf1P2yasi7oi8Uo6wD+CGiqF6/F246fUGqPWLl2+Z7J5P2Vld857fniQ==", "00737c01-5556-4386-81b7-4c1c78ce80f6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2E089AF6-3437-4DD6-9956-BB792E783AFB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af7feb6c-c077-4213-82e9-47b540e0493a", "AQAAAAEAACcQAAAAEL8T1i/zp1ZbBQDbC1jbojtw86Jjk2J9LhS28NSa4gJzHeGeQjkLk0B2naz8fhzqgQ==", "d6e18970-d55c-4804-8f41-69532f85242a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8E48858E-7089-4512-BB79-75AEDC2003D6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "937e22f2-5e81-4407-b817-ad8cdf7a7630", "AQAAAAEAACcQAAAAEC1rgNU90O11ZR7egUkYHhNROOtc/hRX094loVUJsEIrmyEQa0ebFjQXCjGB779NUg==", "0c3a0670-60bf-471c-90dd-65b24d54d369" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc11ee9e-b5c9-44c7-962e-54310d6e121b", "AQAAAAEAACcQAAAAEGpU1Tzkeuvd0QMXiyH10manvhtWfMCyJXJFBGpgKKY/Nz6HbUpj9wrdPzwo+JDz4w==", "5f26b5dc-87b8-4806-93be-d947f23952bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "DB903C85-4C75-428B-A7B0-9B56130F4813",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a2403ce-e00f-4338-9752-554e4add8233", "AQAAAAEAACcQAAAAEEibfoh9SBjB2uJnTNVIep7EsgwYCnj1x3GEKn2ulZta3yPZEYMysgIo8JpfDPRR4g==", "26bf4f70-6585-4cba-8a60-e49a0d07d1b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E6DE8827-B7C2-46E9-9227-66E6ECE676A8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e04b5471-faa0-4cf8-b7b0-113c099c9aba", "AQAAAAEAACcQAAAAENXLYYiqj9THaZOMP3TuSeqkMDjgH6dS0QkiOl1gHRS9LqiyVl1Uszo0WmKCnR9zlw==", "ab0f86bf-bcad-46df-a1b9-fde8cc3ca1a5" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39696f0c-2c8a-480f-b917-141b7da708e4"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4078ef19-ba53-481d-9c5a-1c37dfe0e0dc"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8908ea98-b421-420b-9634-03ed356bb921"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("5263453c-dae9-45e4-8204-5430a7256cde"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9570));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9488));

            migrationBuilder.InsertData(
                table: "Menu_Product",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuID", "PriceOfProductBelongToTimeService", "ProductID" },
                values: new object[,]
                {
                    { new Guid("0453baf2-3266-45d3-a44f-cd89f3c8343d"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9318), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") },
                    { new Guid("112c6339-52e6-470e-a53c-a9f7f22899f2"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9308), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("13503007-ea15-4562-b8c3-173c7bc84133"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9177), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") },
                    { new Guid("1fbf8ba9-70f4-491a-a287-718593c919d7"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9180), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") },
                    { new Guid("222f14fc-d016-4b6d-b88a-5734d73fe7c9"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9330), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") },
                    { new Guid("457458bc-ef88-4ffc-8910-e2f107329868"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9320), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("4d829e53-06ad-48d8-b199-6615a078be63"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9193), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") },
                    { new Guid("853ccee8-0a99-4a5a-9011-6e0b994ca451"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9315), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("87354550-1599-476b-a22f-69ad6732ac30"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9313), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("8c76f4fc-6d43-4f0e-a074-776069add351"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9310), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") },
                    { new Guid("9d5b3479-8aae-4d9e-9819-e000ed9f55fb"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9333), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") },
                    { new Guid("aa0806b3-7e6e-40e5-bcc6-90d3e6aab24c"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9187), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 35000.0, new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38") },
                    { new Guid("ab03b634-97b3-46a5-b08d-5e03968402f8"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9305), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") },
                    { new Guid("b87351e3-8e08-4b9c-8235-852feba9f9ff"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9323), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("c9b2882f-141c-43bf-908c-c13e5e7d3ed6"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9168), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("d070a459-3be4-4e7e-8b29-a05ed3fc3cd9"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9190), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("d542e564-848d-42d3-8262-3320e3bd6464"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9174), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("dce6f91c-d215-4fb0-bc3a-544f32b3f82e"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9184), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") },
                    { new Guid("f3858fec-4590-4445-8975-5539a0ed1a65"), null, new DateTime(2023, 10, 19, 22, 23, 42, 702, DateTimeKind.Local).AddTicks(9328), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("05a027a2-01b0-40d2-91f7-2a33fc29753f"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("a8b7026d-5def-44ef-9666-6b78682a77cc"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("f6d015a9-d5bb-40e8-a287-623f0af19fc9"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("36672051-5437-4d2c-a42e-c71a9b67a2b1"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("47bd4dd4-3fb4-463e-b9b9-5ebfb7e1f960"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("7db43916-e061-42cb-b0a7-9734423d00cd"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0c308b93-b26a-4224-9d63-28294711aa15"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("45da4260-ba13-489b-995a-1f6adb13ab75"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4ecd72e3-f43d-490f-8b46-8e92ea29f85c"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55265d3b-fa02-4e09-84db-d4e8c8a9a9b5"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6d60bf44-b775-4d87-bb47-aace85d49ac4"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7d661a30-e180-498c-9a77-cb6112a7cb22"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7da34092-5747-42b7-b059-4a5aad57e740"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d4fe048d-ff12-4715-93e7-3250f49c15c8"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(635));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f31c789c-4a46-45c7-9009-d36681d788c5"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(639));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ffb05663-954d-4af3-8a41-91af39446f81"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1235));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("15fefdbf-b178-49ba-aa7c-7b3e2dd575bc"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("1b22bdb7-1688-42fa-8fae-4af92e32df7f"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("2ff9d0d9-474c-4466-b9a8-707b730f415c"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(844));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("5004477e-1446-467d-8157-972185d64290"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6a82db5a-23cf-4764-b7d1-ccabce5cc317"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(871));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6e841857-2712-4da3-a15f-aed820adef5a"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("8de6ed00-50c8-434e-95ce-cc921426e697"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(864));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("ab2099b4-e511-42ff-9e6a-ee71bddcd482"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(851));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1694));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.InsertData(
                table: "Station_Trip",
                columns: new[] { "Id", "Arrived", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StationID", "TripID" },
                values: new object[,]
                {
                    { new Guid("27c006d8-28e1-4e66-8530-5db0df67b563"), new DateTime(2023, 10, 19, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1530), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("4d330cac-659a-4361-a04c-29a847c8c470"), new DateTime(2023, 5, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1486), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("530684b3-c8be-4ea1-a475-011f7a0b7d60"), new DateTime(2023, 10, 19, 21, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1507), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("5439901a-dc7a-48e1-8275-19f4a7641576"), new DateTime(2023, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1450), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("02859382-d88c-4e69-8c47-b8e0456677d5") },
                    { new Guid("90bbeee4-3f5b-4472-a462-7b82a54d3c2c"), new DateTime(2023, 10, 19, 12, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1523), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("b0c366a9-7866-4ee3-9b29-9e62e91de477"), new DateTime(2023, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1470), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7") },
                    { new Guid("b339e4f5-0026-485c-ae63-ee2092dfde33"), new DateTime(2023, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1479), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("bd973f30-c310-4a27-b519-688e3f20b762"), new DateTime(2023, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1354), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") },
                    { new Guid("ca1de47e-b38d-4fd8-8360-3aa09e544e14"), new DateTime(2023, 11, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1463), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") },
                    { new Guid("d439cef0-4d95-49be-b444-7b1659b706c8"), new DateTime(2023, 6, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1493), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("dc04e152-75dd-42a7-9192-5a66e8490728"), new DateTime(2023, 10, 19, 15, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1537), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") },
                    { new Guid("e48aedf1-3a84-48b3-9d80-492b17de8fd5"), new DateTime(2023, 6, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1500), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52") },
                    { new Guid("f86372c6-6d6f-41eb-b3b0-24acb497eeb7"), new DateTime(2023, 10, 19, 22, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1514), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932") }
                });

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2034));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.InsertData(
                table: "Store_Menu",
                columns: new[] { "Id", "ApplyDate", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuId", "Priority", "StoreId" },
                values: new object[,]
                {
                    { new Guid("13fadf49-f850-4b4c-86de-9ee45ef018d1"), "Thursday", null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1889), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("ef443e4b-886c-4c06-8528-51e9cf623867") },
                    { new Guid("3a41590e-001c-4b1a-93b6-165b992e655a"), "Thursday", null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1837), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("4278ec8b-2593-4f63-9136-959bdbef1891"), "Thursday", null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1844), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("d3599df7-877e-41c7-832d-14850e5c88bd") },
                    { new Guid("527ada95-ca3d-4973-90da-de22a3bf09a6"), "Thursday", null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1892), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), true, new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4") },
                    { new Guid("5818326a-b1b1-4e7d-940e-7d5e29fec3b1"), "Thursday", null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1887), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("5cc99121-107e-4ed6-b17a-c611468bf453"), "Thursday", null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1884), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), true, new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("ddb1d498-545d-4d77-92c6-6081ba6e41e6"), "Thursday", null, new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(1842), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), false, new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") }
                });

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("02859382-d88c-4e69-8c47-b8e0456677d5"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2304));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("bf736039-33e9-466f-ac4e-78c89f3317e6"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2353));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("d9852f0d-e836-4a6e-94f4-d229b297933d"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("0bd9818a-5ef1-45e3-a6fe-0c932f970fe8"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("4e917707-0edb-49da-b6f4-804d2c52821b"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("8efb8acc-2eb9-448d-bfa2-825995f50b59"),
                column: "Created",
                value: new DateTime(2023, 10, 19, 22, 23, 42, 703, DateTimeKind.Local).AddTicks(2906));
        }
    }
}
