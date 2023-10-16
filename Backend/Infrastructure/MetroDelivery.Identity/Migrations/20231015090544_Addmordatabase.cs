using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetroDelivery.Identity.Migrations
{
    public partial class Addmordatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("1c2349ff-c3e1-4f55-a982-d38eb06e06c8"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("30618ad8-138d-44b4-8af2-9df4f71e55f0"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("598dcf2c-b581-469b-8a3d-9bad68853309"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("6801c210-ee3a-43ca-a274-1272e0fc6e4b"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("76f3b024-871f-4ffc-b19f-3f1790595f80"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("a3d264b8-60aa-478e-94a9-5a9e354bddc2"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("ace461f5-4f2f-4a70-86e9-d6314efb452c"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("bc80d539-ffbe-400c-bded-b0bc8615dcda"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("d95da7b9-393f-45fa-bd7a-b7b501e4fa61"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("dc89ea4e-c0a8-4a92-9b0f-e9fbda719836"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("4f492978-0dd9-4641-bfb0-90701603f13f"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("589bfc9b-f77f-4845-925f-b2d08c3e3c04"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("648cc34e-59ac-4be0-8e72-f90657a239a3"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("a975b7e8-c5ca-4e81-b8b8-fc840002a511"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("c212b592-2556-4307-84e6-6dfb2154d0da"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("164bcfb2-dae1-4eef-846d-82d0a3fe6285"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("4a6d18e0-3648-4398-9f4f-f24f80de4668"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("6480b2fc-29b9-497b-b45a-7885707ee702"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("82d2ec5c-0c7a-4ff1-983c-9122df296acd"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("bea6ac1c-bafd-4e68-bcf2-4fc1d91e5ef0"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("d2758738-8ee6-4705-b83d-db58fd1086d0"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("fe178469-5c64-44bc-b9ce-11d39cd9e113"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "647D9649-F5A2-4F24-808F-6FC326EC2AA3",
                column: "ConcurrencyStamp",
                value: "802cc645-6da8-4f30-8d70-bf6c727b0c66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AF5EB4AC-219A-4BC1-99FE-8C23876536EA",
                column: "ConcurrencyStamp",
                value: "d2d70aba-e6c0-46aa-802b-1a6180922030");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "CF531396-C1CD-427B-9D17-0383B7675394",
                column: "ConcurrencyStamp",
                value: "b728f91a-a1ef-426e-a86d-4557ba5095b8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1F11BA64-2870-43F7-BB03-867112867F25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb0c00cc-4683-4fec-8110-33d278485dff", "AQAAAAEAACcQAAAAEH1UnPJaK5wzeewm969IamD5DexnTOhFyRF0ELWQSfvZWvbtQe4WSn01vovwjvwW/g==", "5c783b1f-1027-4ade-8846-22f791d095a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2198E4CD-3305-49C5-B78A-0B54DD76898F",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8272b8bd-723c-46fa-b271-36a707733b88", "AQAAAAEAACcQAAAAEB0F6fDvKvyRGDBDDL4USSmke1+8m4QPRynORI6gqfcqc3VJ/BZhiL1nMiMYAoesDg==", "137a9eb5-3e05-4044-8aaa-1446bb84cb8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63defa2a-b404-4fe4-b2d5-873f66cd0686", "AQAAAAEAACcQAAAAEMFN/HkpGJVNhmTedRvI8xc9ZD3UMoGELoatg4So8Sym+ln3UQ2w1YRpEpMTrg1iOA==", "489e613a-a706-420d-9fcd-600ffcc2d795" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2E089AF6-3437-4DD6-9956-BB792E783AFB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ded1b101-f477-4b78-b253-68e3fcac0f39", "AQAAAAEAACcQAAAAEGWvIoFys5vxkPKAOhjfZ70nYOEDWsEuBLUwwsQlq4lxE+Ium3DO6tkF8VPO8otNkg==", "7b892e0e-6856-4539-98e5-7a0bb274da30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c538a6ec-28c7-4570-b98e-cb7a1ab2daa0", "AQAAAAEAACcQAAAAELnJSjHahqza42SavbRqJLjK8lmXaXlvupL3ZW/TbvDlhvMTEBvII9wbL6HrO6WZ2A==", "1a10eade-bc09-4ff8-8ea9-3545c26d348e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E6DE8827-B7C2-46E9-9227-66E6ECE676A8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "306dae96-a572-4916-a6c1-a48979b1d650", "AQAAAAEAACcQAAAAEMvAHqAK7BHmJwiVLAu0eTWSzLYnADvaejvBeDLBCYb/buAQ5CoCHFfkUh4Nc5ZJVg==", "8f06ab10-aa75-4ee5-9c6e-e50dccc31eda" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6671));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39696f0c-2c8a-480f-b917-141b7da708e4"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4078ef19-ba53-481d-9c5a-1c37dfe0e0dc"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8908ea98-b421-420b-9634-03ed356bb921"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("01d31c40-14c9-444c-a2fe-f58ea0fbc08a"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 247, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("0512a248-0054-4616-ade5-ae412f4f07bd"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 247, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 247, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("ecf95bf5-d766-4b6e-94a7-d33ea29c0618"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 247, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719440"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("47a91dd5-f999-461a-8f80-935d169ca0c3"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7141));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("4cbf8910-c204-46fe-91d4-e8e4c94ff695"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("5263453c-dae9-45e4-8204-5430a7256cde"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("bbc7d071-5f5b-40be-b25e-3aa07a6c3e7c"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.InsertData(
                table: "Menu_Product",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuID", "PriceOfProductBelongToTimeService", "ProductID" },
                values: new object[,]
                {
                    { new Guid("1f754627-2730-4c37-8074-a8db5b1e9432"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6835), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("40b8bdd2-289b-481e-9064-1b030b02fc4e"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6941), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("5916f9ab-5878-459d-a65e-20ff50685c8b"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6841), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("6028f98f-5c64-481d-b32b-80c395196e47"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6847), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") },
                    { new Guid("730f8109-1030-4b96-bf6e-970663f203f2"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6951), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("816dcefd-7389-4d84-b968-21a4697a10e7"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6852), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 35000.0, new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38") },
                    { new Guid("984d11da-b11d-4a3b-ae8b-a72e0c7e50cd"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6944), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") },
                    { new Guid("c6619c5b-8da3-4fb8-a5b7-58ee1977fa55"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6948), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") },
                    { new Guid("d166c404-6bcd-4c4d-b8a4-211816745655"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6849), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") },
                    { new Guid("d36d294f-92b6-404a-ba84-b4a1a68de6ee"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(6844), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7291));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("05a027a2-01b0-40d2-91f7-2a33fc29753f"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7431));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("a8b7026d-5def-44ef-9666-6b78682a77cc"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7428));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("f6d015a9-d5bb-40e8-a287-623f0af19fc9"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7422));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("36672051-5437-4d2c-a42e-c71a9b67a2b1"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("47bd4dd4-3fb4-463e-b9b9-5ebfb7e1f960"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7547));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("7db43916-e061-42cb-b0a7-9734423d00cd"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0c308b93-b26a-4224-9d63-28294711aa15"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("45da4260-ba13-489b-995a-1f6adb13ab75"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4ecd72e3-f43d-490f-8b46-8e92ea29f85c"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55265d3b-fa02-4e09-84db-d4e8c8a9a9b5"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6d60bf44-b775-4d87-bb47-aace85d49ac4"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7d661a30-e180-498c-9a77-cb6112a7cb22"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7da34092-5747-42b7-b059-4a5aad57e740"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d4fe048d-ff12-4715-93e7-3250f49c15c8"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f31c789c-4a46-45c7-9009-d36681d788c5"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ffb05663-954d-4af3-8a41-91af39446f81"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8297));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8256));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("15fefdbf-b178-49ba-aa7c-7b3e2dd575bc"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("1b22bdb7-1688-42fa-8fae-4af92e32df7f"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8063));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("2ff9d0d9-474c-4466-b9a8-707b730f415c"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("5004477e-1446-467d-8157-972185d64290"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6a82db5a-23cf-4764-b7d1-ccabce5cc317"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6e841857-2712-4da3-a15f-aed820adef5a"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("8de6ed00-50c8-434e-95ce-cc921426e697"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("ab2099b4-e511-42ff-9e6a-ee71bddcd482"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8731));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.InsertData(
                table: "Station_Trip",
                columns: new[] { "Id", "Arrived", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StationID", "TripID" },
                values: new object[,]
                {
                    { new Guid("218a6839-fd42-44c5-88e0-5f3bc71fda29"), new DateTime(2023, 11, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8549), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") },
                    { new Guid("26dce51c-6e18-4b34-b03c-6a6e9b7d5b3a"), new DateTime(2023, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8436), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") },
                    { new Guid("2d6009e9-229d-449f-978b-ee33e75495c0"), new DateTime(2023, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8538), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("02859382-d88c-4e69-8c47-b8e0456677d5") },
                    { new Guid("531ebf5c-9a62-4dc9-b455-04333c4f061c"), new DateTime(2023, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8556), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7") },
                    { new Guid("8b072155-f302-45ec-8729-a9aaab92d543"), new DateTime(2023, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8564), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("8e9890ce-45c0-459f-a06d-f5eb8d97cae4"), new DateTime(2023, 6, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8577), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("ad84ae87-2d44-4222-a9d6-9cb923ac8a86"), new DateTime(2023, 5, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8571), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") }
                });

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9045));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.InsertData(
                table: "Store_Menu",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuId", "StoreId" },
                values: new object[,]
                {
                    { new Guid("2114fdc1-5b69-472c-92dd-470cc3de948f"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8890), false, null, null, new Guid("bbc7d071-5f5b-40be-b25e-3aa07a6c3e7c"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("aea8ef18-75b7-42a5-8aad-f7438774abf6"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8885), false, null, null, new Guid("47a91dd5-f999-461a-8f80-935d169ca0c3"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("c32108a1-da8f-4462-994b-53ba66f6771f"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8882), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("dc24099c-1234-4414-a332-92058136819b"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8893), false, null, null, new Guid("4cbf8910-c204-46fe-91d4-e8e4c94ff695"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("e60fa834-0f86-490c-ac31-aa358429d04b"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8872), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("f70cc8b9-80b4-4a51-84be-85a4cb9f9548"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8876), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("fc176db9-5959-4373-8d8b-0ac6e5056f02"), null, new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(8888), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") }
                });

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("02859382-d88c-4e69-8c47-b8e0456677d5"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9717));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9728));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9738));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9705));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("bf736039-33e9-466f-ac4e-78c89f3317e6"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("d9852f0d-e836-4a6e-94f4-d229b297933d"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 246, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("0bd9818a-5ef1-45e3-a6fe-0c932f970fe8"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 247, DateTimeKind.Local).AddTicks(243));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("4e917707-0edb-49da-b6f4-804d2c52821b"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 247, DateTimeKind.Local).AddTicks(215));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("8efb8acc-2eb9-448d-bfa2-825995f50b59"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 16, 5, 43, 247, DateTimeKind.Local).AddTicks(234));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("1f754627-2730-4c37-8074-a8db5b1e9432"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("40b8bdd2-289b-481e-9064-1b030b02fc4e"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("5916f9ab-5878-459d-a65e-20ff50685c8b"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("6028f98f-5c64-481d-b32b-80c395196e47"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("730f8109-1030-4b96-bf6e-970663f203f2"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("816dcefd-7389-4d84-b968-21a4697a10e7"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("984d11da-b11d-4a3b-ae8b-a72e0c7e50cd"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("c6619c5b-8da3-4fb8-a5b7-58ee1977fa55"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("d166c404-6bcd-4c4d-b8a4-211816745655"));

            migrationBuilder.DeleteData(
                table: "Menu_Product",
                keyColumn: "Id",
                keyValue: new Guid("d36d294f-92b6-404a-ba84-b4a1a68de6ee"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("218a6839-fd42-44c5-88e0-5f3bc71fda29"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("26dce51c-6e18-4b34-b03c-6a6e9b7d5b3a"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("2d6009e9-229d-449f-978b-ee33e75495c0"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("531ebf5c-9a62-4dc9-b455-04333c4f061c"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("8b072155-f302-45ec-8729-a9aaab92d543"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("8e9890ce-45c0-459f-a06d-f5eb8d97cae4"));

            migrationBuilder.DeleteData(
                table: "Station_Trip",
                keyColumn: "Id",
                keyValue: new Guid("ad84ae87-2d44-4222-a9d6-9cb923ac8a86"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("2114fdc1-5b69-472c-92dd-470cc3de948f"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("aea8ef18-75b7-42a5-8aad-f7438774abf6"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("c32108a1-da8f-4462-994b-53ba66f6771f"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("dc24099c-1234-4414-a332-92058136819b"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("e60fa834-0f86-490c-ac31-aa358429d04b"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("f70cc8b9-80b4-4a51-84be-85a4cb9f9548"));

            migrationBuilder.DeleteData(
                table: "Store_Menu",
                keyColumn: "Id",
                keyValue: new Guid("fc176db9-5959-4373-8d8b-0ac6e5056f02"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "647D9649-F5A2-4F24-808F-6FC326EC2AA3",
                column: "ConcurrencyStamp",
                value: "1df2c155-af10-4968-997d-7403fc9ba335");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "AF5EB4AC-219A-4BC1-99FE-8C23876536EA",
                column: "ConcurrencyStamp",
                value: "ee582322-ac88-453f-81f8-f5975e3c7161");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "CF531396-C1CD-427B-9D17-0383B7675394",
                column: "ConcurrencyStamp",
                value: "99b0fa29-5e15-4aa0-b168-33cb3cebbc8c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1F11BA64-2870-43F7-BB03-867112867F25",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15d7f975-9d22-45ab-8b71-4b8aeb439924", "AQAAAAEAACcQAAAAECB3cG8o9WxwyxlwsFop5SDibZ0XVe/aLpnFthfqN7iizbzBliv0NjDnXQMkYWSZIQ==", "df6b23dc-d6a4-4f43-9b6f-88224cfe3adb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2198E4CD-3305-49C5-B78A-0B54DD76898F",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1683165e-adcd-42b4-9abd-86282f2e86d2", "AQAAAAEAACcQAAAAEFLHJCskxm4a7oZojShQkJgaHQWbpJ2fF8iylLSVqdREMdjxGI9p2CcB7m6IRSq+yw==", "7c328cb2-6c8a-4dd6-926c-1ac756d21d4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d31cf4e8-969a-4342-8f6a-f520182d8f31", "AQAAAAEAACcQAAAAEAMCN9Ba0qxYstaWP+PrT79Dzfin7EL3V1fvCzV35n2Xt9q594oMBHM0OrMnXmtEGg==", "0a379b66-9df4-41e9-95af-eef7e44cfda5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2E089AF6-3437-4DD6-9956-BB792E783AFB",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31405d3f-cab9-4d40-84c6-0f9bee04a447", "AQAAAAEAACcQAAAAEN3jwVC6m9RVOCoRRnqTjNCjhYN5tVGi5Ac8ST7gcrS3JoGWZ5x5XcJkf6IpyWgTUA==", "57e29c19-2711-4c4b-85c5-fa745c739b6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f31e6499-3d1e-4f08-8ae1-5cc7c3e40443", "AQAAAAEAACcQAAAAELpqQhTVuZkXzkjgr67ujRfE0rMHKv5v9VVnDG5MmbcgdeBUlx2aYd61VehavV9nTg==", "71d3e29f-2bad-4106-91d8-a300a520ee5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "E6DE8827-B7C2-46E9-9227-66E6ECE676A8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3396787-e5dd-4eee-a28e-0009d6c19693", "AQAAAAEAACcQAAAAEEycGZ/6c2wfZZEnEfuKxBkeqtYrmpwMKmYzIXRfB9VJaZWPy2rzqXdZ+/99km6eOg==", "595070c6-6499-4f17-acee-5ff7e6e1280f" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39696f0c-2c8a-480f-b917-141b7da708e4"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4078ef19-ba53-481d-9c5a-1c37dfe0e0dc"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(4837));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8908ea98-b421-420b-9634-03ed356bb921"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(4846));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(4852));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(4839));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("01d31c40-14c9-444c-a2fe-f58ea0fbc08a"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("0512a248-0054-4616-ade5-ae412f4f07bd"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("ecf95bf5-d766-4b6e-94a7-d33ea29c0618"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(8131));

            migrationBuilder.UpdateData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719440"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("47a91dd5-f999-461a-8f80-935d169ca0c3"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("4cbf8910-c204-46fe-91d4-e8e4c94ff695"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("5263453c-dae9-45e4-8204-5430a7256cde"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("bbc7d071-5f5b-40be-b25e-3aa07a6c3e7c"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "Id",
                keyValue: new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.InsertData(
                table: "Menu_Product",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuID", "PriceOfProductBelongToTimeService", "ProductID" },
                values: new object[,]
                {
                    { new Guid("1c2349ff-c3e1-4f55-a982-d38eb06e06c8"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5123), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 35000.0, new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38") },
                    { new Guid("30618ad8-138d-44b4-8af2-9df4f71e55f0"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5199), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") },
                    { new Guid("598dcf2c-b581-469b-8a3d-9bad68853309"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5194), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("6801c210-ee3a-43ca-a274-1272e0fc6e4b"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5105), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("76f3b024-871f-4ffc-b19f-3f1790595f80"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5116), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") },
                    { new Guid("a3d264b8-60aa-478e-94a9-5a9e354bddc2"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5121), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") },
                    { new Guid("ace461f5-4f2f-4a70-86e9-d6314efb452c"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5113), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("bc80d539-ffbe-400c-bded-b0bc8615dcda"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5197), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") },
                    { new Guid("d95da7b9-393f-45fa-bd7a-b7b501e4fa61"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5201), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("dc89ea4e-c0a8-4a92-9b0f-e9fbda719836"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5118), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") }
                });

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5538));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "Id",
                keyValue: new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5546));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("05a027a2-01b0-40d2-91f7-2a33fc29753f"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("a8b7026d-5def-44ef-9666-6b78682a77cc"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "OrderDetail",
                keyColumn: "Id",
                keyValue: new Guid("f6d015a9-d5bb-40e8-a287-623f0af19fc9"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("36672051-5437-4d2c-a42e-c71a9b67a2b1"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5810));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("47bd4dd4-3fb4-463e-b9b9-5ebfb7e1f960"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5798));

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "Id",
                keyValue: new Guid("7db43916-e061-42cb-b0a7-9734423d00cd"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5806));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0c308b93-b26a-4224-9d63-28294711aa15"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5994));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("45da4260-ba13-489b-995a-1f6adb13ab75"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5964));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("4ecd72e3-f43d-490f-8b46-8e92ea29f85c"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("55265d3b-fa02-4e09-84db-d4e8c8a9a9b5"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("6d60bf44-b775-4d87-bb47-aace85d49ac4"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7d661a30-e180-498c-9a77-cb6112a7cb22"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5969));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7da34092-5747-42b7-b059-4a5aad57e740"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5973));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d4fe048d-ff12-4715-93e7-3250f49c15c8"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5986));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("f31c789c-4a46-45c7-9009-d36681d788c5"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ffb05663-954d-4af3-8a41-91af39446f81"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6004));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "Route",
                keyColumn: "Id",
                keyValue: new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("15fefdbf-b178-49ba-aa7c-7b3e2dd575bc"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6295));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("1b22bdb7-1688-42fa-8fae-4af92e32df7f"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("2ff9d0d9-474c-4466-b9a8-707b730f415c"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("5004477e-1446-467d-8157-972185d64290"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6316));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6a82db5a-23cf-4764-b7d1-ccabce5cc317"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("6e841857-2712-4da3-a15f-aed820adef5a"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("8de6ed00-50c8-434e-95ce-cc921426e697"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "Route_Station",
                keyColumn: "Id",
                keyValue: new Guid("ab2099b4-e511-42ff-9e6a-ee71bddcd482"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "Station",
                keyColumn: "Id",
                keyValue: new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.InsertData(
                table: "Station_Trip",
                columns: new[] { "Id", "Arrived", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StationID", "TripID" },
                values: new object[,]
                {
                    { new Guid("4f492978-0dd9-4641-bfb0-90701603f13f"), new DateTime(2023, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6785), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("589bfc9b-f77f-4845-925f-b2d08c3e3c04"), new DateTime(2023, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6778), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7") },
                    { new Guid("648cc34e-59ac-4be0-8e72-f90657a239a3"), new DateTime(2023, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6667), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") },
                    { new Guid("a975b7e8-c5ca-4e81-b8b8-fc840002a511"), new DateTime(2023, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6760), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("02859382-d88c-4e69-8c47-b8e0456677d5") },
                    { new Guid("c212b592-2556-4307-84e6-6dfb2154d0da"), new DateTime(2023, 11, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(6770), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") }
                });

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Store",
                keyColumn: "Id",
                keyValue: new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.InsertData(
                table: "Store_Menu",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuId", "StoreId" },
                values: new object[,]
                {
                    { new Guid("164bcfb2-dae1-4eef-846d-82d0a3fe6285"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7050), false, null, null, new Guid("47a91dd5-f999-461a-8f80-935d169ca0c3"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("4a6d18e0-3648-4398-9f4f-f24f80de4668"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7057), false, null, null, new Guid("4cbf8910-c204-46fe-91d4-e8e4c94ff695"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("6480b2fc-29b9-497b-b45a-7885707ee702"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7042), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("82d2ec5c-0c7a-4ff1-983c-9122df296acd"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7048), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("bea6ac1c-bafd-4e68-bcf2-4fc1d91e5ef0"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7038), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("d2758738-8ee6-4705-b83d-db58fd1086d0"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7053), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("fe178469-5c64-44bc-b9ce-11d39cd9e113"), null, new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7055), false, null, null, new Guid("bbc7d071-5f5b-40be-b25e-3aa07a6c3e7c"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") }
                });

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("02859382-d88c-4e69-8c47-b8e0456677d5"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7926));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7857));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("bf736039-33e9-466f-ac4e-78c89f3317e6"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7914));

            migrationBuilder.UpdateData(
                table: "Trip",
                keyColumn: "Id",
                keyValue: new Guid("d9852f0d-e836-4a6e-94f4-d229b297933d"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("0bd9818a-5ef1-45e3-a6fe-0c932f970fe8"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("4e917707-0edb-49da-b6f4-804d2c52821b"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "WithDraw",
                keyColumn: "Id",
                keyValue: new Guid("8efb8acc-2eb9-448d-bfa2-825995f50b59"),
                column: "Created",
                value: new DateTime(2023, 10, 15, 15, 15, 33, 878, DateTimeKind.Local).AddTicks(8274));
        }
    }
}
