using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MetroDelivery.Identity.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Wallet = table.Column<double>(type: "float", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTimeService = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTimeService = table.Column<TimeSpan>(type: "time", nullable: false),
                    ApplyDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentMethodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FromLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StoreOpenTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    StoreCloseTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WithDraw",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PaymentMethodID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Balance = table.Column<double>(type: "float", nullable: true),
                    Deposit = table.Column<double>(type: "float", nullable: true),
                    CreateTimeOfWithdraw = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithDraw", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WithDraw_AspNetUsers_ApplicationUserID",
                        column: x => x.ApplicationUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WithDraw_PaymentMethod_PaymentMethodID",
                        column: x => x.PaymentMethodID,
                        principalTable: "PaymentMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trip",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RouteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TripName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TripStartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TripEndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trip", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trip_Route_RouteId",
                        column: x => x.RouteId,
                        principalTable: "Route",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Station",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Station", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Station_Store_StoreID",
                        column: x => x.StoreID,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Store_Menu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store_Menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Store_Menu_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Store_Menu_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menu_Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MenuID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PriceOfProductBelongToTimeService = table.Column<double>(type: "float", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Product_Menu_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menu_Product_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TripID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: true),
                    OrderTokenQR = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_ApplicationUserID",
                        column: x => x.ApplicationUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Store_StoreID",
                        column: x => x.StoreID,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Trip_TripID",
                        column: x => x.TripID,
                        principalTable: "Trip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Route_Station",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RouteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Index = table.Column<int>(type: "int", nullable: true),
                    Duration = table.Column<TimeSpan>(type: "time", nullable: true),
                    StopTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route_Station", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Route_Station_Route_RouteID",
                        column: x => x.RouteID,
                        principalTable: "Route",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Route_Station_Station_StationID",
                        column: x => x.StationID,
                        principalTable: "Station",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Station_Trip",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TripID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Arrived = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Station_Trip", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Station_Trip_Station_StationID",
                        column: x => x.StationID,
                        principalTable: "Station",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Station_Trip_Trip_TripID",
                        column: x => x.TripID,
                        principalTable: "Trip",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quanity = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "647D9649-F5A2-4F24-808F-6FC326EC2AA3", "70d15b5d-c2d9-48f1-89dd-882d4901b67a", "Staff", "Staff" },
                    { "AF5EB4AC-219A-4BC1-99FE-8C23876536EA", "4562a030-a4fd-46d0-82f3-167931bc7255", "Admin", "Admin" },
                    { "CF531396-C1CD-427B-9D17-0383B7675394", "f2f94108-062d-44c7-9a3d-628da02f0292", "EndUser", "EndUser" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Birthday", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "Wallet" },
                values: new object[,]
                {
                    { "1F11BA64-2870-43F7-BB03-867112867F25", 0, "Gia Lai", new DateTime(1998, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "446d9b00-f89e-41d1-9739-ea69b51f43fc", "thaivin537@gmail.com", true, "Thái", "Vĩ", false, null, "THAIVIN537@GMAIL.COM", "THAIVIN537@GMAIL.COM", "AQAAAAEAACcQAAAAENLoIoULwZej5jyBe0o1PkQKQ961UiKRUtQuc15WVQTEZgzVoEudDPlPFmblkSoq3A==", "0914009910", false, "8253d1dc-c1ec-43e0-bfd3-ebd7d1d9b8b3", false, "thaivin537@gmail.com", null },
                    { "2198E4CD-3305-49C5-B78A-0B54DD76898F", 0, "da nang", new DateTime(2002, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "01cf8197-dafa-4757-b884-db8fb5c49235", "admin@gmail.com", true, "Nhan", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEJRqQ/q7fG0oPUvgDCbTzeDBSZCJMQXzPpK74jG9Gx1XVDgyPXPd5iFH6Q7MNfQKLw==", "03030303", false, "bf8435fb-0902-4d1c-841b-85f6b3b0c2fe", false, "admin@gmail.com", null },
                    { "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84", 0, "Cần Thơ", new DateTime(2002, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "7be5e016-b161-45d5-9646-5d13e8de080d", "staff@gmail.com", true, "Vi", "Staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEPS2urGggzrXls8VYwPM+40O04GPU4CLAH8bw6lEa30YDLckdCUeamQobvxn3xOevA==", "0961868641", false, "5cace682-07c9-49f8-9d46-ef2cda181215", false, "staff@gmail.com", null },
                    { "2E089AF6-3437-4DD6-9956-BB792E783AFB", 0, "Đắk Lắk", new DateTime(1899, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "eed1f2e6-d949-4f75-890e-fa536dabcecb", "nguyenthanhn537@gmail.com", true, "Nhân", "Nguyễn", false, null, "NGUYENTHANHN537@GMAIL.COM", "NGUYENTHANHN537@GMAIL.COM", "AQAAAAEAACcQAAAAEDQ6DFOL4mIv6ajPg8thSeeaOB2vYjaqFTXDAWJqyX8DU7Jk6AQBbxK9GHaitIVgEg==", "0903182861", false, "877bacec-7811-4cf9-9ce2-f92173dc15a5", false, "nguyenthanhn537@gmail.com", null },
                    { "8E48858E-7089-4512-BB79-75AEDC2003D6", 0, "Suối Tiên", new DateTime(1998, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "7be905fe-0438-4871-9c30-503becc0e72d", "vinhttran537@gmail.com", true, "Vinh", "Trần", false, null, "VINHTTRAN537@GMAIL.COM", "VINHTRAN537@GMAIL.COM", "AQAAAAEAACcQAAAAEJoNxNhqhmhT2GaBEkEuavQM7FjJ5u68eEpBZ0pt6+naGnWtSc+r9/+TU7KpPERh/g==", "0123456789", false, "dce73180-d32a-42c6-b43c-ceb17f5665e6", false, "vinhtran537@gmail.com", null },
                    { "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9", 0, "Kon Tum", new DateTime(1998, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "8960e11f-a9ca-47ff-81bd-12d77b1684cd", "anhjenda537@gmail.com", true, "Anh", "Da Đen", false, null, "ANHJENDA537@GMAIL.COM", "ANHJENDA537@GMAIL.COM", "AQAAAAEAACcQAAAAEK99Yl8k7ROCB6Xz3R5jueh+FlpMCt7tuYpeW5E6cLg9Ux6Qp5dCzu4LTEH8pME3qg==", "0123456789", false, "929188bc-bc40-46f4-a43c-23f7643c15a8", false, "anhjenda537@gmail.com", null },
                    { "DB903C85-4C75-428B-A7B0-9B56130F4813", 0, "Đồng Nai", new DateTime(1998, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "75a6d503-44ac-4434-8849-55364562cfa9", "dungho537@gmail.com", true, "Dũng", "Hồ", false, null, "DUNGHO537@GMAIL.COM", "DUNGHO537@GMAIL.COM", "AQAAAAEAACcQAAAAEDsx9KyVOBqgNEStAtHnN/pWof/1yikF6/XsbJX83KKc9hPIF3LVasB8XTeIH5baYw==", "0123456789", false, "95bcdd95-01e0-47d0-9ae4-3b06692cdbb4", false, "dungHo537@gmail.com", null },
                    { "E6DE8827-B7C2-46E9-9227-66E6ECE676A8", 0, "hcm", new DateTime(2010, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "74ce7578-8809-4448-b317-b05e7b2436f2", "enduser@gmail.com", true, "Vi", "EndUser", false, null, "ENDUSER@GMAIL.COM", "ENDUSER@GMAIL.COM", "AQAAAAEAACcQAAAAEBCMQXhnjUtjUQ9SiMQCTLItF8OMFbSKa9lsomz1Xt+D6aR9bby3pUTL0nv0Byx3Bg==", "03030303", false, "122ac3ae-a220-4507-90b3-cdf7db31ede3", false, "enduser@gmail.com", null }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), "Candy", null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4820), false, null, null },
                    { new Guid("39696f0c-2c8a-480f-b917-141b7da708e4"), "Dairy", null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4828), false, null, null },
                    { new Guid("4078ef19-ba53-481d-9c5a-1c37dfe0e0dc"), "Beverages", null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4815), false, null, null },
                    { new Guid("8908ea98-b421-420b-9634-03ed356bb921"), "Chips", null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4822), false, null, null },
                    { new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), "Food", null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4793), false, null, null },
                    { new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"), "Cookies", null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4825), false, null, null },
                    { new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"), "Bread", null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4818), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "ApplyDate", "CreateBy", "Created", "EndTimeService", "IsDelete", "LastModified", "LastModifiedBy", "Priority", "StartTimeService" },
                values: new object[,]
                {
                    { new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), "Thursday", null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5216), new TimeSpan(0, 22, 0, 0, 0), false, null, null, true, new TimeSpan(0, 13, 0, 0, 0) },
                    { new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), "Thursday", null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5223), new TimeSpan(0, 22, 0, 0, 0), false, null, null, false, new TimeSpan(0, 13, 0, 0, 0) },
                    { new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), "Thursday", null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5175), new TimeSpan(0, 13, 0, 0, 0), false, null, null, true, new TimeSpan(0, 6, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "PaymentMethodName" },
                values: new object[,]
                {
                    { new Guid("36672051-5437-4d2c-a42e-c71a9b67a2b1"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5593), false, null, null, "thanh toán trên app MetroPickUp" },
                    { new Guid("47bd4dd4-3fb4-463e-b9b9-5ebfb7e1f960"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5591), false, null, null, "thanh toán qua momo" },
                    { new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5584), false, null, null, "thanh toán tiền mặt" },
                    { new Guid("7db43916-e061-42cb-b0a7-9734423d00cd"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5589), false, null, null, "thanh toán ngân hàng" }
                });

            migrationBuilder.InsertData(
                table: "Route",
                columns: new[] { "Id", "CreateBy", "Created", "FromLocation", "IsDelete", "LastModified", "LastModifiedBy", "ToLocation" },
                values: new object[,]
                {
                    { new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6114), "Quận 1, Tp.Hcm", false, null, null, "Suối Tiên, Đồng Nai" },
                    { new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6122), "Quận Bình Thạnh", false, null, null, "Bến Thành, Quận 1, TP HCM" },
                    { new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6116), "Quận 1, Tp.Hcm", false, null, null, "Quận Thủ Đức, Tp.Hcm" },
                    { new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6120), "Quận 1, Tp.Hcm", false, null, null, "Bến xe Miền Đông" },
                    { new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6118), "Quận 1, Tp.Hcm", false, null, null, "Quận Bình Thạnh, Tp.Hcm" },
                    { new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6107), "Quận 1, Tp.Hcm", false, null, null, "Quận 9, Tp.Hcm" }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StoreCloseTime", "StoreLocation", "StoreName", "StoreOpenTime" },
                values: new object[,]
                {
                    { new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6860), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Số 1, Võ Văn Ngân, Thành Phố Thủ Đức", "Metro PickUp 3", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6876), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Bến Xe Miền Đông", "Metro PickUp 6", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6865), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Khu Công Nghệ Cao Thành Phố Thủ Đức ", "Metro PickUp 4", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6840), false, null, null, new TimeSpan(0, 23, 0, 0, 0), "Số 2, Đường Lê Lai, Quận 1", "Metro PickUp 1", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6854), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Số 3, Vincom, Quận Bình Thạnh", "Metro PickUp 2", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6871), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Suối tiên", "Metro PickUp 5", new TimeSpan(0, 6, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "647D9649-F5A2-4F24-808F-6FC326EC2AA3", "1F11BA64-2870-43F7-BB03-867112867F25" },
                    { "AF5EB4AC-219A-4BC1-99FE-8C23876536EA", "2198E4CD-3305-49C5-B78A-0B54DD76898F" },
                    { "647D9649-F5A2-4F24-808F-6FC326EC2AA3", "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84" },
                    { "647D9649-F5A2-4F24-808F-6FC326EC2AA3", "2E089AF6-3437-4DD6-9956-BB792E783AFB" },
                    { "647D9649-F5A2-4F24-808F-6FC326EC2AA3", "8E48858E-7089-4512-BB79-75AEDC2003D6" },
                    { "647D9649-F5A2-4F24-808F-6FC326EC2AA3", "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9" },
                    { "647D9649-F5A2-4F24-808F-6FC326EC2AA3", "DB903C85-4C75-428B-A7B0-9B56130F4813" },
                    { "CF531396-C1CD-427B-9D17-0383B7675394", "E6DE8827-B7C2-46E9-9227-66E6ECE676A8" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryID", "CreateBy", "Created", "Image", "IsDelete", "LastModified", "LastModifiedBy", "Price", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { new Guid("0c308b93-b26a-4224-9d63-28294711aa15"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5738), "data:image/jpeg;base64,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", false, null, null, 50000.0, "Gà rán giòn tan thơm ngon", "Gà rán" },
                    { new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5778), "data:image/jpeg;base64,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", false, null, null, 65000.0, "Cá chiên giòn rụm", "Cá chiên" },
                    { new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5723), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQFiG13qW4PuAZ3GSDHC7i2oHlcdb5zx1I3Tw&usqp=CAU", false, null, null, 30000.0, "Cơm gà xé thơm ngon", "Cơm gà xé" },
                    { new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5791), "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxMTEhUTExQWFhUXGR0bGBgYGR0dHhsgGB0aHR8fHSAaHSggGx4lHh8XIjEhJSkrLi4uFyAzODMtNygtLisBCgoKDg0OGxAQGy8mICYtLS0tLS0yLS0tMi0vLS0tLS8tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLS0tLf/AABEIALcBEwMBIgACEQEDEQH/xAAbAAACAgMBAAAAAAAAAAAAAAAFBgAEAQMHAv/EADsQAAEDAgUCBAQFAwMEAwEAAAECAxEAIQQFEjFBBlETImFxMoGRoRRCscHRI+HwFVJiBxZygiSS8TP/xAAaAQACAwEBAAAAAAAAAAAAAAADBAABAgUG/8QALxEAAQMCBAQEBgMBAAAAAAAAAQACEQMhBBIxQVFhcfATIoGRobHB0eHxBSMyFP/aAAwDAQACEQMRAD8A46q1S26rCsrhG5k9hVNayd6wArXt1+bCwrRWaxWgqUqVKlWopUqVKiilZpv6IyBt8KdcuEGI4miPUnQHgsLfQsqUDOkC0E8ULxW5sq0GkiVz+sU15l0etnCJxCl+YgEo96p4fp3yBx11CEkSLyZ7RWGYqk8S128eoWjScNQgFejV38HDgEyJFzan/DZE2842NAKUiSflWa+LZSidCi08MXtc6dFzKpFdTxXRbZeQoDQkXPYntWnqPJgpOhlCDO8RIIrLcZTdEboRpkLmNSruY5ctlWlYvVVKCTAuTTYINwhrxNZrbiMOpB0rSUnsa1xVqLFSsxUiqUWKle0pJ2ps6b6WW4PEIsNp29fkPSsudC2xhd0QfKspUsyRamFCAhBUYgdqOYrLtIShsEJPxSOB3jmlXqXGgK8NOyd470s8F7oT9PKwWQvMsZJPrQkmaytUmvFMsYGiElVql55K5h8YUiD5k/7T+3ar2GV+dlV+UHf+FCg9ekqIMgwa0hJibxYWLeVfbg+38Vr0KNDWXwqxgK77A0WwWN/I5/8Abt79x61crJC14hi1UtEUxqwveh2LZCTVkKAoT8qlXdHpUrKtBVKmvFSpVq1KlSpUUUqVZawS1CQKacN0mnQFLmSLXoFXEU6X+ijUqD6hhqFYDK21NqK1gf8AL+KP5BhGEJMQs8qI70GbygnxIUNLYk/MxaiOBYZ8Ato1KfKrQD5h2pat/Y0jMmPCLRma2YWxeXKSFONL0oB1EAwLVYf63fdHhkJCYiq7GX/01SXNW2i+9eMq6XecUFkaEA8727CgiqxrSXu0371QamYkeGL8Fvz3GP4ptDKEkhMFXyotknSKFK1upsEiATz3q80ptAKXCEKBEKokvMkeWDrTyRtSIr5aWWmIHLeeaMylUIDni6BHotK3fOseHuI39qYWUtsoKU7J5mqefYpetH4ZIUnmDHuPeqObPiG0JSdUytP96Xe2pW/06w0AWnvc1pyiTw/StYPMPEcVJBAHwz96X3cpeOKKmVaEkyST+tG8nwCAStUEmwvt3q1iMIy9BQs27Gi0nZCSw20S9VlV7BnbDuHeiScVkTj7jutxI8O57kelUsdlrCEoU05K7H2NNRwzTRxJS4HFlGkJM7nsRzQbLOmS4nUtZTIsIvP8V1BVhrSXRCUqU6hIjXqiS1sYnDo1jW8bSBcRV3LejsOtJTpInc8igOXvNYZ5SFLKgDfRczyKuY/qx3V/8dIQnbzXJ+VKVGV8pbQJveSbd9E+xocAXRKqZ50QltzyOhKCLa/0mls5K4FlJsAYk2/WmfBuur8751lR5/LHsPL2mOaI5HgA66E+Y6VE6pBB9B7CL0/RdVp0oqHMRvHZKhpMmUOyHIkA6lAlKbmRGo7JHzP6U7YJ0BHhJA7W77mO3Fec0JR4TWHS4FJUJUgeVIAM6ioQokHb1qmwnU4E+L4ZGmSlsrUST8KQm2ri/pRWP3U/0OSq57jvBwyzFx5Qe54j2rlTzhJuZ7039f5gk+GwgkhA802kiwJ9d6SaO0boNV50UNYqVK2grNZrFZqKKVYYe3B+VV6lUomLLcwKPKq6ePT29PSr2LTPtS3h3phJ3Gx/aimCxf5FbcHt6e1aaVRC21K3aalayqpSnUqVZawpIkyB7UMkDVaWcHhwuZMRRbLsKyhYUuSn5T8qxlWBlBJMdh/NFXMllsQfMY+/FJVq4DspPJEfQL6ZhaxiU6gEiEz/AJNO2GcQtKdMDSmKTMzyZWGTrUrUrgVey3HDw/ECgCCAb3BO1JYmlLbdFvBeQZHGDz0WzAIadceDeoykgiPWx+tb+mcqUxiA49CEj4dXJPY8GhmU4Z4YoKbSVFZPsZuf5p+zhB8EpWhJV24nis1Kgp+XNYgR9pTlOpUDXNcNzP3HKF7zp1so1JgHitTLTjoToTpSYkmg4S2tIbKpWBx+Ujkjj2oxgs5QEhDqwFFQAiwOkW9valnsa90PNxfuy21rw3M0WWzNstC0aQlOsfCTwe9L3SWUYhKVBwQ2SQDY32NqtYnqB1nFFDo1NK8yVQJSPlxXtPVLU6EqKUE/F6nc96v+wAtiQb2GnrZDZTfVIc2fLI3i/doRdK0YdV0gn735pa6jf0a3EwnUZFMQy5pLfiLVqVpMqneb9+K9DKcK+yhCwFJRdMW+9U1wJaCbawtsqPpy5ovpK51lGEedWhxLkrmQAdvlTph8rxCXUKOhKADqgfFP6VjLMMppxRSgnTuSLhJ2n1imTMFSiZOqOBNYq4qXAxb0VFhjme7rnWZZV+Ec1IClpWorMzvO1qF47PlQoC28ATPt3p+ykvuMKeUCbnSEgCQm0pkyZ/a1Zw2WJaQpxCEh9QK4VBNryOxvTlOq1zr3I1g3kcVzKuCNN5qTF7hLHTvTrTzZVqKXCJKT2N7zsfbvWtWUoQ5CjIAkwD5SNk+aJ96dsofe1gOMCT8Tggbfr8qt9RsKdYWlKfMYEwCYm8fejnFQb6d8kzSeXjMN+NvgkYnUsJ8MIE3NyVc3BIBtatmKzK6lBIQSrypbSGkgWgaBtO+533qxmOUEQXErShCZKyoaiSISE7wAQJtsYqlj8ZpICG2loSjRq06gSoXWNYBBBmFEWNMipmAy3B3tb4z7St2W1zP1eZCEoAH5tRP2/wA2rexiFqDZhPhphMDck3AEckmTQNKEkqKCUpA8oURMmyZMAWFyYo1k6xh8O8pSik+GokBaQbJmASDuYtua3TZJUcQwWSk9jG3sa4p1AIPltO6RGozyY+9A84w4Q4Qn4TtW9lEAKJud/nWx7ClYPNa8SHTsgFkhA6lO+O6ZDeHSoiFahfuDQ97ptRUi8BW6u1U3FUzrZZqU8iWazTFm/ToZQVhRI4JtNL1Fp1W1BLShBwKxUqVK2rWav4ZzUL/EPuP5qhXttUEEVFEZbxJgc1KopWn/AAVKuVFrwjaQQpRBFW15j5oSBHrWjDNSIVtRvJMgUVJcW2XGgoakixINhB5uRStV7BJemxQqAAi0+6p4nGeWE2kUZyzA4tELCVlNtxtPMb0b/wC2AEkNswdYUoruQEmQlJ7TuaZ8kzH8SfDAgj4trR965lfEOhraLJnWdkR1JhObMRCSl5K8+6BqIST8SjMcG1EEZKz+GU2nSssrV4puJnkHni1MfUBRhEFwAlRBCRcyeJ7XIofkmVqRh0CxLwOon/cqZnvH7UrWxFZoMiII/JkbcOZ9FqnRaXR309YPoEP6Yy4tvtuJcJbv5SdpEU441ttZUVKEEQUjvQPG9OpYZlDykFPxG0Rz7RvW7p5SHWiEr1EE+bvPPrS76/itL23APDv7lNeHSB8thw6nZbk5dhUklKYJHmINzQsZMgMrdbQX3gqGpsEbGTcCQOfajeEy9WoFURJ+gj97R6VZfxrcltKhq7c/StUaz2EvIWK4jyMeYSe300uFO4lw6yIABmPf+1KeKwpQopIv+tPWaYDGLcAQBoF5UYHNj3Hyqhl/UqMRrwz7aWVgwj5flPqDf1p6lUcQXbRpw79VnDYwYf8ArixO/wBCgGHxi0oIUs7EIBOxP7U8dKp0MNrUFKkaZjczt7T3oBhcgLrrTjmlKASCInUE3mdoP6V0TAOI0aG4CBaB7Uti6lJrZcY3te/dysvrVKlQmBl77/S9497whKlp824Tf61rbGoEWgi49+KEdUZWgsOr1rC0oJT5rSkTBG1/3pU6Mzt5X9LzK51kiEgnmd/ag0nCow1aegOhNxPM8f0rayQU/wCJeShICYCR5UgeloAH6UHOTFa/EWFJmdlHVBAt6C1xber+WqaBKWUpPhWJmSFK8x+Zm59as4jxCmUFIVfeeRb7xQaFA0XSy8/L6qOdLYKUcVmL+FdW22gFBAKC4SQnuO6hzHrRPo3M38QhZcKfKsgQImwJG/BNK7+CxaNCXjqWbSCVSSfWL3iKt5JmZwraTulckGwkixNtqexAqGkfDjNsfnr9ggOr0WEBxiy39WOYtCwlakqaVMEJg+iDB43nmKot5sMGpSX2x5wDKdJtxZNo39Zo2MUvHNKQE2UDBVFjwRHrShlWDdGMKcQnVoOlU3CgoKuCfQfetYOoXMNOpq3UDv0S1elV8ZrmO8p22/MpqTgWnU+I22LkSSIjkFIn9ufnSx1Ti21NLabKdfiBMBOmNX6giZ9hTP1FjWVMuMlWiUeVSdzNoI+X0Nc1butPmKgFKJPFvKK6OFe4tJzTAP4+yYqiTpC25dgNUhc9vpTPkmWBDvlSpQIABO08ivORuR+T/wBo+9F8lxelxS0wWtAMm3mk2A9qTxGIqXy+2yIGNiFv6lwphtK0rSgqAKgnVpmwEDuYE1pzrJQ0ydKleVPJ7UVPUy/xDSQ0pSJlRiQB8tzXvqtxC23CkJBggdjq4oNGo5zAXxM/Dj9I+SFUph1naLlmIRisUAhCVLSD8XHzNB8xy5xhWhwCfQyL+1GlOLaTCVKCdvKowPpXpTOOxAAQ0ooAAAKfi9SVb+9dqi6LNjKlhSY2mCxwd0StFZp/6X6LafUtt/xGnkpnRIjzbKkcelLnVGVN4Z0toUSUjzA8H0PNHFQFZc0t1QSpWJr2K2qXvURaRbsalealUor2COoxXV+m3v6aG0pIEQoiLRc39freuff9t+GhTheulJMBPb1n9qc/+nuEdCSSStKxqAPaIn52rlYvI9ubNYde9F021HFmVwum13FJSla3CG0pSZJO+wE+m9JuVvut4tb2HUgtu3UCnhNpTAmZm3rW3N+nX3sQA44pTR3vGmAYgG29vma99MZerDOuJWUkR5TO/rHeP1pHx2speJTdJj6/Mao3/OwiSb2P0TRj2PxA84CYTCYnynea04rGKENpgAXHrO5Fa3cYrx0oTIkeb0md+BWjNRCAtQ0mdNjJIPPoOaRLqlXzO3179EagGMcA64VDOcekNqDiydQiJ31WitEKwqC8l2QnykTYjsBskjg1szzLmwGkKISVGAVckwPtV7NspslGkqZShOof7lJJIJIvMwd6aw7WtZO2/wCIQ8VVZUf5VoxvUSmky2NZ0kgep/yaEdN+JinziijQhJA1KO5gpITa5E7+oFHjkS0tpU2hK1SdQJGyrjSo7EfpWzAY1brjrKQW0sgAqESVESRtHef71dHwwHMacxFtdNilajC5wdoFV67xB/DFLaiCFASDb/2Hbf0mK5pgdCXUh9DhgzDY8yh2/vTLmL6hiUKCfN+YQYWBEH1/YgUby7GtIxRSpIC1kESRPmSmQTxebU7QPhtyka36beyVqU8zsx6X337CHZt1g2434TUotAiQpA2JJtfiOKaulMB4DAcddXrcGrTbaJFomdPNDuocjaVp0oAA1KtMydyO+53pXxOKejRrVA4BVsPSYiKEDRqgtieM/Dh3ddShhKlUZpATBiEO4zWNag3aEpEFfeT29ooaOk3sLqdaUpayP6bYt76+DE2HeqOV5ziEvAocUoxGkmQYsPpTHg+qtKkqfI8widrz6cVAzwRkbodo+dp2SVfEZKxouMHl8L9CqOSspwTRxLylfiXQU6Cfh80yQL8CfpTBlGJxLjUrEKCZTNtXIHoTVt/JWHXA86dWm4TYAf8AlG97x71txeNZbjUtKZB34A5txE0Gu41CNJ67bAR6diVmk3KTw2HzniUHfdXi/FbDZQ40RBVG5AVAIJEnv7Ui5i8sKCCkgptB4966ZluNS8CtuRb4o3+vb96A47KHMU669qQnwoBixVA5BBvEHYTFuaIyq0Elw9/isOwbajr69ws5RjCxh2ENpT4rlvNJSLKMkDmwEevyoVmWauPP+BZtYUnzEGASDNomLi9aMDn2HWtAUXVugKI+FKJA4CbweN6v4vMSVNYhTKAoOoSpe506wd4naa08eGZLfNeNpJ+8R6ojmFzfKY0vrolzM8vU0tKny4tM7q1BKwLGJi3tRlsNl4LCG0tqb8vhpA1bRPB4+9NHWOFZxqW2vEIOvVKCLSIMzS0roR9GlLbwUzuk/mBvbgET+tXRqjEU5mNeOiVNCqxpaXTOkrXiMQlD1wFIIgj3H3vTVk+Dwy2hpHG0mBztSQ90njCpRsUJVEkxI31RcwPT5TRTpHFlC3ErPmRIieRz6gRWa+H8oa13VN4SjkoEuNx3CbMdiNA0pA1Ecf59qWsfgXUspWNSinzuSdp4+VVup871CA4pKwAU6RHPP8Uw5Vq8EeP8RBKhsLxb6fqaXa0025jppfkpVy1AafulfFIXjFANphP51cJ/z96O4PFpS4cMuUlIGhWrzWjfuDWpePYwQVCSEKMp03JO3PAF6q/9snGq8dDoSkwdW9uIHfejiqGC9mXvr8v2gU6WSQILrcu/kiWEel4oKktqUSdSdyBb+KGO5awhalLQCZspVyZNifWjJyhrDy4SpRsCpZkx2Hp6UBzdl3FKOhSfDAgrNtidhyaDRd4jiWuMacuJ99uifGVolw2J5zsk7rDDsoe/pHcSpMbE9vft6UDSaM9VMKQtIUZtY/SgYNehoHNTaZXLcZOkLfNStc1KJCqV0nGZY6pfhITLa5TP5tMCSeBuR9Kfcly9rBNpTrOtSQAFKtCZsJ2tx/FKuRZpi1IkJCUKJhQIkxwYvTOhgLbOsEpVZSvSQTte/pXnjWLfK/Xjt1687cV0XNBhL2adNLcxC3BinElZkJQo2sPtAq3mLbOFCSZJA+JSifmZNWs2zlDK20NIBQgDUvhINglJ5Vz8voG6tDeLY1NmHE30qtrA4BmARv8AX3Cr2vdVY1x8ulvrHorY5rTlFnHb5dBPJYwnWDa1LSZSIMWso2Anme3pQb/VApKoBW7uCDIA7AbzNAG0KbBlNiCO9vSNqcul8UyjDBKSS4syoWABNrmNoA2rpOo02320Qcfg5ptzPvPofTlxKIZ3hxjctCiA0+0NQ1GL7EEn/dAjsYpky5xDrIA1aVoEiTI1DuLyDzWrL8iDjKVLKVgkKiJHlmPcc/SrWJeS2UgAyohI0ifaZ4pSti2Zg2YIm19PltzjRbpU5BIvKt5c8kIIV5dNhNrfP5UkYbN0oU98R1OLmEk2Fge1MPUrc4dzUJUEki8R627bxzFL2X5e2keK7rBIgJNuJkD1sZpOg2mBIdYT8bpoNOUujVBcc4268ghC1aTZMESVRAtc7gxSx1Ml1LqUuJKVAciJ9uCBXRMficOwA8pEr8NJQlQN1kmO23PI+lKGc5ipxlSXgTJ1Se5skp/29u1dnDvkhwvt36oVTBvq0nEQAOO8a/vj7q/lPUWsstjV5YEq3Ii8zvz9KcsMyy2sqCASQUn1B3pT6LyVpfhrlStJ1CSmx/2meOePvTmrCwNQKRBmCCbfIi/pSOJBY/8AqF9yffdaw9SWltU25T8e+aTeuX0Orb/Do0uDyLMgeUAkbdj+tbv+nGU63nPxCdWlEJvIEmDtz+00DzPHB/FFWDZJ2kK28pmY/KD6n6V4yTFOqxKAlS2UqN1pB235EH510mNcB5o58f0uK+HYnMweWbG5Th11mCmXGmUghBRqKUyQTqI8x3iPXmlYYh14rOklK/KrSUz6R22iPU2ol1JiG3FEFS3FJOjxCRMJJ8ogREzJ3NAcIFsOamyS2q2kETzAv68i9ChrgSBB2kfm3Louq6hWoxUM5dxPHiImON97Inj+rF4dCcOwgpcPmK1AGJ2AT3tufp2NZT1KFJKXAUuLEKJtq32+poVi8QUo/GhgBSfKBYkzyAbwCBwLKJHrrzzOmn2yFNqTqTYtiCTHrED0rJp06lMNLZ2Jtr+Fhr3ElzeqoJ6faaeU4FK8NsyCb2AvMCd5+VFcgVhcS+dSQUISXDJIjw+YtwU70Q6GBVqLoAgwgE3UCPNKTxPP+Hz13iW2EgJbSVKsDsUjcwofEk28u1W15c+HGXaC6I4D/IsOnx9lcy/qhDiiwGQhJPkjn/y9ef8ALlsNj1qcWklJCU2RESfU/b51yXC4t1xf9NG3mJAJ0gXJMcCmfFKeWs4lgKUiBdIPYzYSoiLTAF6K+m4aph9Og939RgR8fXirOYZpjFtjFMaktFPlQdJNz8RF5JtHtPNLWBxp8Q6hCwCF+tG8e6s4RAaOlEaYj4Y2+kGheQZekBarShOolQJkXtbbbmhtc1zCSOXPhcpd+FqU3BwGmvCDt3oiasFqUl+ZAAhMAbD/AA0WzTPQGob+Mi8i6O8zsfSuev490kquOJTOm3ajvSjzjzwaUsEO2USZIAud/arfhy1mZxmPoubVruuKYgkoE+tQstalX3J79qcFYTXhkuB5TCmxpSQpSRabQk3vHrT8/lmDwzKk6EwRcqgqJ9/2pJzFKfC8TwpMyBtqA5txuaWdi/FflAiDHL1Gnz1TNGjkZmqXnU9OCDnMX3GiFuqIFuSogcmo31IWm9BRqMWvAt8qE4zGLWvVAE2ECBbb1PvVvFZWFR/WQo6RCE3JKu33/wANONpMaLiBy/CUc/EBxqOnJ3FvVazkWIxoS8NCQZgX2FK7+HUhakKEKSSCDxFdp6dwi0sQsJBSI3gH0E0g9c5UtL5eCDpUJUReItJ7UXC4oF2S0bcBylGcy0pS0GpW+KzT2ZDhdJ6LYWrCXlJEqTbcKJvf2pwyzElDYClSRM9+8GqmExY0IgJQdI8siB6W7UQ/DtupBiZ52nn515fE0vGe4aXnv3XRpkMaARZLHVR8RJ0/lUFFMRNokf53pUxucLmbAAAAADj2G/rXVMA2gqAWCTEp2gREUL6g6fYUJU2gIbVq7BUkH8sT2vR6LmU2AG45a+qUrYXxa2eY72SdlOS/ibh6J2ARaTuJmPt+la8TkOLw76cMyVQqAFpRMxEySNKQBTvjMxw7DQKUKuoKARsCL+kWHzo3g8e2tAeTcLiI+g9qMMS4eY/5+Hy1CZrHxTlJuPfuyqPZm5hWk+IhWjZR3gd7bcUFzfEOvhp3DmEFR8/aLTpO4mR8qasPiy7qmBpMQDPHNL/VmfjDiA2parfCR9b0t/zse4VG+k6cNPzfgtteWWi+6Cfj3FOeHi1BI1JnTcKHIIEkA2se9Nf+psOEpDqYR8VwdIiRI9RXLV574oVGiFGedf682+lWcqbfckJSsgxrCR+XUCL7A25or8IA2IA5d/SJ4hYwlapiKpa6wGh/du43RjrTwnlJfQ4khMJKUmDFzKbb96ZejMvQ2wVuELWoAOJMHSALII9uOa1YHJcM0CtKFKkRC7kE7iO/8VnIsGkFx8f/ANEgixMEAnygCxP9qHRxjGf1tFhYd8rro13TSyNJjnE9O/ogq8pU0tS2miyw4qSATa8CRujiw+1DsdmqEOJLRXpAEpUo7g32O0U5v5w04laW32lJLagUyNWo7WJ23tFI+XZC47JSm3eN/atCpTcXF5nSZWf43DUi51aoRAgDSBrPfrwhrZYaWkKZCUeJJVAvPMjkk2ovkbZSyJG/ahKHDgGUFUKSTBngmbW+f2ohl+cfiCAgjSlXnPyP67Uo+iCILdZiR7EzbRLVMocQw224x80s9ZdLBA8VgKKrqcANouSR29qtZd0gg4ROokPK82rfTIgJ9o5F5v6U0YhSFatZVCoGkAEHgg2Nqxg8vWlRAU4W/wAqVpTCeISUwQPQjnfimsLX/rjNmA33joB2EWtWqloY6ySMB0egFQeQSAYkqN5FjYirTuUJcdSgIChO+wBuO+/t3ozmjyMOgreJ8Rw3SFf7eEjYgCL+tD+ncfh3VHxHtNyQg+Um52UDfiwg1T/EqOBbMc57+yBRNCmS0kA8AO79Sr+DyVDav6h7BIAKY0juDJJ3JFWsX041iloLidSUTAmxnv3j96uYjMG17QUiQqdxHpx+t6yxiySlSSRwlIFog7/KgVnxIYb8RY+/TTdWA7Upezlk4QBLKUgrIQFHZIJvPyrCyhrDKS06JAPmEGCeSBxNWs6yl/ENFwCCCVeGd1ESLEGBzHe21IWDSvFOhpEAmxAHwgWKlc83qsM0122fpr+ePymegXr4o0ajWGnIOp+21uaYem8hUtpaMSQoKhQKSZGqTMkC817z3EYbBlTKYSsp1FASQFcT2EgbUxDCjDYZDQJXxOxMc22HEUvo6Zw63UrU2oKJ8wUtS9QUCJvJtuLzIFO+IwuIebcrapk1HONySPslbJ82TrUlSErQs3SsAAajf0getH8o6fZU005hxBKpK91IKTeYPlHoe471ex/QLa20+A4WikEHUkq1zsVXEGb2Hyqx05gE4ZoNJEK+J0zuuACJ7Db5etEOJoukMdfSO9fikhSfnJ2vEqpjsZhk4qCtbqgC2oqMoB79pm1q15tKII0nsCkc8pHek3FwFqSo3ClTG25qw45LaYJCwITcRc7nVxv9Kw+hDg5pgdLabcO/XtPo06TMxuN9/wBIU68pSiVKm5IsBHyp+6UyhmPxMJWSkJFo0kWPsTyf5pJwDQ1SpQM8/O+9HcxxRw5KWHvJAJ0yEkkdtvtTVZziMrLd9/ZcXEfydBh8NgkcQR9d+duSfHn2hupAneFWH1sOa5tnGPdxCnWmwkalFJUTCYmBBO+r968YrNfEZSmAIUSYtfb+T/7GgzzkXB/z51KVITLhunW4fMwOBiR89FWewLjaihQTKbHzVKrYrGKKiSo/4KldKCuYQQYsmLpfGOFwKRqcX/yNhNrzxeuo5QpxSEpcUA4ZUdGwvEAna0eu9ccVg3mB4gnSbSD+scV0/ofNJwzSNK5hQJUOQb+29q42PGVudgkTFu/km6by45TsN0wYNAQ4Qm5A3PrWc1fDSR4gSpMydQkD1qk+oMqS9HlUfOexFv0/SrOauJxTKy3sLe/8b1xstUubFgLx119hGqbAEgnTivGHcQ4gENBTapAUAIgeh7EduKFdN4NWHbU0HCtZUYJEJSJ7Hk7n3rVjeqUYUJw7bUluxkwNptvO9L+JzF994ONWj8pNha9+acDK5lpgN1BMa/TqiOwrg3xC39dJlOWOx68MFaEoJWrURJsYAO31+dLmbPuPKDjiAm0DcA+0+/2om1g4YU9iifKCvSCBYCwkE79vaqWE6sGLCEhARoUNSZJ1AfDB9Df5etFHiCne4Hsue5lV1SWOgdNTznZNGWZPgEpQr8M0HNIN0+aSLxInv9asDDBClKQiygAeAImLfOvKsYW0FS0gbAaTcyYueK9Z5j1M4NT4TMXKeYJAHznihwC8ECTHw9Tr8kQAgdV5wmIAc8Nfx6SuyYAExvsf7Gkzo7FYr8SttbS22Uy4oKkyVfDpk2nfy28vzoXievYxIUW1BvSAsKEKBVMkXuPemrpzHOOwXC2ptwqSlESrRFiq/pEQBBpo0nMbBbrufwb/ABWQ6Zg9Vez7K8OtkuqaQYE3SJvtcXHFZ6ZwYZTF0IV5o1KPaPj2HpNXc9wbjqCGnNBAukiQoDb9OK85ajxGwl3UlS20zwbbwOL0jWpuccrXETzt68JR2hmWSBPS6G9T4gOpDKUySpMEAmD3ITcx+sVYyvLW8Kgaj5jZZmAd+ON6s5BliG1OKEKkylQ7QOO8zQnHvKxDhRt84+9Bax9Jopt/z3PvwUFGm+rni4Gq85jmrRdQ22ozMqMiIvtTJhsUEDYEHuf70n5d0gpDqlvLSoR5EoJ53J22G0b1YdLiiNBgdz78WrdVmQgUz6pyaTzDiSAiOZ5iy4oNPNJUCYkCb8Wie+3ehOKyjL8OpS3F+GSqAgq8p2Isf/y1bs2xP4XDqdgKIvM7zYff9a5bin3MQ9qdUSpV1K7De3Ydqew1CpVaZcWganj8klXbSLvK2eC6eMUyFSI0KWApRNpMWnb1j1pya2MCwGw+1JORqYVhwx4Z0kRpFyT/ADsZrDmKewYQnxNQUSIXPuBIV2/SkfBYXCZkadxr66cVrEE0m3HXufonfLsW6G9LiQDyQd/4mhmGweGS4pxDaELXMrSACZMm/qb/ACqjgMYp1lTzhCEiZE/7d6Af66wVo8QqCG5IIEgqg7je024miU6dUeVjYHvb7eqjaXiSRc8kdzbGJSUBIW4UnSRyZtJ2+tWnsqcguNOALBSRIJEfmn5Ex7UtN5olbgAhtd9XjAi1ikye+9MuEfIaUtLgcSUmPDSVT7QSFGe3NWKbpzFqqp5LLWrNSp5GHAOpXI2CbkqPsAbd4onmGDsnwzYESFSbc33JP70v4HCFvViwlSnfD0hCgAY+K0gEEmN5q011FGgrGnWjWlJN77Ce/vSzaTmHyjyxfe/Ply99lTnC0a9+iB4/I8K0pT69UlUhFok/lgjk99hSpjsKXHC+AWlfk0kgDT2+c/U1nM+q3nHFJfATckWujeBbcDvWl3OdUfmAtz9AK7VJldok68Rw717J5ONxNSq4NBMfX2RoZI29hfGSpRfG4myiDdJ9D33vVvJ8kw7zqFL1BAuUEkz2Bm8UU6ZyYBjxHZClGQPfuK05j1KptJWG0lEwN5t67drRzSjKtUVIFxMj7fbRMPGGYxucQbbb7qZ/lGBC/KkJJ30GAI9Bbb0pazPJGEqbjWpK1RBsNp4+tMGEz1CCohCf6pELcEgJiSRHy2/tQTPc1vCHCocyP8IpmXuqSwm+2yMca2mfBdO33QV7KcOFEaT/APY1mhjmKJJqV0xRqAf7PusGu3Zg9k44XFoUnSuCDY9qc8udQpIGqYEVx3AY0oMK2poy3MxI+VczEYZ1IyLhHpOFURun/NkJUypI7SfQ9z861ozBPhFKABCSUp2kx39TzVPCZw2AorEJVaCNxtP60NxWKRh3VNlUiykjkpM2NJNzkSB6cluq5tOk4mZGi1ZplH4nw3FLQh1UBYTcduSLivGXZMrC4lGtQU2q4ULXGwI70Nz7GpU4HUgpJVqANgL2juAKHdTZkVPhaF6oAMpJI+XaaeYxzhlGnwslqf8AK1CwtOmnoeG9l0nO/DWwQogtqBkHaBefSlPE9NpZQziMM4dOkFd9WqYII9PSltHUC1oSxqgAm5mwPfv7V0HppWplDe8fDIsRuKzWz0W5Tvt3a63Se0ukbIlhsI+8hKnIQnSQpJF/Q+h9OKIf0w14RlQSZ8xm4OqPXix7Cqi85AQpCvI4oEhJuZ9BzSW947hUUmFlQJAVEnsRbtXNw5JJkRffhP0Tgp57TCp9TvpexJd0p2Gk+g29jPHFaMrxCkPIUk37+9j9prdhMhdW4kKadSlYuSJGr/cZiEkfenTKenmMMNaocP8AuVFoEmOBzXRqVGsblmbd9hdP/po0aeUC8RbfqfvdFMFjFFsm2pN6HZ+jWUuBbh0gnS2qJ9yIPfmtucYwKUhH5Zt2Pr6x+9DMlxq1uFtXmTwY/WBtXPm1jIHx+PcbLjh+V4EQTJ9O/ZFXsvdRhUrZ8oWnVpTJUkqvMk/U95vekZ3GusukpcGofFPMia6atshI0kJjcm1h/eK5BnYV+IdPxDWfNwfY05Sa17jAi2972+fCydwTg5xD792TTlPUyVOI1phcwI2M2t+sGiPUOZBoJJA0g7J3PeO03rmilFMEWIvRhDWLxC22tKwlc/1NJiAJn+Pet/8AIGxlsN+/opiqTGOzaI21nDeKUEgaQfKlKlADV3USYoc3kLzrzrCQgKbUQtUQm3YxvVjP8Kw24wFgJQlPmSiylept3Heb0fyrNw9pThx5J8xO47mO5PNYeS0ZqY147GbfI2suCyhNcvc64Mi+3f1WelMkVh1KCyCsD4pmZ4+Xf2pa6ty3FOB3EuEISyQG2+VJm6yQbd4jYU7O4Ut6SFrUtRgkJsAeT2G1UMWxiFgoUEmTeVbx6duayyo9rgSLiel+/snqjRU1NiveWNNu4VCHAtaClOqDpmw307ifrFBesczRh/AQhlspT5kkzKSiI2Nxe455qvisStjS0PKgH8qrgfX6TWt9Bxra2wr+oiFN6gO45An0PvWqALYn/PYlCq1mhwY18OWzpvMG8a65+IQ2FqSBKRAUNoVJMmLU5ZW6hCVYdq5bMBNjHMTwm/yqhkvTaW0BSnASONNrb1XXmbWGK9DdiZKkj4jFhMXoJrte8hkieumm6PTpEi5kjc2TNjnUBMqk9wPT2vQ3McE2rQsi6NibTYwk+k3+VIX+rYrEPakeJYyEtgkD37/OnnDp1IbW4CVaBPvAkkbAzV1WOAIJANpH51RX0PDglKHVmUF1xDykAI/NpN/QG1gTQjFoQ2FIUghVom0fKL8V0p9M6fKD5haOJufsPelPrDDeI62HAQhMgHbVqiBPAsa3hqotTcdNBP59Fxv5DDZpqk2HK3f29hfTma4hctNqkDabx3uTxI+tWM1yN8IIBSpAvqmIHcg/tW/IciKnSWgEJb/MiSFXvBG/v7UZzVLSElL/AJgRcEki3odjRJYK3lETy36xBPC6tlMVqLc4NtO+CBv5GGsMXHFrlCYQDYGffikzF4idtqMdTdQqfOkGG02ApTxL3Arr0KOUSdVTmtL80XhejivSs1TqU0orbL0+VW3eiGAxamVBQuKCirbDqkmDtyDWXNDhB0VgkXC6ZlOftOohcGL37ijmEZafcD6gCUCE9t5muStNkjU3I9KNZP1QtoaFbRFcnE4GoB/SZ5d3TVOs0/6snbrLDB5CQEalC6LWMcexoZ1llWpht4JCSgBKo2I/saK9J45D6SpSgSLBJO1EeoMQx4JZcIGuwE3J4j50pSc+l/vieK1UptqCAuVZPk/j4hKNQCSZWZvA7V1XBZC3qbcSpf8ATNrjbbaLiguU9OpYaK1tiViD/wAf4pjyR1RJGslIgRG3z5rGLxGao25gd98rIlHCltIk3vEoN1Hlzysay42glCQNSrQIJ/aii8nS4sOQk3k22iiuIaWkjSCsrMR2P7CqWEC2p8QbqNgZ3pd9bzNa6x/PxsbwtU6eWS3f9Ktgs5aZdLUKUBsqZEm8X2FX8W0y+3K9p+AWJPAtQjMMgCllxKlbglPFV8LjQHUp7G/pFDrNIcCNRf8AKdpUKdWmTN91u6kX4CG1KhKAdMRcCLGe1qScR1U54wGGOgSIgRqP/L/j6V1HHMlxJIUnQoW1CbGlTFdDpS0VYIeewJWq3rE/tTdE0aUmp6Eke5+c8FzKzHvgA9Y1QbPuqHfxISlUgJAjgk/F9/0o1gMgTig2orIE+ZFj6fIxN/WsYT/p60lEuOOKfj45gA+g7e9XemMoeakl5KibERAEfO9RuIw9Q/1aixtE8x+VKYq0yZNj6wjLeQMAglCSUCBIG3r3qrmubt4cg97Wq+VKkQSomxOwHtQv/QfE8ZKvhXBQomdKh+233pNlN7sTmLunThwR3vOTihbTSMQ8taihYKBCSNRFzafyn09a0/jGMAFL8FxKiLCDp9L7TRHJW/AadQ0zLqbq8wIWs23Nx3pMzlWYvuEKQsBCtk2A9jN7c106bSTlBtzMJQaguF+X3Rr/ALiexWlKP6ZInSD89zQnGZ+6kEJUSuCAZJPyrGNwpTC0hWqJKdiD6UMyzAOuuzpIAN9prbWMcMztOfySdOlif+mbxPpHTROXTWRobZ8ZxRcWU+JcXBIvO8mgXTZWvFMqbS4CSdStJ0gb+bgCibuaLw+khJ7XBAMbimTKsYkgKSiNQncWJ433oHiGCXjXvTp8l0a2EY14I69UwOK+9Bc8wzYZWSlKlJBKUHbVuPvW5OPcAWpaBpHwmRfvPakrF9SFby5gITOlI54N4pZlE5y9l51B29uxfe6ZYwvGXsrHTWehltaCAkRqKwLydwQPW1Hemsc46EqJPhuAhA3j/wAiLCd/SkDEY0nUEgJSVTAHb13pl6JxbgcU2tCilzziLQU7qAMSkxeOfenX4SmS5xFz2UR2Gq0qd4Mdj4JlYxXgq8JawpRkjuIgEevvQjrRhx3CLcTPkhQgTIBvRLP8C0CFmykkmZsZ4NLuc9ZkN+GiJiCRSmGww8bMwSR7TzPCFh8Op+YgA6/rdHcizD8Bg/8A5CA2okqSgLCyZA5Gx9K5z1JnysQ4pZJCSbJ7UPx+YqWZWomNqEuuk16WnSDQJ+8LkuI0Gi2PYibCq1ZrzRllZqVKlRRQGieXkOOJDkQNz3oXW1C4/wA7VIUXUM5wuDGFQrDEFceb0pBU8CbivX+p/wBPSLHmqMd7etVqoimGeW2dTSyPSa9YvHl1xK3JBTH25oSVkXFWEYk2ChINYLATcLTXFui6rkmeB1CW1Oaiqyh2ply3DFsG4IJke1cPbEeZCik0ay/q7FNRJ1AVxMV/FVSZoO9CnaeLEZXbrsGKzQIIi8bjkUOxOOS+42hJsTMjsL0nM9ctKkqRpURcjmiWUZs3oSUHn4Zg0hXwlUVA+q0mPZM0XU3CGkSmfMMWAkJAkqUE+w7mguc5e0XmkpXCpGoDtM396v4jGtyVAE283YczSlnecMrcS4krKgIgWFFZmc82k8ROnyvoUShTeT5OyujFafgTG23pVPGYoglKBJF4FDMCw54CPDMa/MSTJvferOHxKEKKFKBdIuE9qFXY5580gb/bmgBuXS57ul7E9bpEpKVJUDdMbx61nKc2Uf6igUJmYO8VZznpvCrWHFApJ3hUTS/jMyDKlIAkdzff3oow9LKBTF9943sg4zFto08zRf4J7ZzNt6Eg+YkaY9KJ4xIUAg2B3iuYdHYlS8Wnsm5/SnvMMUrxUpbGo8zwDW6tPIDNyYH1QMLVdVYCRGvRXsPhEN2QAkf59aX8S0/4hSVNlJuFCZ9oo0w4GUqLit7yo0nY1b2OxIXhD/TagFRMJUdyB3rJDcsvMR8P3smZdeBKIY/CohLbiilxROhVjMd6oYLIXG31urB0wIULp9+80zYbBAOIU6mVQb8e1XMyxcDSBEg34EUs/GHRgnb09PvsiNbeEr5hlbzq0piGBJJi/mgk+9WMnyfDhvQ2C4kEyTMwSfrFFMK/I85MFKrE22qv0xmWHaw5WV+YEhUnaNgB2vTVDzwZgbi3psTvZU8WXjF9PlchD2hM2Akx3FzFBXOimhGlbhUPimL9+Of3oxmnVGETK9ZlV4SefbvSZmvXCyoeD5QDPvRxhMTmPhmx6D6fOVjxw3UqtmWQraUbHTxII/8A2rOW9U+AmFDWUJ0t/wDEcj9KXc06heeP9Rwn0G1CS7XQZgy5sVjPT7qq38g97coHrujmc9ROvk6lW7CgL+J7Vqde7VpNOsY1ghogJAkkyVFGalSsE1tUpWKzUqKLFSpUqKKVkVKlRRbAa3JFqlSoorGXtguAHamrq3pc4Vtl/wDI4YieSNX6A1mpQXOIqALYAyylwotVdxRFSpRVhaQ/3ra3iY2JHtUqVCoiLGcvAEBZg7g1gY88ipUoZpsOoRW1qjP8khNuWdceGyGtOwgGqrufI1eInVrO5qVKC/B0nXIRGYmo0yDqrWDzJC1anFKUT3oPjcIhx4lKzpnYjipUpVtBrHEtQWuJ/wBXniizLjeHUl1olN4ULyR70VyvHgurfW4oA/CkDtUqVnwGmJTAeQLK9n/UTC2FIuTxbtQXJet/CGhTadP/ABEVKlX/AMFGsIqCVjxXtIAK9Y3r8FwKCTA4qpievnCSQkX4qVKYofx9Cm0ABYdXeUExnU77m6ooNiMyUd1GpUpllNjdAFgvcRcqkvF1qU6o1KlFWVJivClzUqVSi8ipUqVaixWKlSoosmsVKlRRSpUqVFF//9k=", false, null, null, 25000.0, "Cơm chiên dương châu thơm ngon", "Cơm chiên dương châu" },
                    { new Guid("45da4260-ba13-489b-995a-1f6adb13ab75"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5702), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTQ1CiVzQfbq7gt3J-p1KhWpGtPGkfIqt6urQ&usqp=CAU", false, null, null, 5000.5, "Kẹo thơm ngon được tạo ra từ các loại đường, được làm nóng và tạo nên hương vị ngọt ngào", "Keo bông gòn" },
                    { new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5788), "data:image/jpeg;base64,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", false, null, null, 80000.0, "Gà nướng thơm phức", "Gà nướng" },
                    { new Guid("4ecd72e3-f43d-490f-8b46-8e92ea29f85c"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5732), "data:image/jpeg;base64,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", false, null, null, 15000.0, "Kẹo dâu tây thơm ngon", "Kẹo dâu" },
                    { new Guid("55265d3b-fa02-4e09-84db-d4e8c8a9a9b5"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5781), "data:image/jpeg;base64,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", false, null, null, 5000.0, "Kẹo bạc hà mát lạnh", "Kẹo bạc hà" },
                    { new Guid("6d60bf44-b775-4d87-bb47-aace85d49ac4"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5720), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8-8BIO05l5p1gp2W5sgCgVLLr1YG6dt4gvw&usqp=CAU", false, null, null, 2500.0, "Kẹo dẻo mềm, đàn hồi", "Kẹo dẻo" },
                    { new Guid("7d661a30-e180-498c-9a77-cb6112a7cb22"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5710), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRgRlQzLWTXBOHfbDD7NnZleCaXH0xyMjPdQQ&usqp=CAU", false, null, null, 3000.0, "Kẹo lạc thơm ngon, giòn tan", "Kẹo lạc" },
                    { new Guid("7da34092-5747-42b7-b059-4a5aad57e740"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5713), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT4WKJkaumJIGoZ2SdHjV_gOlqBc1BRCgacPQ&usqp=CAU", false, null, null, 3000.0, "Kẹo lạc thơm ngon, giòn tan", "Kẹo chup" },
                    { new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c"), new Guid("8908ea98-b421-420b-9634-03ed356bb921"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5717), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRpRAbsGA5D_jgmxTY9otP9w2G5HGypodYuSA&usqp=CAU", false, null, null, 10000.0, "Khoai tây chiên giòn tan", "Khoai tây chiên" },
                    { new Guid("d4fe048d-ff12-4715-93e7-3250f49c15c8"), new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5726), "data:image/jpeg;base64,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", false, null, null, 5000.0, "Bánh quy giòn tan trong miệng", "Bánh quy giòn" },
                    { new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"), new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5794), "data:image/jpeg;base64,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", false, null, null, 25000.0, "Bánh mì siêu topping thịt trứng cút, ăn là ghiền!!!", "Bánh mì Sài Gòn" },
                    { new Guid("f31c789c-4a46-45c7-9009-d36681d788c5"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5729), "data:image/jpeg;base64,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", false, null, null, 10000.0, "Kẹo sô cô la ngọt thanh", "Kẹo Socola" },
                    { new Guid("ffb05663-954d-4af3-8a41-91af39446f81"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5786), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxu7OGjZjXXrJHyR6o_v7PSl4Q9PEGKxOfEQ&usqp=CAU", false, null, null, 2500.0, "Kẹo mút mềm dẻo", "Kẹo mút" }
                });

            migrationBuilder.InsertData(
                table: "Station",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StationName", "StoreID" },
                values: new object[,]
                {
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6550), false, null, null, "Ga Metro Bến Thành", new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6556), false, null, null, "Ga Metro Vincom Bình Thạnh", new Guid("d3599df7-877e-41c7-832d-14850e5c88bd") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6558), false, null, null, "Ga Metro Chợ Thủ Đức", new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6564), false, null, null, "Ga Metro Khu Công Nghệ Cao", new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6567), false, null, null, "Ga Metro Suối Tiên", new Guid("ef443e4b-886c-4c06-8528-51e9cf623867") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6570), false, null, null, "Ga Metro Bến xe Miền Đông", new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4") }
                });

            migrationBuilder.InsertData(
                table: "Store_Menu",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuId", "StoreId" },
                values: new object[,]
                {
                    { new Guid("7c763e6b-c05e-4deb-9ed9-52f8e6d88ab3"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6722), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("ae5fc454-cd89-412e-9132-fdfcc16266dd"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6717), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("cd9470ed-d8ba-426c-824c-3a5ac0afd930"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6719), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("e0894a5b-ec28-40b7-bd34-67c98c489adc"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6728), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("e268d0b8-57f7-47db-bfc1-a9bf99fb9b49"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6709), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("fea09738-70a9-43ff-98ca-1a70929eca0f"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6714), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") }
                });

            migrationBuilder.InsertData(
                table: "Trip",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RouteId", "TripEndTime", "TripName", "TripStartTime" },
                values: new object[,]
                {
                    { new Guid("02859382-d88c-4e69-8c47-b8e0456677d5"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(7029), false, null, null, new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), new DateTime(2023, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), "Cruise Vacation", new DateTime(2023, 9, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(7040), false, null, null, new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"), new DateTime(2023, 11, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), "Hiking Adventure", new DateTime(2023, 11, 12, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(7089), false, null, null, new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), new DateTime(2023, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), "Ski Getaway", new DateTime(2023, 12, 20, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6990), false, null, null, new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"), new DateTime(2023, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "Camping Trip", new DateTime(2023, 7, 15, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(7126), false, null, null, new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"), new DateTime(2023, 10, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), "African Safari", new DateTime(2023, 9, 28, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(7101), false, null, null, new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"), new DateTime(2023, 8, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), "Tropical Vacation", new DateTime(2023, 8, 13, 11, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Trip",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RouteId", "TripEndTime", "TripName", "TripStartTime" },
                values: new object[,]
                {
                    { new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(7017), false, null, null, new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), new DateTime(2023, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), "Road Trip", new DateTime(2023, 5, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf736039-33e9-466f-ac4e-78c89f3317e6"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(7112), false, null, null, new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), new DateTime(2023, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), "Amusement Park Fun", new DateTime(2023, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9852f0d-e836-4a6e-94f4-d229b297933d"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(7140), false, null, null, new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), new DateTime(2023, 5, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), "Botanical Gardens Tour", new DateTime(2023, 5, 6, 13, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "WithDraw",
                columns: new[] { "Id", "ApplicationUserID", "Balance", "CreateBy", "CreateTimeOfWithdraw", "Created", "Deposit", "IsDelete", "LastModified", "LastModifiedBy", "PaymentMethodID" },
                values: new object[,]
                {
                    { new Guid("0bd9818a-5ef1-45e3-a6fe-0c932f970fe8"), "E6DE8827-B7C2-46E9-9227-66E6ECE676A8", 2000000.0, null, new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(7522), 125000.0, false, null, null, new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2") },
                    { new Guid("4e917707-0edb-49da-b6f4-804d2c52821b"), "E6DE8827-B7C2-46E9-9227-66E6ECE676A8", 150000.0, null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(7492), 60000.0, false, null, null, new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2") },
                    { new Guid("8efb8acc-2eb9-448d-bfa2-825995f50b59"), "E6DE8827-B7C2-46E9-9227-66E6ECE676A8", 0.0, null, new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(7511), 30000.0, false, null, null, new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2") }
                });

            migrationBuilder.InsertData(
                table: "Menu_Product",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuID", "PriceOfProductBelongToTimeService", "ProductID" },
                values: new object[,]
                {
                    { new Guid("0c299d4d-b6e4-4684-a1c9-b437b8650dab"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4994), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") },
                    { new Guid("43cc7d3e-799f-43ae-b696-3723677a7a2b"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4985), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 35000.0, new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38") },
                    { new Guid("54a91d7d-85e2-445f-90f0-260b8a5374ee"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4987), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("786eec2d-118e-4570-a70d-8b5b55e261d6"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4990), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") },
                    { new Guid("83935fdf-dd86-4a29-a4dd-6b87e46c62e2"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4996), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("8711f054-1667-4a1c-a5c8-d579c0c62f1e"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4969), false, null, null, new Guid("d3fd2009-c658-4498-bf59-26936918a0c8"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("9c4e44d1-d156-4c81-8315-7e01146392ef"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4980), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") },
                    { new Guid("a971c23c-8eb2-4559-8e9b-bf534172c180"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4977), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") },
                    { new Guid("bc1a16dc-38fc-4fd8-b201-38346fc2b83f"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4974), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("c4b00a0f-55d3-4ad3-80aa-e8b434f8a4dd"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(4982), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "ApplicationUserID", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "OrderTokenQR", "StoreID", "TotalPrice", "TripID" },
                values: new object[,]
                {
                    { new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"), "E6DE8827-B7C2-46E9-9227-66E6ECE676A8", null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5358), false, null, null, "1231212QR", new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"), 0.0, new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") },
                    { new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"), "E6DE8827-B7C2-46E9-9227-66E6ECE676A8", null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5347), false, null, null, "1231212QR", new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"), 0.0, new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") },
                    { new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"), "E6DE8827-B7C2-46E9-9227-66E6ECE676A8", null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5354), false, null, null, "11789212QR", new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"), 0.0, new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") }
                });

            migrationBuilder.InsertData(
                table: "Route_Station",
                columns: new[] { "Id", "CreateBy", "Created", "Duration", "Index", "IsDelete", "LastModified", "LastModifiedBy", "RouteID", "StationID", "StopTime" },
                values: new object[,]
                {
                    { new Guid("15fefdbf-b178-49ba-aa7c-7b3e2dd575bc"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5964), new TimeSpan(0, 1, 0, 0, 0), 2, false, null, null, new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new TimeSpan(0, 2, 0, 0, 0) },
                    { new Guid("1b22bdb7-1688-42fa-8fae-4af92e32df7f"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5944), new TimeSpan(0, 0, 30, 0, 0), 1, false, null, null, new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new TimeSpan(0, 0, 30, 0, 0) },
                    { new Guid("2ff9d0d9-474c-4466-b9a8-707b730f415c"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5952), new TimeSpan(0, 0, 30, 0, 0), 1, false, null, null, new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new TimeSpan(0, 1, 0, 0, 0) },
                    { new Guid("5004477e-1446-467d-8157-972185d64290"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5984), new TimeSpan(0, 0, 40, 0, 0), 0, false, null, null, new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4"), new TimeSpan(0, 0, 40, 0, 0) },
                    { new Guid("6a82db5a-23cf-4764-b7d1-ccabce5cc317"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5977), new TimeSpan(0, 1, 40, 0, 0), 3, false, null, null, new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"), new TimeSpan(0, 3, 0, 0, 0) },
                    { new Guid("6e841857-2712-4da3-a15f-aed820adef5a"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5922), new TimeSpan(0, 0, 30, 0, 0), 2, false, null, null, new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new TimeSpan(0, 1, 30, 0, 0) },
                    { new Guid("8de6ed00-50c8-434e-95ce-cc921426e697"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5971), new TimeSpan(0, 1, 30, 0, 0), 3, false, null, null, new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new TimeSpan(0, 2, 0, 0, 0) },
                    { new Guid("ab2099b4-e511-42ff-9e6a-ee71bddcd482"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5958), new TimeSpan(0, 0, 30, 0, 0), 1, false, null, null, new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new TimeSpan(0, 2, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Station_Trip",
                columns: new[] { "Id", "Arrived", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StationID", "TripID" },
                values: new object[,]
                {
                    { new Guid("042413ec-91d2-4c46-ba23-5c24f397d192"), new DateTime(2023, 6, 16, 19, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6372), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("1661f1eb-a7ad-4f37-a113-4d436b86276d"), new DateTime(2023, 11, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6341), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") },
                    { new Guid("2ed19058-d300-4ad6-8c7b-b5eca1d14421"), new DateTime(2023, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6331), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("02859382-d88c-4e69-8c47-b8e0456677d5") },
                    { new Guid("5fa281fc-1453-4efd-8b72-341f011dc760"), new DateTime(2023, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6358), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("6a058b49-add4-4e21-9a3b-5d96a32d13a1"), new DateTime(2023, 6, 16, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6418), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52") },
                    { new Guid("a7b2b5b8-bc86-4833-a07f-7714f37515b5"), new DateTime(2023, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6351), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7") },
                    { new Guid("e8a77962-d883-4cd7-aa41-88d607d044a1"), new DateTime(2023, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6245), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") },
                    { new Guid("f7576c4b-9648-4ddf-bb81-231633b558fe"), new DateTime(2023, 5, 26, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(6365), false, null, null, new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "OrderID", "Price", "ProductID", "Quanity" },
                values: new object[] { new Guid("05a027a2-01b0-40d2-91f7-2a33fc29753f"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5477), false, null, null, new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"), 125000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "OrderID", "Price", "ProductID", "Quanity" },
                values: new object[] { new Guid("a8b7026d-5def-44ef-9666-6b78682a77cc"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5474), false, null, null, new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"), 30000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "OrderID", "Price", "ProductID", "Quanity" },
                values: new object[] { new Guid("f6d015a9-d5bb-40e8-a287-623f0af19fc9"), null, new DateTime(2023, 10, 19, 18, 14, 21, 571, DateTimeKind.Local).AddTicks(5468), false, null, null, new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"), 60000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"), 2 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_Product_MenuID",
                table: "Menu_Product",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_Product_ProductID",
                table: "Menu_Product",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ApplicationUserID",
                table: "Order",
                column: "ApplicationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StoreID",
                table: "Order",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_TripID",
                table: "Order",
                column: "TripID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderID",
                table: "OrderDetail",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductID",
                table: "OrderDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Route_Station_RouteID",
                table: "Route_Station",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_Route_Station_StationID",
                table: "Route_Station",
                column: "StationID");

            migrationBuilder.CreateIndex(
                name: "IX_Station_StoreID",
                table: "Station",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_Station_Trip_StationID",
                table: "Station_Trip",
                column: "StationID");

            migrationBuilder.CreateIndex(
                name: "IX_Station_Trip_TripID",
                table: "Station_Trip",
                column: "TripID");

            migrationBuilder.CreateIndex(
                name: "IX_Store_Menu_MenuId",
                table: "Store_Menu",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_Menu_StoreId",
                table: "Store_Menu",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Trip_RouteId",
                table: "Trip",
                column: "RouteId");

            migrationBuilder.CreateIndex(
                name: "IX_WithDraw_ApplicationUserID",
                table: "WithDraw",
                column: "ApplicationUserID");

            migrationBuilder.CreateIndex(
                name: "IX_WithDraw_PaymentMethodID",
                table: "WithDraw",
                column: "PaymentMethodID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Menu_Product");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Route_Station");

            migrationBuilder.DropTable(
                name: "Station_Trip");

            migrationBuilder.DropTable(
                name: "Store_Menu");

            migrationBuilder.DropTable(
                name: "WithDraw");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Station");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Trip");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "Route");
        }
    }
}
