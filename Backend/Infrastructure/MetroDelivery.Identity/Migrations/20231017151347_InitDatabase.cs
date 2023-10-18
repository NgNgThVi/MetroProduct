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
                name: "Menu",
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
                name: "Customer",
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
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
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
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
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
                name: "WithDraw",
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
                    table.PrimaryKey("PK_WithDraw", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WithDraw_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
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
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
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
                    Arrived = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    { "647D9649-F5A2-4F24-808F-6FC326EC2AA3", "bed37c01-16d7-411f-9eb4-2eebd3565bde", "Staff", "Staff" },
                    { "AF5EB4AC-219A-4BC1-99FE-8C23876536EA", "16bcdf85-bdf4-46a8-bfc6-99cbcd62f8cc", "Admin", "Admin" },
                    { "CF531396-C1CD-427B-9D17-0383B7675394", "8c65f54f-6322-4d7a-b1a3-589d08d8016f", "EndUser", "EndUser" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1F11BA64-2870-43F7-BB03-867112867F25", 0, "487b3bf4-08ab-4b4a-8110-fe95371b3fc2", "thaivin537@gmail.com", true, "Thái", "Vĩ", false, null, "THAIVIN537@GMAIL.COM", "THAIVIN537@GMAIL.COM", "AQAAAAEAACcQAAAAEHOpkMueqjazVWiCNcTjGYKYpyXVjLrP6nRiDOH+NaYpygyFWZdw5jb6fO/2WHF5eA==", null, false, "5375ea16-16e9-422e-b066-675debb330de", false, "thaivin537@gmail.com" },
                    { "2198E4CD-3305-49C5-B78A-0B54DD76898F", 0, "73cf226a-4ec5-4dab-a038-1561fe7dad47", "admin@gmail.com", true, "Nhan", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAELVMM545M79C1nBxD/Yy9zP2mwssQFMJLH0IdBnfOIKxyqVSE0XZ9axiZMN6d/uVaw==", null, false, "5f4f2405-3f10-473c-8d3a-2115132135b6", false, "admin@gmail.com" },
                    { "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84", 0, "c9f60228-71d1-4cbb-a0ca-d7a7a52827f7", "staff@gmail.com", true, "Vi", "Staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAENDeQMPaL1iBKrhPX4MLSnqEH4NTmcLyIJh2eggNjpQmKCgok7CFmqv8DmyVGeT0nw==", null, false, "12cf9893-2fd2-4ba8-9c63-b0364b4581d1", false, "staff@gmail.com" },
                    { "2E089AF6-3437-4DD6-9956-BB792E783AFB", 0, "eb86872e-63e2-446b-8a29-4a5b3011cd95", "nguyenthanhn537@gmail.com", true, "Nhân", "Nguyễn", false, null, "NGUYENTHANHN537@GMAIL.COM", "NGUYENTHANHN537@GMAIL.COM", "AQAAAAEAACcQAAAAEG9/DT39QRBwjhcZm6GymRXkKTyTIraAyDg0ptZBBmR+zz5TDP63/W49J1LEHrhUIA==", null, false, "085e8d2c-c098-4e46-9d51-4a0b9e495e45", false, "nguyenthanhn537@gmail.com" },
                    { "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9", 0, "4bd4283a-ce1b-4682-a572-d128f39109be", "anhjenda537@gmail.com", true, "Anh", "Da Đen", false, null, "ANHJENDA537@GMAIL.COM", "ANHJENDA537@GMAIL.COM", "AQAAAAEAACcQAAAAECGEmMWcdQxlJQ7D0WQ3bBDW284yZZK6UnXhANgGvZDYXCxgFqPqFrtMLPioosmmpQ==", null, false, "d7fa4efb-8d32-4856-8613-c33f28d7e587", false, "anhjenda537@gmail.com" },
                    { "E6DE8827-B7C2-46E9-9227-66E6ECE676A8", 0, "7c6904f4-f4f2-423a-8f09-13b03618e3c9", "enduser@gmail.com", true, "Vi", "EndUser", false, null, "ENDUSER@GMAIL.COM", "ENDUSER@GMAIL.COM", "AQAAAAEAACcQAAAAELkrMLbP7exyylpKNTwZ9FqzIekdsWAOqib7NX4EfVeH2Fsa3R5FSQYqwwCe1JWjZQ==", null, false, "29ff9d31-d9ff-44bc-b3c1-51f39a871d36", false, "enduser@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), "Candy", null, new DateTime(2023, 10, 17, 22, 13, 46, 440, DateTimeKind.Local).AddTicks(9902), false, null, null },
                    { new Guid("39696f0c-2c8a-480f-b917-141b7da708e4"), "Dairy", null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(11), false, null, null },
                    { new Guid("4078ef19-ba53-481d-9c5a-1c37dfe0e0dc"), "Beverages", null, new DateTime(2023, 10, 17, 22, 13, 46, 440, DateTimeKind.Local).AddTicks(9896), false, null, null },
                    { new Guid("8908ea98-b421-420b-9634-03ed356bb921"), "Chips", null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(6), false, null, null },
                    { new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), "Food", null, new DateTime(2023, 10, 17, 22, 13, 46, 440, DateTimeKind.Local).AddTicks(9854), false, null, null },
                    { new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"), "Cookies", null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(9), false, null, null },
                    { new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"), "Bread", null, new DateTime(2023, 10, 17, 22, 13, 46, 440, DateTimeKind.Local).AddTicks(9900), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Menu",
                columns: new[] { "Id", "CreateBy", "Created", "EndTimeService", "IsDelete", "LastModified", "LastModifiedBy", "StartTimeService" },
                values: new object[,]
                {
                    { new Guid("47a91dd5-f999-461a-8f80-935d169ca0c3"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(431), new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 13, 0, 0, 0) },
                    { new Guid("4cbf8910-c204-46fe-91d4-e8e4c94ff695"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(449), new TimeSpan(0, 5, 0, 0, 0), false, null, null, new TimeSpan(0, 1, 0, 0, 0) },
                    { new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(417), new TimeSpan(0, 11, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(424), new TimeSpan(0, 13, 0, 0, 0), false, null, null, new TimeSpan(0, 11, 0, 0, 0) },
                    { new Guid("bbc7d071-5f5b-40be-b25e-3aa07a6c3e7c"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(443), new TimeSpan(0, 0, 0, 0, 0), false, null, null, new TimeSpan(0, 20, 0, 0, 0) },
                    { new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(437), new TimeSpan(0, 20, 0, 0, 0), false, null, null, new TimeSpan(0, 17, 0, 0, 0) },
                    { new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(369), new TimeSpan(0, 8, 0, 0, 0), false, null, null, new TimeSpan(0, 6, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "PaymentMethodName" },
                values: new object[,]
                {
                    { new Guid("36672051-5437-4d2c-a42e-c71a9b67a2b1"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1034), false, null, null, "thanh toán trên app MetroPickUp" },
                    { new Guid("47bd4dd4-3fb4-463e-b9b9-5ebfb7e1f960"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1028), false, null, null, "thanh toán qua momo" },
                    { new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1021), false, null, null, "thanh toán tiền mặt" },
                    { new Guid("7db43916-e061-42cb-b0a7-9734423d00cd"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1026), false, null, null, "thanh toán ngân hàng" }
                });

            migrationBuilder.InsertData(
                table: "Route",
                columns: new[] { "Id", "CreateBy", "Created", "FromLocation", "IsDelete", "LastModified", "LastModifiedBy", "ToLocation" },
                values: new object[,]
                {
                    { new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1690), "Quận 1, Tp.Hcm", false, null, null, "Suối Tiên, Đồng Nai" },
                    { new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1699), "Quận Bình Thạnh", false, null, null, "Bến Thành, Quận 1, TP HCM" },
                    { new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1693), "Quận 1, Tp.Hcm", false, null, null, "Quận Thủ Đức, Tp.Hcm" },
                    { new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1697), "Quận 1, Tp.Hcm", false, null, null, "Bến xe Miền Đông" },
                    { new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1695), "Quận 1, Tp.Hcm", false, null, null, "Quận Bình Thạnh, Tp.Hcm" },
                    { new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1686), "Quận 1, Tp.Hcm", false, null, null, "Quận 9, Tp.Hcm" }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StoreCloseTime", "StoreLocation", "StoreName", "StoreOpenTime" },
                values: new object[,]
                {
                    { new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2667), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Số 1, Võ Văn Ngân, Thành Phố Thủ Đức", "Metro PickUp 3", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2697), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Bến Xe Miền Đông", "Metro PickUp 6", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2677), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Khu Công Nghệ Cao Thành Phố Thủ Đức ", "Metro PickUp 4", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2645), false, null, null, new TimeSpan(0, 23, 0, 0, 0), "Số 2, Đường Lê Lai, Quận 1", "Metro PickUp 1", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2661), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Số 3, Vincom, Quận Bình Thạnh", "Metro PickUp 2", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2691), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Suối tiên", "Metro PickUp 5", new TimeSpan(0, 6, 0, 0, 0) }
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
                table: "Customer",
                columns: new[] { "Id", "Address", "ApplicationUserId", "Birthday", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "Phone" },
                values: new object[,]
                {
                    { new Guid("01d31c40-14c9-444c-a2fe-f58ea0fbc08a"), "Gia Lai", "2E089AF6-3437-4DD6-9956-BB792E783AFB", new DateTime(1998, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3205), false, null, null, "0914009910" },
                    { new Guid("0512a248-0054-4616-ade5-ae412f4f07bd"), "Cần Thơ", "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9", new DateTime(2002, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3191), false, null, null, "0961868641" },
                    { new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"), "hcm", "2198E4CD-3305-49C5-B78A-0B54DD76898F", new DateTime(2010, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3134), false, null, null, "03030303" },
                    { new Guid("ecf95bf5-d766-4b6e-94a7-d33ea29c0618"), "Đắk Lắk", "1F11BA64-2870-43F7-BB03-867112867F25", new DateTime(1899, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3197), false, null, null, "0903182861" },
                    { new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719440"), "da nang", "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84", new DateTime(2002, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3098), false, null, null, "03030303" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryID", "CreateBy", "Created", "Image", "IsDelete", "LastModified", "LastModifiedBy", "Price", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { new Guid("0c308b93-b26a-4224-9d63-28294711aa15"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1199), null, false, null, null, 50000.0, "Gà rán giòn tan thơm ngon", "Gà rán" },
                    { new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1202), null, false, null, null, 65000.0, "Cá chiên giòn rụm", "Cá chiên" },
                    { new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1179), null, false, null, null, 30000.0, "Cơm gà xé thơm ngon", "Cơm gà xé" },
                    { new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1219), null, false, null, null, 25000.0, "Cơm chiên dương châu thơm ngon", "Cơm chiên dương châu" },
                    { new Guid("45da4260-ba13-489b-995a-1f6adb13ab75"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1160), null, false, null, null, 5000.5, "Kẹo thơm ngon được tạo ra từ các loại đường, được làm nóng và tạo nên hương vị ngọt ngào", "Keo bông gòn" },
                    { new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1216), null, false, null, null, 80000.0, "Gà nướng thơm phức", "Gà nướng" },
                    { new Guid("4ecd72e3-f43d-490f-8b46-8e92ea29f85c"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1196), null, false, null, null, 15000.0, "Kẹo dâu tây thơm ngon", "Kẹo dâu" },
                    { new Guid("55265d3b-fa02-4e09-84db-d4e8c8a9a9b5"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1206), null, false, null, null, 5000.0, "Kẹo bạc hà mát lạnh", "Kẹo bạc hà" },
                    { new Guid("6d60bf44-b775-4d87-bb47-aace85d49ac4"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1175), null, false, null, null, 2500.0, "Kẹo dẻo mềm, đàn hồi", "Kẹo dẻo" },
                    { new Guid("7d661a30-e180-498c-9a77-cb6112a7cb22"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1166), null, false, null, null, 3000.0, "Kẹo lạc thơm ngon, giòn tan", "Kẹo lạc" },
                    { new Guid("7da34092-5747-42b7-b059-4a5aad57e740"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1169), null, false, null, null, 3000.0, "Kẹo lạc thơm ngon, giòn tan", "Kẹo chup" },
                    { new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c"), new Guid("8908ea98-b421-420b-9634-03ed356bb921"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1172), null, false, null, null, 10000.0, "Khoai tây chiên giòn tan", "Khoai tây chiên" },
                    { new Guid("d4fe048d-ff12-4715-93e7-3250f49c15c8"), new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1182), null, false, null, null, 5000.0, "Bánh quy giòn tan trong miệng", "Bánh quy giòn" },
                    { new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"), new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1224), null, false, null, null, 25000.0, "Bánh mì siêu topping thịt trứng cút, ăn là ghiền!!!", "Bánh mì Sài Gòn" },
                    { new Guid("f31c789c-4a46-45c7-9009-d36681d788c5"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1191), null, false, null, null, 10000.0, "Kẹo sô cô la ngọt thanh", "Kẹo Socola" },
                    { new Guid("ffb05663-954d-4af3-8a41-91af39446f81"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1211), null, false, null, null, 2500.0, "Kẹo mút mềm dẻo", "Kẹo mút" }
                });

            migrationBuilder.InsertData(
                table: "Station",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StationName", "StoreID" },
                values: new object[,]
                {
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2277), false, null, null, "Ga Metro Bến Thành", new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2282), false, null, null, "Ga Metro Vincom Bình Thạnh", new Guid("d3599df7-877e-41c7-832d-14850e5c88bd") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2288), false, null, null, "Ga Metro Chợ Thủ Đức", new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2292), false, null, null, "Ga Metro Khu Công Nghệ Cao", new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2300), false, null, null, "Ga Metro Suối Tiên", new Guid("ef443e4b-886c-4c06-8528-51e9cf623867") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2303), false, null, null, "Ga Metro Bến xe Miền Đông", new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4") }
                });

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

            migrationBuilder.InsertData(
                table: "Trip",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RouteId", "TripEndTime", "TripName", "TripStartTime" },
                values: new object[,]
                {
                    { new Guid("02859382-d88c-4e69-8c47-b8e0456677d5"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2878), false, null, null, new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), new DateTime(2023, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), "Cruise Vacation", new DateTime(2023, 9, 10, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2890), false, null, null, new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"), new DateTime(2023, 11, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), "Hiking Adventure", new DateTime(2023, 11, 12, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2902), false, null, null, new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), new DateTime(2023, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), "Ski Getaway", new DateTime(2023, 12, 20, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2833), false, null, null, new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"), new DateTime(2023, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "Camping Trip", new DateTime(2023, 7, 15, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2943), false, null, null, new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"), new DateTime(2023, 10, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), "African Safari", new DateTime(2023, 9, 28, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2917), false, null, null, new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"), new DateTime(2023, 8, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), "Tropical Vacation", new DateTime(2023, 8, 13, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2865), false, null, null, new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), new DateTime(2023, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), "Road Trip", new DateTime(2023, 5, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf736039-33e9-466f-ac4e-78c89f3317e6"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2930), false, null, null, new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), new DateTime(2023, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), "Amusement Park Fun", new DateTime(2023, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9852f0d-e836-4a6e-94f4-d229b297933d"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(2956), false, null, null, new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), new DateTime(2023, 5, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), "Botanical Gardens Tour", new DateTime(2023, 5, 6, 13, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "Id", "CreateBy", "Created", "CustomerID", "IsDelete", "LastModified", "LastModifiedBy", "OrderTokenQR", "StoreID", "TotalPrice", "TripID" },
                values: new object[,]
                {
                    { new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(602), new Guid("01d31c40-14c9-444c-a2fe-f58ea0fbc08a"), false, null, null, "1231212QR", new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"), 0.0, new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") },
                    { new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(585), new Guid("0512a248-0054-4616-ade5-ae412f4f07bd"), false, null, null, "1231212QR", new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"), 0.0, new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") },
                    { new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(597), new Guid("ecf95bf5-d766-4b6e-94a7-d33ea29c0618"), false, null, null, "11789212QR", new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"), 0.0, new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") }
                });

            migrationBuilder.InsertData(
                table: "Route_Station",
                columns: new[] { "Id", "CreateBy", "Created", "Duration", "Index", "IsDelete", "LastModified", "LastModifiedBy", "RouteID", "StationID", "StopTime" },
                values: new object[,]
                {
                    { new Guid("15fefdbf-b178-49ba-aa7c-7b3e2dd575bc"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1498), new TimeSpan(0, 1, 0, 0, 0), 2, false, null, null, new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), new TimeSpan(0, 2, 0, 0, 0) },
                    { new Guid("1b22bdb7-1688-42fa-8fae-4af92e32df7f"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1429), new TimeSpan(0, 0, 30, 0, 0), 1, false, null, null, new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new TimeSpan(0, 0, 30, 0, 0) },
                    { new Guid("2ff9d0d9-474c-4466-b9a8-707b730f415c"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1437), new TimeSpan(0, 0, 30, 0, 0), 1, false, null, null, new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new TimeSpan(0, 1, 0, 0, 0) },
                    { new Guid("5004477e-1446-467d-8157-972185d64290"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1529), new TimeSpan(0, 0, 40, 0, 0), 0, false, null, null, new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4"), new TimeSpan(0, 0, 40, 0, 0) },
                    { new Guid("6a82db5a-23cf-4764-b7d1-ccabce5cc317"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1513), new TimeSpan(0, 1, 40, 0, 0), 3, false, null, null, new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"), new TimeSpan(0, 3, 0, 0, 0) },
                    { new Guid("6e841857-2712-4da3-a15f-aed820adef5a"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1407), new TimeSpan(0, 0, 30, 0, 0), 2, false, null, null, new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new TimeSpan(0, 1, 30, 0, 0) },
                    { new Guid("8de6ed00-50c8-434e-95ce-cc921426e697"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1506), new TimeSpan(0, 1, 30, 0, 0), 3, false, null, null, new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), new TimeSpan(0, 2, 0, 0, 0) },
                    { new Guid("ab2099b4-e511-42ff-9e6a-ee71bddcd482"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(1446), new TimeSpan(0, 0, 30, 0, 0), 1, false, null, null, new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), new TimeSpan(0, 2, 0, 0, 0) }
                });

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

            migrationBuilder.InsertData(
                table: "WithDraw",
                columns: new[] { "Id", "Balance", "CreateBy", "CreateTimeOfWithdraw", "Created", "CustomerID", "Deposit", "IsDelete", "LastModified", "LastModifiedBy", "PaymentMethodID" },
                values: new object[,]
                {
                    { new Guid("0bd9818a-5ef1-45e3-a6fe-0c932f970fe8"), 2000000.0, null, new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3364), new Guid("01d31c40-14c9-444c-a2fe-f58ea0fbc08a"), 125000.0, false, null, null, new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2") },
                    { new Guid("4e917707-0edb-49da-b6f4-804d2c52821b"), 150000.0, null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3341), new Guid("0512a248-0054-4616-ade5-ae412f4f07bd"), 60000.0, false, null, null, new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2") },
                    { new Guid("8efb8acc-2eb9-448d-bfa2-825995f50b59"), 0.0, null, new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(3354), new Guid("ecf95bf5-d766-4b6e-94a7-d33ea29c0618"), 30000.0, false, null, null, new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "OrderID", "Price", "ProductID", "Quanity" },
                values: new object[] { new Guid("05a027a2-01b0-40d2-91f7-2a33fc29753f"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(800), false, null, null, new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"), 125000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "OrderID", "Price", "ProductID", "Quanity" },
                values: new object[] { new Guid("a8b7026d-5def-44ef-9666-6b78682a77cc"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(794), false, null, null, new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"), 30000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "OrderID", "Price", "ProductID", "Quanity" },
                values: new object[] { new Guid("f6d015a9-d5bb-40e8-a287-623f0af19fc9"), null, new DateTime(2023, 10, 17, 22, 13, 46, 441, DateTimeKind.Local).AddTicks(787), false, null, null, new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"), 60000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"), 2 });

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
                name: "IX_Customer_ApplicationUserId",
                table: "Customer",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menu_Product_MenuID",
                table: "Menu_Product",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_Menu_Product_ProductID",
                table: "Menu_Product",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");

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
                name: "IX_WithDraw_CustomerID",
                table: "WithDraw",
                column: "CustomerID");

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
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Trip");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Route");
        }
    }
}
