﻿using System;
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
                    StoreOpenTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    StoreCloseTime = table.Column<TimeSpan>(type: "time", nullable: false),
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
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
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
                        name: "FK_Store_Menu_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Store_Menu_Stores_StoreId",
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
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
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
                    { "647D9649-F5A2-4F24-808F-6FC326EC2AA3", "3a66e26f-988e-4ac6-89d3-84a9f59cc5d9", "Staff", "Staff" },
                    { "AF5EB4AC-219A-4BC1-99FE-8C23876536EA", "eba297e2-943e-4040-ac29-5830258ac6a0", "Admin", "Admin" },
                    { "CF531396-C1CD-427B-9D17-0383B7675394", "c8510564-4ef1-408d-be47-e3427933905e", "EndUser", "EndUser" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1F11BA64-2870-43F7-BB03-867112867F25", 0, "24a5ed8a-de48-4a7c-b700-47e645cf1013", "thaivin537@gmail.com", true, "Thái", "Vĩ", false, null, "THAIVIN537@GMAIL.COM", "THAIVIN537@GMAIL.COM", "AQAAAAEAACcQAAAAEAjQiVKPHzT46f21U9RPLe01WfFFIPYVAFG4T9ehSvjjakcG/ROyIK2zYDI65SxeXg==", null, false, "23f50ebe-3fb0-4670-b410-996316049317", false, "thaivin537@gmail.com" },
                    { "2198E4CD-3305-49C5-B78A-0B54DD76898F", 0, "b1835733-70d2-4d9e-8e06-e12a0e44cfbe", "admin@gmail.com", true, "Nhan", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEN4eODOYUji0w4KV2AOnwYDMML9wNOQp2v+jphjI/LcOXgIXxtADcIa49ZydlBCFgA==", null, false, "36a7dfc5-eb49-4aef-89ad-2764b1092504", false, "admin@gmail.com" },
                    { "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84", 0, "b9d4f247-14fe-4e78-bca3-aec810eef175", "staff@gmail.com", true, "Vi", "Staff", false, null, "STAFF@GMAIL.COM", "STAFF@GMAIL.COM", "AQAAAAEAACcQAAAAEPLf8Vc/tB5c3iSJUM8V8aLzF4ScaHMNvlVWnwdY9TXEilDT34vohnpEXyQC51BIJQ==", null, false, "6110d965-02c0-4ed7-8ebe-e2e74437d78f", false, "staff@gmail.com" },
                    { "2E089AF6-3437-4DD6-9956-BB792E783AFB", 0, "0d9c0f51-2fbc-41f5-9698-70c9152fcbf2", "nguyenthanhn537@gmail.com", true, "Nhân", "Nguyễn", false, null, "NGUYENTHANHN537@GMAIL.COM", "NGUYENTHANHN537@GMAIL.COM", "AQAAAAEAACcQAAAAEEI1yrdL3/ffT4puIl4kA7lhKJtMyUDT/YzunI2BB7Nql4tRQRdkKVgvEnm8upSSng==", null, false, "67431709-6b79-4710-a701-5116555677e9", false, "nguyenthanhn537@gmail.com" },
                    { "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9", 0, "e5e35435-d849-4187-8f67-fa66c73bb817", "anhjenda537@gmail.com", true, "Anh", "Da Đen", false, null, "ANHJENDA537@GMAIL.COM", "ANHJENDA537@GMAIL.COM", "AQAAAAEAACcQAAAAELhbtO63fsnvkjpJ7FC6liqLQD8NFP+xTR4RWTgZcsqo3l14eG+GbBG9OUuA/ARO/A==", null, false, "c3c7508c-7a95-4853-ab38-a9ff08a06f48", false, "anhjenda537@gmail.com" },
                    { "E6DE8827-B7C2-46E9-9227-66E6ECE676A8", 0, "69eef785-2472-42b3-83b9-185e2a108661", "enduser@gmail.com", true, "Vi", "EndUser", false, null, "ENDUSER@GMAIL.COM", "ENDUSER@GMAIL.COM", "AQAAAAEAACcQAAAAELCuOl9PO5fJ8nRtbQhQodEGsqyE1mZRZWA1jpTiPMIjK7w4ckRZFZoqOarayXcO3g==", null, false, "b19d9625-f611-4df1-9049-a94950a6fd58", false, "enduser@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy" },
                values: new object[,]
                {
                    { new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), "Candy", null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6273), false, null, null },
                    { new Guid("39696f0c-2c8a-480f-b917-141b7da708e4"), "Dairy", null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6279), false, null, null },
                    { new Guid("4078ef19-ba53-481d-9c5a-1c37dfe0e0dc"), "Beverages", null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6268), false, null, null },
                    { new Guid("8908ea98-b421-420b-9634-03ed356bb921"), "Chips", null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6275), false, null, null },
                    { new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), "Food", null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6242), false, null, null },
                    { new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"), "Cookies", null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6277), false, null, null },
                    { new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"), "Bread", null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6271), false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "CreateBy", "Created", "EndTimeService", "IsDelete", "LastModified", "LastModifiedBy", "StartTimeService" },
                values: new object[,]
                {
                    { new Guid("47a91dd5-f999-461a-8f80-935d169ca0c3"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6653), new TimeSpan(0, 17, 0, 0, 0), false, null, null, new TimeSpan(0, 13, 0, 0, 0) },
                    { new Guid("4cbf8910-c204-46fe-91d4-e8e4c94ff695"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6671), new TimeSpan(0, 5, 0, 0, 0), false, null, null, new TimeSpan(0, 1, 0, 0, 0) },
                    { new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6642), new TimeSpan(0, 11, 0, 0, 0), false, null, null, new TimeSpan(0, 8, 0, 0, 0) },
                    { new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6648), new TimeSpan(0, 13, 0, 0, 0), false, null, null, new TimeSpan(0, 11, 0, 0, 0) },
                    { new Guid("bbc7d071-5f5b-40be-b25e-3aa07a6c3e7c"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6663), new TimeSpan(0, 0, 0, 0, 0), false, null, null, new TimeSpan(0, 20, 0, 0, 0) },
                    { new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6658), new TimeSpan(0, 20, 0, 0, 0), false, null, null, new TimeSpan(0, 17, 0, 0, 0) },
                    { new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6597), new TimeSpan(0, 8, 0, 0, 0), false, null, null, new TimeSpan(0, 6, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "PaymentMethodName" },
                values: new object[,]
                {
                    { new Guid("36672051-5437-4d2c-a42e-c71a9b67a2b1"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7166), false, null, null, "thanh toán trên app MetroPickUp" },
                    { new Guid("47bd4dd4-3fb4-463e-b9b9-5ebfb7e1f960"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7164), false, null, null, "thanh toán qua momo" },
                    { new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7155), false, null, null, "thanh toán tiền mặt" },
                    { new Guid("7db43916-e061-42cb-b0a7-9734423d00cd"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7162), false, null, null, "thanh toán ngân hàng" }
                });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "Id", "CreateBy", "Created", "FromLocation", "IsDelete", "LastModified", "LastModifiedBy", "ToLocation" },
                values: new object[,]
                {
                    { new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7683), "Quận 1, Tp.Hcm", false, null, null, "Suối Tiên, Đồng Nai" },
                    { new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7695), "Quận Bình Thạnh", false, null, null, "Bến Thành, Quận 1, TP HCM" },
                    { new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7685), "Quận 1, Tp.Hcm", false, null, null, "Quận Thủ Đức, Tp.Hcm" },
                    { new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7690), "Quận 1, Tp.Hcm", false, null, null, "Bến xe Miền Đông" },
                    { new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7688), "Quận 1, Tp.Hcm", false, null, null, "Quận Bình Thạnh, Tp.Hcm" },
                    { new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7678), "Quận 1, Tp.Hcm", false, null, null, "Quận 9, Tp.Hcm" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StoreCloseTime", "StoreLocation", "StoreName", "StoreOpenTime" },
                values: new object[,]
                {
                    { new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8303), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Số 1, Võ Văn Ngân, Thành Phố Thủ Đức", "Metro PickUp 3", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8322), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Bến Xe Miền Đông", "Metro PickUp 6", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8308), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Khu Công Nghệ Cao Thành Phố Thủ Đức ", "Metro PickUp 4", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8280), false, null, null, new TimeSpan(0, 23, 0, 0, 0), "Số 2, Đường Lê Lai, Quận 1", "Metro PickUp 1", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8297), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Số 3, Vincom, Quận Bình Thạnh", "Metro PickUp 2", new TimeSpan(0, 6, 0, 0, 0) },
                    { new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8316), false, null, null, new TimeSpan(0, 6, 0, 0, 0), "Suối tiên", "Metro PickUp 5", new TimeSpan(0, 6, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "TripEndTime", "TripName", "TripStartTime" },
                values: new object[,]
                {
                    { new Guid("02859382-d88c-4e69-8c47-b8e0456677d5"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8689), false, null, null, new DateTime(2023, 9, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), "Cruise Vacation", new DateTime(2023, 9, 10, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8700), false, null, null, new DateTime(2023, 11, 14, 17, 0, 0, 0, DateTimeKind.Unspecified), "Hiking Adventure", new DateTime(2023, 11, 12, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8711), false, null, null, new DateTime(2023, 12, 23, 14, 0, 0, 0, DateTimeKind.Unspecified), "Ski Getaway", new DateTime(2023, 12, 20, 8, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "TripEndTime", "TripName", "TripStartTime" },
                values: new object[,]
                {
                    { new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8569), false, null, null, new DateTime(2023, 7, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "Camping Trip", new DateTime(2023, 7, 15, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a2ba7d5-7019-49c6-a47d-ab0a072e7932"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8744), false, null, null, new DateTime(2023, 10, 3, 17, 0, 0, 0, DateTimeKind.Unspecified), "African Safari", new DateTime(2023, 9, 28, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b4d232c-0fda-4ec0-beed-ecd649ee9c52"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8722), false, null, null, new DateTime(2023, 8, 18, 21, 0, 0, 0, DateTimeKind.Unspecified), "Tropical Vacation", new DateTime(2023, 8, 13, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8677), false, null, null, new DateTime(2023, 5, 25, 20, 0, 0, 0, DateTimeKind.Unspecified), "Road Trip", new DateTime(2023, 5, 20, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf736039-33e9-466f-ac4e-78c89f3317e6"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8733), false, null, null, new DateTime(2023, 7, 6, 23, 0, 0, 0, DateTimeKind.Unspecified), "Amusement Park Fun", new DateTime(2023, 7, 4, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9852f0d-e836-4a6e-94f4-d229b297933d"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8755), false, null, null, new DateTime(2023, 5, 8, 15, 0, 0, 0, DateTimeKind.Unspecified), "Botanical Gardens Tour", new DateTime(2023, 5, 6, 13, 0, 0, 0, DateTimeKind.Unspecified) }
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
                    { new Guid("01d31c40-14c9-444c-a2fe-f58ea0fbc08a"), "Gia Lai", "2E089AF6-3437-4DD6-9956-BB792E783AFB", new DateTime(1998, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8931), false, null, null, "0914009910" },
                    { new Guid("0512a248-0054-4616-ade5-ae412f4f07bd"), "Cần Thơ", "C4EE82A1-DB88-49A6-81A8-4B9521FF01F9", new DateTime(2002, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8922), false, null, null, "0961868641" },
                    { new Guid("b9cf3487-3d04-4cbf-85b7-e33360566485"), "hcm", "2198E4CD-3305-49C5-B78A-0B54DD76898F", new DateTime(2010, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8916), false, null, null, "03030303" },
                    { new Guid("ecf95bf5-d766-4b6e-94a7-d33ea29c0618"), "Đắk Lắk", "1F11BA64-2870-43F7-BB03-867112867F25", new DateTime(1899, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8926), false, null, null, "0903182861" },
                    { new Guid("f9589c1a-3cbc-4215-bb84-b8fa7d719440"), "da nang", "2C0B43BB-B991-408E-A8F3-2FD3B4A2AB84", new DateTime(2002, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8883), false, null, null, "03030303" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryID", "CreateBy", "Created", "Image", "IsDelete", "LastModified", "LastModifiedBy", "Price", "ProductDescription", "ProductName", "Stock" },
                values: new object[,]
                {
                    { new Guid("0c308b93-b26a-4224-9d63-28294711aa15"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7323), null, false, null, null, 50000.0, "Gà rán giòn tan thơm ngon", "Gà rán", 500 },
                    { new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7326), null, false, null, null, 65000.0, "Cá chiên giòn rụm", "Cá chiên", 300 },
                    { new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7307), null, false, null, null, 30000.0, "Cơm gà xé thơm ngon", "Cơm gà xé", 200 },
                    { new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7342), null, false, null, null, 25000.0, "Cơm chiên dương châu thơm ngon", "Cơm chiên dương châu", 1000 },
                    { new Guid("45da4260-ba13-489b-995a-1f6adb13ab75"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7276), null, false, null, null, 5000.5, "Kẹo thơm ngon được tạo ra từ các loại đường, được làm nóng và tạo nên hương vị ngọt ngào", "Keo bông gòn", 300 },
                    { new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"), new Guid("9afcdfac-1a27-496b-84e5-0c8e5804e40e"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7339), null, false, null, null, 80000.0, "Gà nướng thơm phức", "Gà nướng", 800 },
                    { new Guid("4ecd72e3-f43d-490f-8b46-8e92ea29f85c"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7318), null, false, null, null, 15000.0, "Kẹo dâu tây thơm ngon", "Kẹo dâu", 800 },
                    { new Guid("55265d3b-fa02-4e09-84db-d4e8c8a9a9b5"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7329), null, false, null, null, 5000.0, "Kẹo bạc hà mát lạnh", "Kẹo bạc hà", 1200 },
                    { new Guid("6d60bf44-b775-4d87-bb47-aace85d49ac4"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7296), null, false, null, null, 2500.0, "Kẹo dẻo mềm, đàn hồi", "Kẹo dẻo", 500 },
                    { new Guid("7d661a30-e180-498c-9a77-cb6112a7cb22"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7282), null, false, null, null, 3000.0, "Kẹo lạc thơm ngon, giòn tan", "Kẹo lạc", 200 },
                    { new Guid("7da34092-5747-42b7-b059-4a5aad57e740"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7287), null, false, null, null, 3000.0, "Kẹo lạc thơm ngon, giòn tan", "Kẹo chup", 200 },
                    { new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c"), new Guid("8908ea98-b421-420b-9634-03ed356bb921"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7293), null, false, null, null, 10000.0, "Khoai tây chiên giòn tan", "Khoai tây chiên", 500 },
                    { new Guid("d4fe048d-ff12-4715-93e7-3250f49c15c8"), new Guid("9b2cccb2-f5fa-4358-8265-0fe4f7a52253"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7311), null, false, null, null, 5000.0, "Bánh quy giòn tan trong miệng", "Bánh quy giòn", 1000 },
                    { new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"), new Guid("b7a3a853-73c6-4f02-913b-9765019e9bd0"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7345), null, false, null, null, 25000.0, "Bánh mì siêu topping thịt trứng cút, ăn là ghiền!!!", "Bánh mì Sài Gòn", 1000 },
                    { new Guid("f31c789c-4a46-45c7-9009-d36681d788c5"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7315), null, false, null, null, 10000.0, "Kẹo sô cô la ngọt thanh", "Kẹo Socola", 1000 },
                    { new Guid("ffb05663-954d-4af3-8a41-91af39446f81"), new Guid("175d4c8d-d2f0-441b-85cb-45a1cb0b6756"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7334), null, false, null, null, 2500.0, "Kẹo mút mềm dẻo", "Kẹo mút", 2000 }
                });

            migrationBuilder.InsertData(
                table: "Stations",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "StationName", "StoreID" },
                values: new object[,]
                {
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7926), false, null, null, "Ga Metro Bến Thành", new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7935), false, null, null, "Ga Metro Vincom Bình Thạnh", new Guid("d3599df7-877e-41c7-832d-14850e5c88bd") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7938), false, null, null, "Ga Metro Chợ Thủ Đức", new Guid("2f3eee35-1b8e-43af-956f-eacd94eea7cd") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7943), false, null, null, "Ga Metro Khu Công Nghệ Cao", new Guid("70c6a937-f285-4495-8407-b20a0c9b10f3") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7946), false, null, null, "Ga Metro Suối Tiên", new Guid("ef443e4b-886c-4c06-8528-51e9cf623867") },
                    { new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7949), false, null, null, "Ga Metro Bến xe Miền Đông", new Guid("6507b7db-7255-4274-87a4-6e2dc3d8a3c4") }
                });

            migrationBuilder.InsertData(
                table: "Store_Menu",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuId", "StoreId" },
                values: new object[,]
                {
                    { new Guid("222c267d-53da-4f56-ac69-84865ddf14a0"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8107), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("7595bf7c-3c84-4abe-a370-cf83a7ff80cd"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8100), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("86502279-0dde-419f-86c6-f949f24d398f"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8097), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("b87b1cec-1cef-4c3c-99e6-cc695f388339"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8105), false, null, null, new Guid("47a91dd5-f999-461a-8f80-935d169ca0c3"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("c5d4f2ac-908e-4bf6-8cfd-497d281050e6"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8093), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("d8568248-f92a-4f11-ac50-e85a5103b410"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8110), false, null, null, new Guid("bbc7d071-5f5b-40be-b25e-3aa07a6c3e7c"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") },
                    { new Guid("ff58cecb-e3e8-4027-a14b-31f7bb45a9df"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8112), false, null, null, new Guid("4cbf8910-c204-46fe-91d4-e8e4c94ff695"), new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8") }
                });

            migrationBuilder.InsertData(
                table: "Trip_Routes",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RouteID", "TripID" },
                values: new object[,]
                {
                    { new Guid("414b77cf-5470-49e9-9f31-72c3551ff314"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8448), false, null, null, new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"), new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") },
                    { new Guid("82802a39-69ea-4ea9-a079-9b2792b391df"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8435), false, null, null, new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") }
                });

            migrationBuilder.InsertData(
                table: "Trip_Routes",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RouteID", "TripID" },
                values: new object[] { new Guid("a3119ce1-8f30-412e-8ee8-9b404250f3ae"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8446), false, null, null, new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"), new Guid("5b30c4e9-31ab-456c-b212-dc6b2ba9a3e7") });

            migrationBuilder.InsertData(
                table: "Trip_Routes",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RouteID", "TripID" },
                values: new object[] { new Guid("e1109f86-d005-454c-9c97-02f243bb6c31"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8440), false, null, null, new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), new Guid("02859382-d88c-4e69-8c47-b8e0456677d5") });

            migrationBuilder.InsertData(
                table: "Trip_Routes",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RouteID", "TripID" },
                values: new object[] { new Guid("efe2470e-4e47-4b00-918f-8057129389b0"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(8443), false, null, null, new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"), new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") });

            migrationBuilder.InsertData(
                table: "Menu_Products",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "MenuID", "PriceOfProductBelongToTimeService", "ProductID" },
                values: new object[,]
                {
                    { new Guid("09f5d2e1-6023-4a89-8126-34023a902971"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6467), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 25000.0, new Guid("b834cf11-cc28-4e7d-9846-2acc8ad33d8c") },
                    { new Guid("4b27ea2c-cfc3-4166-97d0-84b9a8acc29c"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6453), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 50000.0, new Guid("107f1f75-b23b-4bc4-92d7-f2e90d067d1f") },
                    { new Guid("6985452d-81a2-4369-92ba-401c0e9d16d7"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6465), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 100000.0, new Guid("0c308b93-b26a-4224-9d63-28294711aa15") },
                    { new Guid("780110d0-8642-485a-ac02-d9f7fc0b1d01"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6458), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 35000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("82347343-e5de-44d8-8985-ce74f776b326"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6433), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 20000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b") },
                    { new Guid("9ca334ae-2624-4323-85d9-b365818864f3"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6456), false, null, null, new Guid("9b08173a-e338-45ef-b479-6b0e95f2b055"), 35000.0, new Guid("1616cc05-8c82-4f8b-a6e0-f60ab3de0d38") },
                    { new Guid("af486165-92b4-4927-b7eb-5ae672d6ae99"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6445), false, null, null, new Guid("e7a15238-5db0-49bd-94e6-d5f8b77ae6ce"), 15000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341") },
                    { new Guid("c7a05bad-d1ba-4745-a9a3-5305905cc0c7"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6461), false, null, null, new Guid("d6184ea2-9833-499f-9a56-8138c3b60c78"), 159000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6") },
                    { new Guid("e1e3e276-96a0-4a54-8242-a0e6474c26f2"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6449), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 1000.0, new Guid("ffb05663-954d-4af3-8a41-91af39446f81") },
                    { new Guid("f4471198-c098-4464-84d4-7bb5360b2efb"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6451), false, null, null, new Guid("5263453c-dae9-45e4-8204-5430a7256cde"), 30000.0, new Guid("f31c789c-4a46-45c7-9009-d36681d788c5") }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CreateBy", "Created", "CustomerID", "IsDelete", "LastModified", "LastModifiedBy", "OrderTokenQR", "StoreID", "TotalPrice", "TripID" },
                values: new object[,]
                {
                    { new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6803), new Guid("01d31c40-14c9-444c-a2fe-f58ea0fbc08a"), false, null, null, "1231212QR", new Guid("d3599df7-877e-41c7-832d-14850e5c88bd"), 0.0, new Guid("27421cac-1da7-4df8-9928-7fb636ca42aa") },
                    { new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6793), new Guid("0512a248-0054-4616-ade5-ae412f4f07bd"), false, null, null, "1231212QR", new Guid("ef443e4b-886c-4c06-8528-51e9cf623867"), 0.0, new Guid("823ad122-7b51-4dab-9d37-b0f238d4a2ff") },
                    { new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6799), new Guid("ecf95bf5-d766-4b6e-94a7-d33ea29c0618"), false, null, null, "11789212QR", new Guid("aa2610a8-de94-42b7-b12b-1cf8710e05d8"), 0.0, new Guid("9c2ab923-4c57-44d7-9c1a-b44c0d3e6b00") }
                });

            migrationBuilder.InsertData(
                table: "Route_Stations",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "RouteID", "StationID" },
                values: new object[,]
                {
                    { new Guid("1b22bdb7-1688-42fa-8fae-4af92e32df7f"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7539), false, null, null, new Guid("ccc66514-0597-4d43-aaff-0c5d8ee59ffa"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c5") },
                    { new Guid("2ff9d0d9-474c-4466-b9a8-707b730f415c"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7543), false, null, null, new Guid("a437b242-55fc-4146-a2b9-8c952b107e3a"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c6") },
                    { new Guid("5004477e-1446-467d-8157-972185d64290"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7556), false, null, null, new Guid("42f184eb-58b3-4b9b-be52-1da57f8ffb3f"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c4") },
                    { new Guid("6a82db5a-23cf-4764-b7d1-ccabce5cc317"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7551), false, null, null, new Guid("b9f8f712-92ee-4611-ad55-000a8e1b84c6"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c9") },
                    { new Guid("6e841857-2712-4da3-a15f-aed820adef5a"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7530), false, null, null, new Guid("ea675490-eecd-4308-bb71-61b72a9c979f"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c7") },
                    { new Guid("ab2099b4-e511-42ff-9e6a-ee71bddcd482"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(7548), false, null, null, new Guid("001a254c-02d4-40e7-a01f-95f393fb41ef"), new Guid("50cb67f8-421e-4aec-85ed-7114e763d6c8") }
                });

            migrationBuilder.InsertData(
                table: "WithDraws",
                columns: new[] { "Id", "Balance", "CreateBy", "CreateTimeOfWithdraw", "Created", "CustomerID", "Deposit", "IsDelete", "LastModified", "LastModifiedBy", "PaymentMethodID" },
                values: new object[,]
                {
                    { new Guid("0bd9818a-5ef1-45e3-a6fe-0c932f970fe8"), 2000000.0, null, new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(9124), new Guid("01d31c40-14c9-444c-a2fe-f58ea0fbc08a"), 125000.0, false, null, null, new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2") },
                    { new Guid("4e917707-0edb-49da-b6f4-804d2c52821b"), 150000.0, null, new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(9105), new Guid("0512a248-0054-4616-ade5-ae412f4f07bd"), 60000.0, false, null, null, new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2") },
                    { new Guid("8efb8acc-2eb9-448d-bfa2-825995f50b59"), 0.0, null, new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(9118), new Guid("ecf95bf5-d766-4b6e-94a7-d33ea29c0618"), 30000.0, false, null, null, new Guid("71b4bf27-e569-47a0-b16a-e484533bd9f2") }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "OrderID", "Price", "ProductID", "Quanity" },
                values: new object[] { new Guid("05a027a2-01b0-40d2-91f7-2a33fc29753f"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6971), false, null, null, new Guid("814860c5-ab72-4605-bb47-7e78c78d6fb0"), 125000.0, new Guid("4c9ec4b9-1c16-4c7a-90bf-d620aab257b6"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "OrderID", "Price", "ProductID", "Quanity" },
                values: new object[] { new Guid("a8b7026d-5def-44ef-9666-6b78682a77cc"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6967), false, null, null, new Guid("d68ee4e5-980e-4ec7-8060-df214d458c79"), 30000.0, new Guid("43203ce4-d82c-4c78-8794-2aef22d7ec5b"), 1 });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "CreateBy", "Created", "IsDelete", "LastModified", "LastModifiedBy", "OrderID", "Price", "ProductID", "Quanity" },
                values: new object[] { new Guid("f6d015a9-d5bb-40e8-a287-623f0af19fc9"), null, new DateTime(2023, 10, 10, 17, 10, 14, 645, DateTimeKind.Local).AddTicks(6960), false, null, null, new Guid("a8af2f67-447f-4f70-b660-4dd08fa47d4d"), 60000.0, new Guid("e802b6c5-f08e-4eff-b7e7-af95514b4341"), 2 });

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
                name: "IX_Store_Menu_MenuId",
                table: "Store_Menu",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_Menu_StoreId",
                table: "Store_Menu",
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
                name: "Store_Menu");

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