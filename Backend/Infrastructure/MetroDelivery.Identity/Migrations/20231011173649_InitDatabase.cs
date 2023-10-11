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
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTimeService = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTimeService = table.Column<TimeSpan>(type: "time", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
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
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
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
                    table.PrimaryKey("PK_Routes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
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
                    table.PrimaryKey("PK_Stores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Trips", x => x.Id);
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
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stations",
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
                    table.PrimaryKey("PK_Stations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stations_Stores_StoreID",
                        column: x => x.StoreID,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Store_Menus",
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
                    table.PrimaryKey("PK_Store_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Store_Menus_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Store_Menus_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trip_Routes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TripID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RouteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trip_Routes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trip_Routes_Routes_RouteID",
                        column: x => x.RouteID,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Trip_Routes_Trips_TripID",
                        column: x => x.TripID,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Stores_StoreID",
                        column: x => x.StoreID,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Trips_TripID",
                        column: x => x.TripID,
                        principalTable: "Trips",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WithDraws",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_WithDraws", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WithDraws_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WithDraws_PaymentMethods_PaymentMethodID",
                        column: x => x.PaymentMethodID,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Menu_Products",
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
                    table.PrimaryKey("PK_Menu_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menu_Products_Menus_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Menu_Products_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Route_Stations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RouteID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StationID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route_Stations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Route_Stations_Routes_RouteID",
                        column: x => x.RouteID,
                        principalTable: "Routes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Route_Stations_Stations_StationID",
                        column: x => x.StationID,
                        principalTable: "Stations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
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
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "647D9649-F5A2-4F24-808F-6FC326EC2AA3", "8d05749f-b720-47e3-bf3a-13aa6d8056ed", "Staff", "Staff" },
                    { "AF5EB4AC-219A-4BC1-99FE-8C23876536EA", "677f5417-d8ec-467c-8479-98c1e16a8d2d", "Admin", "Admin" },
                    { "CF531396-C1CD-427B-9D17-0383B7675394", "63edff4c-9777-4aee-a40e-5c146c3a8c50", "EndUser", "EndUser" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1F11BA64-2870-43F7-BB03-867112867F25", 0, "e61153a4-28ee-4063-84a3-2ec3d55937af", "thaivin537@gmail.com", true, "Thái", "Vĩ", false, null, "THAIVIN537@GMAIL.COM", "THAIVIN537@GMAIL.COM", "AQAAAAEAACcQAAAAEPBo8Yj9cmN6VKA/uLjMcGxWW57R4fsd81xhc1DEazleKP4gC6QO6SrH8T2A2Y+dBg==", null, false, "06ae451d-99f4-44b6-8cfd-e9c157f8786a", false, "thaivin537@gmail.com" },
                    { "2198E4CD-3305-49C5-B78A-0B54DD76898F", 0, "476d6a8a-5799-4e24-b442-700fed439b8d", "admin@gmail.com", true, "Nhan", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDRhZYK3jeQyZ4pxyu9lPKhczrMvMYSBStuLwdw48kweLV0ZxcUfYq/DHojuSQAP+Q==", null, false, "15d88465-edb3-4f72-9a02-fa3bf6989f23", false, "admin@gmail.com" },
                    { "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84", 0, "d7163871-f61f-47b7-bdc2-67ca54669298", "staff@gmail.com", true, "Vi", "Staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEJBoEJCr51RrCcwUsfFuDVBZIb7TPf79XzzxSBwPS0SQjW0DxN1fm84QWJrzDRznIw==", null, false, "7bbd301a-6010-485f-9f69-33e1d732b952", false, "staff@gmail.com" },
                    { "2E089AF6-3437-4DD6-9956-BB792E783AFB", 0, "0cc47dd5-b4f8-44b1-9121-8b43a2b2ac36", "nguyenthanhn537@gmail.com", true, "Nhân", "Nguyễn", false, null, "NGUYENTHANHN537@GMAIL.COM", "NGUYENTHANHN537@GMAIL.COM", "AQAAAAEAACcQAAAAEFxZFLwvDrUBcRdXNAnlcQVQ8uDSziwmbgciGoZYRc5VVesUowa598mhPzGJDyABgA==", null, false, "8342d515-5a90-438f-9b77-9c97e916bbdf", false, "nguyenthanhn537@gmail.com" },
                    { "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9", 0, "b5499e87-d6f5-4a74-ba12-e50a5cca7a3d", "anhjenda537@gmail.com", true, "Anh", "Da Đen", false, null, "ANHJENDA537@GMAIL.COM", "ANHJENDA537@GMAIL.COM", "AQAAAAEAACcQAAAAELGIBeXcedlaA9SJr78CMyRDwYRpXx3btn0wQdArCcwS1lnU+VVMh7/uA5xfd8pNZA==", null, false, "ebb8d4bb-89ac-4267-b1ee-11edb704d681", false, "anhjenda537@gmail.com" },
                    { "E6DE8827-B7C2-46E9-9227-66E6ECE676A8", 0, "bfd86e47-0ad9-4e20-83d4-6faf781aa5c6", "enduser@gmail.com", true, "Vi", "EndUser", false, null, "ENDUSER@GMAIL.COM", "ENDUSER@GMAIL.COM", "AQAAAAEAACcQAAAAEH8XFoLZolh2JUGU1jlREAXvFjhWxGP8diy2k1glnTKutC2bSivBZ13+cOWeEj2f5g==", null, false, "3be7e2f3-3d87-4c04-80cc-4fd517391239", false, "enduser@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), "Candy", null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(7749), false, null, null },
                    { new Guid("39696f0c-2c8a-480f-b917-141b7da708e4"), "Dairy", null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(7765), false, null, null },
                    { new Guid("4078ef19-ba53-481d-9c5a-1c37dfe0e0dc"), "Beverages", null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(7729), false, null, null },
                    { new Guid("8908ea98-b421-420b-9634-03ed356bb921"), "Chips", null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(7754), false, null, null },
                    { new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), "Food", null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(7687), false, null, null },
                    { new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"), "Cookies", null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(7760), false, null, null },
                    { new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"), "Bread", null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(7744), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreateBy", "Created", "EndTimeService", "IsDelete", "LastModified", "LastModifiedBy", "StartTimeService" },
                values: new object[,]
                {
                    { new Guid("47a91dd5-f999-461a-8f80-935d169ca0c3"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8837), new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 13, 0, 0, 0) },
                    { new Guid("4cbf8910-c204-46fe-91d4-e8e4c94ff695"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8890), new TimeSpan(0, 5, 0, 0, 0), false, null, null, new TimeSpan(0, 1, 0, 0, 0) },
                    { new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8807), new TimeSpan(0, 11, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8821), new TimeSpan(0, 13, 0, 0, 0), false, null, null, new TimeSpan(0, 11, 0, 0, 0) },
                    { new Guid("bbc7d071-5f5b-40be-b25e-3aa07a6c3e7c"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8872), new TimeSpan(0, 0, 0, 0, 0), false, null, null, new TimeSpan(0, 20, 0, 0, 0) },
                    { new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8858), new TimeSpan(0, 20, 0, 0, 0), false, null, null, new TimeSpan(0, 17, 0, 0, 0) },
                    { new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8754), new TimeSpan(0, 8, 0, 0, 0), false, null, null, new TimeSpan(0, 6, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "PaymentMethodName" },
                values: new object[,]
                {
                    { new Guid("36672051-5437-4d2c-a42e-c71a9b67a2b1"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(305), false, null, null, "thanh toán trên app MetroPickUp" },
                    { new Guid("47bd4dd4-3fb4-463e-b9b9-5ebfb7e1f960"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(301), false, null, null, "thanh toán qua momo" },
                    { new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(277), false, null, null, "thanh toán tiền mặt" },
                    { new Guid("7db43916-e061-42cb-b0a7-9734423d00cd"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(294), false, null, null, "thanh toán ngân hàng" }
                });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "Id", "CreateBy", "Created", "FromLocation", "IsDelete", "LastModified", "LastModifiedBy", "ToLocation" },
                values: new object[,]
                {
                    { new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(1863), "Quận 1, Tp.Hcm", false, null, null, "Suối Tiên, Đồng Nai" },
                    { new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(1880), "Quận Bình Thạnh", false, null, null, "Bến Thành, Quận 1, TP HCM" },
                    { new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(1870), "Quận 1, Tp.Hcm", false, null, null, "Quận Thủ Đức, Tp.Hcm" },
                    { new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(1876), "Quận 1, Tp.Hcm", false, null, null, "Bến xe Miền Đông" },
                    { new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(1873), "Quận 1, Tp.Hcm", false, null, null, "Quận Bình Thạnh, Tp.Hcm" },
                    { new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(1852), "Quận 1, Tp.Hcm", false, null, null, "Quận 9, Tp.Hcm" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StoreCloseTime", "StoreLocation", "StoreName", "StoreOpenTime" },
                values: new object[,]
                {
                    { new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(3243), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Số 1, Võ Văn Ngân, Thành Phố Thủ Đức", "Metro PickUp 3", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(3298), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Bến Xe Miền Đông", "Metro PickUp 6", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(3259), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Khu Công Nghệ Cao Thành Phố Thủ Đức ", "Metro PickUp 4", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(3199), false, null, null, new TimeSpan(0, 23, 0, 0, 0), "Số 2, Đường Lê Lai, Quận 1", "Metro PickUp 1", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(3231), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Số 3, Vincom, Quận Bình Thạnh", "Metro PickUp 2", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(3279), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Suối tiên", "Metro PickUp 5", new TimeSpan(0, 6, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "TripEndTime", "TripName", "TripStartTime" },
                values: new object[,]
                {
                    { new Guid("02859382-d88c-4e69-8c47-b8e0456677d5"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(4281), false, null, null, new DateTime(2023, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), "Cruise Vacation", new DateTime(2023, 9, 10, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(4302), false, null, null, new DateTime(2023, 11, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), "Hiking Adventure", new DateTime(2023, 11, 12, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(4328), false, null, null, new DateTime(2023, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), "Ski Getaway", new DateTime(2023, 12, 20, 8, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "TripEndTime", "TripName", "TripStartTime" },
                values: new object[,]
                {
                    { new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(4129), false, null, null, new DateTime(2023, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "Camping Trip", new DateTime(2023, 7, 15, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(4401), false, null, null, new DateTime(2023, 10, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), "African Safari", new DateTime(2023, 9, 28, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(4357), false, null, null, new DateTime(2023, 8, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), "Tropical Vacation", new DateTime(2023, 8, 13, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(4256), false, null, null, new DateTime(2023, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), "Road Trip", new DateTime(2023, 5, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf736039-33e9-466f-ac4e-78c89f3317e6"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(4379), false, null, null, new DateTime(2023, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), "Amusement Park Fun", new DateTime(2023, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9852f0d-e836-4a6e-94f4-d229b297933d"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(4422), false, null, null, new DateTime(2023, 5, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), "Botanical Gardens Tour", new DateTime(2023, 5, 6, 13, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "CF531396-C1CD-427B-9D17-0383B7675394", "1F11BA64-2870-43F7-BB03-867112867F25" },
                    { "AF5EB4AC-219A-4BC1-99FE-8C23876536EA", "2198E4CD-3305-49C5-B78A-0B54DD76898F" },
                    { "647D9649-F5A2-4F24-808F-6FC326EC2AA3", "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84" },
                    { "CF531396-C1CD-427B-9D17-0383B7675394", "2E089AF6-3437-4DD6-9956-BB792E783AFB" },
                    { "CF531396-C1CD-427B-9D17-0383B7675394", "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9" },
                    { "CF531396-C1CD-427B-9D17-0383B7675394", "E6DE8827-B7C2-46E9-9227-66E6ECE676A8" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "ApplicationUserId", "Birthday", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "Phone" },
                values: new object[,]
                {
                    { new Guid("01d31c40-14c9-444c-a2fe-f58ea0fbc08a"), "Gia Lai", "2E089AF6-3437-4DD6-9956-BB792E783AFB", new DateTime(1998, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(4781), false, null, null, "0914009910" },
                    { new Guid("0512a248-0054-4616-ade5-ae412f4f07bd"), "Cần Thơ", "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9", new DateTime(2002, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(4761), false, null, null, "0961868641" },
                    { new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"), "hcm", "2198E4CD-3305-49C5-B78A-0B54DD76898F", new DateTime(2010, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(4752), false, null, null, "03030303" },
                    { new Guid("ecf95bf5-d766-4b6e-94a7-d33ea29c0618"), "Đắk Lắk", "1F11BA64-2870-43F7-BB03-867112867F25", new DateTime(1899, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(4774), false, null, null, "0903182861" },
                    { new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719440"), "da nang", "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84", new DateTime(2002, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(4707), false, null, null, "03030303" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "CreateBy", "Created", "Image", "IsDelete", "LastModified", "LastModifiedBy", "Price", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { new Guid("0c308b93-b26a-4224-9d63-28294711aa15"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(733), null, false, null, null, 50000.0, "Gà rán giòn tan thơm ngon", "Gà rán" },
                    { new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(741), null, false, null, null, 65000.0, "Cá chiên giòn rụm", "Cá chiên" },
                    { new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(702), null, false, null, null, 30000.0, "Cơm gà xé thơm ngon", "Cơm gà xé" },
                    { new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(768), null, false, null, null, 25000.0, "Cơm chiên dương châu thơm ngon", "Cơm chiên dương châu" },
                    { new Guid("45da4260-ba13-489b-995a-1f6adb13ab75"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(661), null, false, null, null, 5000.5, "Kẹo thơm ngon được tạo ra từ các loại đường, được làm nóng và tạo nên hương vị ngọt ngào", "Keo bông gòn" },
                    { new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(762), null, false, null, null, 80000.0, "Gà nướng thơm phức", "Gà nướng" },
                    { new Guid("4ecd72e3-f43d-490f-8b46-8e92ea29f85c"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(728), null, false, null, null, 15000.0, "Kẹo dâu tây thơm ngon", "Kẹo dâu" },
                    { new Guid("55265d3b-fa02-4e09-84db-d4e8c8a9a9b5"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(748), null, false, null, null, 5000.0, "Kẹo bạc hà mát lạnh", "Kẹo bạc hà" },
                    { new Guid("6d60bf44-b775-4d87-bb47-aace85d49ac4"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(696), null, false, null, null, 2500.0, "Kẹo dẻo mềm, đàn hồi", "Kẹo dẻo" },
                    { new Guid("7d661a30-e180-498c-9a77-cb6112a7cb22"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(675), null, false, null, null, 3000.0, "Kẹo lạc thơm ngon, giòn tan", "Kẹo lạc" },
                    { new Guid("7da34092-5747-42b7-b059-4a5aad57e740"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(684), null, false, null, null, 3000.0, "Kẹo lạc thơm ngon, giòn tan", "Kẹo chup" },
                    { new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c"), new Guid("8908ea98-b421-420b-9634-03ed356bb921"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(690), null, false, null, null, 10000.0, "Khoai tây chiên giòn tan", "Khoai tây chiên" },
                    { new Guid("d4fe048d-ff12-4715-93e7-3250f49c15c8"), new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(709), null, false, null, null, 5000.0, "Bánh quy giòn tan trong miệng", "Bánh quy giòn" },
                    { new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"), new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(775), null, false, null, null, 25000.0, "Bánh mì siêu topping thịt trứng cút, ăn là ghiền!!!", "Bánh mì Sài Gòn" },
                    { new Guid("f31c789c-4a46-45c7-9009-d36681d788c5"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(716), null, false, null, null, 10000.0, "Kẹo sô cô la ngọt thanh", "Kẹo Socola" },
                    { new Guid("ffb05663-954d-4af3-8a41-91af39446f81"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(755), null, false, null, null, 2500.0, "Kẹo mút mềm dẻo", "Kẹo mút" }
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StationName", "StoreID" },
                values: new object[,]
                {
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(2233), false, null, null, "Ga Metro Bến Thành", new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(2245), false, null, null, "Ga Metro Vincom Bình Thạnh", new Guid("d3599df7-877e-41c7-832d-14850e5c88bd") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(2251), false, null, null, "Ga Metro Chợ Thủ Đức", new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(2259), false, null, null, "Ga Metro Khu Công Nghệ Cao", new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(2272), false, null, null, "Ga Metro Suối Tiên", new Guid("ef443e4b-886c-4c06-8528-51e9cf623867") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(2278), false, null, null, "Ga Metro Bến xe Miền Đông", new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4") }
                });

            migrationBuilder.InsertData(
                table: "Store_Menus",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuId", "StoreId" },
                values: new object[,]
                {
                    { new Guid("15a21171-b531-4f12-87c5-b4e6acfc263f"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(2798), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("23410208-3975-4db3-a294-a540b427eaf0"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(2817), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("3d4a7586-4334-43a3-bf71-10726a30e191"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(2805), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("45fe545c-3b2e-43f8-9e70-c90d60d51ff5"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(2811), false, null, null, new Guid("47a91dd5-f999-461a-8f80-935d169ca0c3"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("4b1d0949-9d89-407b-875e-b85766133927"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(2824), false, null, null, new Guid("bbc7d071-5f5b-40be-b25e-3aa07a6c3e7c"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("aa2123f6-2b53-4826-b41d-42fc29750514"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(2836), false, null, null, new Guid("4cbf8910-c204-46fe-91d4-e8e4c94ff695"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("de05c3d1-3a6d-407b-a929-4bc193c1e924"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(2784), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") }
                });

            migrationBuilder.InsertData(
                table: "Trip_Routes",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RouteID", "TripID" },
                values: new object[,]
                {
                    { new Guid("293e9a18-fcfe-4c62-b65f-490a66e1b0f2"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(3802), false, null, null, new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") },
                    { new Guid("3f70b841-2386-4046-94fc-12897fad21fa"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(3832), false, null, null, new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") }
                });

            migrationBuilder.InsertData(
                table: "Trip_Routes",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RouteID", "TripID" },
                values: new object[] { new Guid("971a630b-ac4b-4534-a265-f863d1ba9d75"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(3822), false, null, null, new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"), new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") });

            migrationBuilder.InsertData(
                table: "Trip_Routes",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RouteID", "TripID" },
                values: new object[] { new Guid("b419d0d0-17c5-4361-a9ff-7e0a9fcbb32f"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(3829), false, null, null, new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"), new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7") });

            migrationBuilder.InsertData(
                table: "Trip_Routes",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RouteID", "TripID" },
                values: new object[] { new Guid("deb14eb5-c9ba-445e-84ee-9e583536c901"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(3818), false, null, null, new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), new Guid("02859382-d88c-4e69-8c47-b8e0456677d5") });

            migrationBuilder.InsertData(
                table: "Menu_Products",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuID", "PriceOfProductBelongToTimeService", "ProductID" },
                values: new object[,]
                {
                    { new Guid("4c99cbdf-775d-4dd1-8f0e-23567b806dcb"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8351), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") },
                    { new Guid("4d34842b-cc75-4511-a5b8-aabb492e3c24"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8372), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") },
                    { new Guid("58ebfd86-59b2-4335-af7f-d1ecb439e837"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8366), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") },
                    { new Guid("65eabc52-20c5-42f5-9e8a-5e643e470b17"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8355), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 35000.0, new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38") },
                    { new Guid("9be6b69a-d9be-43f9-83e7-9b05e98a7a30"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8360), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("aa1206f6-2f43-4cbf-9791-95af4951e918"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8378), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("da8849d2-abb6-4c69-9c5a-c5d94d11b038"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8336), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("dd41524b-4066-4e67-8110-fb265605c7e2"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8339), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") },
                    { new Guid("df5f8e2a-1786-425f-84bc-895ef6c7acbf"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8348), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") },
                    { new Guid("ea452a0f-1887-4b7a-81c1-e8ee640c9bea"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(8321), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreateBy", "Created", "CustomerID", "IsDelete", "LastModified", "LastModifiedBy", "OrderTokenQR", "StoreID", "TotalPrice", "TripID" },
                values: new object[,]
                {
                    { new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(9453), new Guid("01d31c40-14c9-444c-a2fe-f58ea0fbc08a"), false, null, null, "1231212QR", new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"), 0.0, new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") },
                    { new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(9414), new Guid("0512a248-0054-4616-ade5-ae412f4f07bd"), false, null, null, "1231212QR", new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"), 0.0, new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") },
                    { new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(9437), new Guid("ecf95bf5-d766-4b6e-94a7-d33ea29c0618"), false, null, null, "11789212QR", new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"), 0.0, new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") }
                });

            migrationBuilder.InsertData(
                table: "Route_Stations",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RouteID", "StationID" },
                values: new object[,]
                {
                    { new Guid("1b22bdb7-1688-42fa-8fae-4af92e32df7f"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(1465), false, null, null, new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5") },
                    { new Guid("2ff9d0d9-474c-4466-b9a8-707b730f415c"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(1470), false, null, null, new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6") },
                    { new Guid("5004477e-1446-467d-8157-972185d64290"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(1484), false, null, null, new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4") },
                    { new Guid("6a82db5a-23cf-4764-b7d1-ccabce5cc317"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(1479), false, null, null, new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9") },
                    { new Guid("6e841857-2712-4da3-a15f-aed820adef5a"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(1452), false, null, null, new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7") },
                    { new Guid("ab2099b4-e511-42ff-9e6a-ee71bddcd482"), null, new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(1475), false, null, null, new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8") }
                });

            migrationBuilder.InsertData(
                table: "WithDraws",
                columns: new[] { "Id", "Balance", "CreateBy", "CreateTimeOfWithdraw", "Created", "CustomerID", "Deposit", "IsDelete", "LastModified", "LastModifiedBy", "PaymentMethodID" },
                values: new object[,]
                {
                    { new Guid("0bd9818a-5ef1-45e3-a6fe-0c932f970fe8"), 2000000.0, null, new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(5107), new Guid("01d31c40-14c9-444c-a2fe-f58ea0fbc08a"), 125000.0, false, null, null, new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2") },
                    { new Guid("4e917707-0edb-49da-b6f4-804d2c52821b"), 150000.0, null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(5079), new Guid("0512a248-0054-4616-ade5-ae412f4f07bd"), 60000.0, false, null, null, new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2") },
                    { new Guid("8efb8acc-2eb9-448d-bfa2-825995f50b59"), 0.0, null, new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 12, 0, 36, 49, 170, DateTimeKind.Local).AddTicks(5097), new Guid("ecf95bf5-d766-4b6e-94a7-d33ea29c0618"), 30000.0, false, null, null, new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "OrderID", "Price", "ProductID", "Quanity" },
                values: new object[] { new Guid("05a027a2-01b0-40d2-91f7-2a33fc29753f"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(9882), false, null, null, new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"), 125000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "OrderID", "Price", "ProductID", "Quanity" },
                values: new object[] { new Guid("a8b7026d-5def-44ef-9666-6b78682a77cc"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(9877), false, null, null, new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"), 30000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "OrderID", "Price", "ProductID", "Quanity" },
                values: new object[] { new Guid("f6d015a9-d5bb-40e8-a287-623f0af19fc9"), null, new DateTime(2023, 10, 12, 0, 36, 49, 169, DateTimeKind.Local).AddTicks(9866), false, null, null, new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"), 60000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"), 2 });

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
                name: "IX_Customers_ApplicationUserId",
                table: "Customers",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menu_Products_MenuID",
                table: "Menu_Products",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_Products_ProductID",
                table: "Menu_Products",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderID",
                table: "OrderDetails",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreID",
                table: "Orders",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_TripID",
                table: "Orders",
                column: "TripID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Route_Stations_RouteID",
                table: "Route_Stations",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_Route_Stations_StationID",
                table: "Route_Stations",
                column: "StationID");

            migrationBuilder.CreateIndex(
                name: "IX_Stations_StoreID",
                table: "Stations",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_Store_Menus_MenuId",
                table: "Store_Menus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_Menus_StoreId",
                table: "Store_Menus",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Trip_Routes_RouteID",
                table: "Trip_Routes",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_Trip_Routes_TripID",
                table: "Trip_Routes",
                column: "TripID");

            migrationBuilder.CreateIndex(
                name: "IX_WithDraws_CustomerID",
                table: "WithDraws",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_WithDraws_PaymentMethodID",
                table: "WithDraws",
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
                name: "Menu_Products");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Route_Stations");

            migrationBuilder.DropTable(
                name: "Store_Menus");

            migrationBuilder.DropTable(
                name: "Trip_Routes");

            migrationBuilder.DropTable(
                name: "WithDraws");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Stations");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
