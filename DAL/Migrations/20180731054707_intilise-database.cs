using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class intilisedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ErrorLogs",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    ErrorLog = table.Column<string>(nullable: true),
                    FunctionName = table.Column<string>(nullable: true),
                    ModuleName = table.Column<string>(nullable: true),
                    TableName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLogs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    ProvinceID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.ProvinceID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<string>(nullable: false)
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
                name: "District",
                columns: table => new
                {
                    DistrictID = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ProvinceID = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.DistrictID);
                    table.ForeignKey(
                        name: "FK_District_Province_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "Province",
                        principalColumn: "ProvinceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ward",
                columns: table => new
                {
                    WardId = table.Column<string>(nullable: false),
                    DistrictID = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ward", x => x.WardId);
                    table.ForeignKey(
                        name: "FK_Ward_District_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "District",
                        principalColumn: "DistrictID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
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
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DefaultImage = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKey = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UrlFriendly = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DefaultImage = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKey = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UrlFriendly = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CM_Customer",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    AuthenticationID = table.Column<string>(nullable: true),
                    CMNN = table.Column<string>(nullable: true),
                    ConfirmCode = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    CustomerAddress = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<string>(nullable: true),
                    CustomerStateEnum = table.Column<int>(nullable: false),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Prestige = table.Column<int>(nullable: false),
                    TypeCustomerEnum = table.Column<int>(nullable: false),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CM_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Discout",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    DiscoutRate = table.Column<int>(nullable: false),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discout", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HomeCarousel",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    IsHiding = table.Column<bool>(nullable: false),
                    OrderIndex = table.Column<int>(nullable: false),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeCarousel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HomeSlider",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    OrderIndex = table.Column<int>(nullable: false),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeSlider", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ImageUploadLog",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    Erros = table.Column<string>(nullable: true),
                    IdImage = table.Column<string>(nullable: true),
                    ImageUploadEnum = table.Column<int>(nullable: false),
                    IsSuccess = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageUploadLog", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MainGroup",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DefaultImage = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKey = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TypeSex = table.Column<int>(nullable: false),
                    UrlFriendly = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainGroup", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    BrandID = table.Column<string>(nullable: true),
                    CategoryID = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    DiscoutID = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    LadingPage = table.Column<string>(nullable: true),
                    MainGroupID = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKey = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    StockMin = table.Column<int>(nullable: false),
                    SubGroupID = table.Column<string>(nullable: true),
                    UrlFriendly = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false),
                    isOnlineOnly = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Brand_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brand",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Discout_DiscoutID",
                        column: x => x.DiscoutID,
                        principalTable: "Discout",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_MainGroup_MainGroupID",
                        column: x => x.MainGroupID,
                        principalTable: "MainGroup",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DefaultImage = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    MaxQualityBuy = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ProductID = table.Column<string>(nullable: true),
                    Quality = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Specification = table.Column<string>(nullable: true),
                    StockMin = table.Column<int>(nullable: false),
                    TypeColor = table.Column<int>(nullable: false),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrder",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    AuthenticationMethodGuid = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    CustomerID = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    PaymentMethod = table.Column<int>(nullable: false),
                    ReviewById = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<DateTime>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false),
                    TransportTypeID = table.Column<string>(nullable: true),
                    TransportTypePrice = table.Column<decimal>(nullable: false),
                    VAT = table.Column<int>(nullable: false),
                    VoucherID = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrder", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SaleOrder_CM_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "CM_Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrderDetail",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    DiscoutID = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ProductID = table.Column<string>(nullable: true),
                    Quality = table.Column<int>(nullable: false),
                    SaleOrderID = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrderDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SaleOrderDetail_Discout_DiscoutID",
                        column: x => x.DiscoutID,
                        principalTable: "Discout",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleOrderDetail_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleOrderDetail_SaleOrder_SaleOrderID",
                        column: x => x.SaleOrderID,
                        principalTable: "SaleOrder",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Store",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DefaultImage = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    FAX = table.Column<string>(nullable: true),
                    Lat = table.Column<float>(nullable: false),
                    Lng = table.Column<float>(nullable: false),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKey = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    NameStore = table.Column<string>(nullable: true),
                    UrlFriendly = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Store", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SubGroup",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DefaultImage = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    MainGroupID = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKey = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    TypeSex = table.Column<int>(nullable: false),
                    UrlFriendly = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubGroup", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SubGroup_MainGroup_MainGroupID",
                        column: x => x.MainGroupID,
                        principalTable: "MainGroup",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "System_Policy",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<DateTime>(nullable: false),
                    ReviewUserId = table.Column<string>(nullable: true),
                    System_PositionID = table.Column<string>(nullable: true),
                    System_Position_Policy = table.Column<string>(nullable: true),
                    System_Position_Policy_Value = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Policy", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "System_Position",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    NamePosition = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Position", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    CMND = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    PositionID = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_System_Position_PositionID",
                        column: x => x.PositionID,
                        principalTable: "System_Position",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "System_User_Permission",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    RerviewUserId = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    UserPermission = table.Column<string>(nullable: true),
                    UserPermissionValue = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_User_Permission", x => x.ID);
                    table.ForeignKey(
                        name: "FK_System_User_Permission_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_System_User_Permission_AspNetUsers_DeletedUserId",
                        column: x => x.DeletedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_System_User_Permission_AspNetUsers_EditedUserId",
                        column: x => x.EditedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_System_User_Permission_AspNetUsers_RerviewUserId",
                        column: x => x.RerviewUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_System_User_Permission_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransportType",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Prestige = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportType", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TransportType_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportType_AspNetUsers_DeletedUserId",
                        column: x => x.DeletedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportType_AspNetUsers_EditedUserId",
                        column: x => x.EditedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    DiscoutRate = table.Column<int>(nullable: false),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    ExperiedTime = table.Column<DateTime>(nullable: false),
                    UniqueCode = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Voucher_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voucher_AspNetUsers_DeletedUserId",
                        column: x => x.DeletedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voucher_AspNetUsers_EditedUserId",
                        column: x => x.EditedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransportPrice",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUserId = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUserId = table.Column<string>(nullable: true),
                    DistrictID = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUserId = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    TransportTypeID = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportPrice", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TransportPrice_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportPrice_AspNetUsers_DeletedUserId",
                        column: x => x.DeletedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportPrice_District_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "District",
                        principalColumn: "DistrictID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportPrice_AspNetUsers_EditedUserId",
                        column: x => x.EditedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportPrice_TransportType_TransportTypeID",
                        column: x => x.TransportTypeID,
                        principalTable: "TransportType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_AspNetUsers_PositionID",
                table: "AspNetUsers",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_CreatedUserId",
                table: "Brand",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_DeletedUserId",
                table: "Brand",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_EditedUserId",
                table: "Brand",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CreatedUserId",
                table: "Category",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_DeletedUserId",
                table: "Category",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_EditedUserId",
                table: "Category",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CM_Customer_CreatedUserId",
                table: "CM_Customer",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CM_Customer_DeletedUserId",
                table: "CM_Customer",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_CM_Customer_EditedUserId",
                table: "CM_Customer",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Discout_CreatedUserId",
                table: "Discout",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Discout_DeletedUserId",
                table: "Discout",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Discout_EditedUserId",
                table: "Discout",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_District_ProvinceID",
                table: "District",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_HomeCarousel_CreatedUserId",
                table: "HomeCarousel",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeCarousel_DeletedUserId",
                table: "HomeCarousel",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeCarousel_EditedUserId",
                table: "HomeCarousel",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeSlider_CreatedUserId",
                table: "HomeSlider",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeSlider_DeletedUserId",
                table: "HomeSlider",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HomeSlider_EditedUserId",
                table: "HomeSlider",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageUploadLog_CreatedUserId",
                table: "ImageUploadLog",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MainGroup_CreatedUserId",
                table: "MainGroup",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MainGroup_DeletedUserId",
                table: "MainGroup",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MainGroup_EditedUserId",
                table: "MainGroup",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandID",
                table: "Product",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CreatedUserId",
                table: "Product",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_DeletedUserId",
                table: "Product",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_DiscoutID",
                table: "Product",
                column: "DiscoutID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_EditedUserId",
                table: "Product",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_MainGroupID",
                table: "Product",
                column: "MainGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubGroupID",
                table: "Product",
                column: "SubGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_CreatedUserId",
                table: "ProductDetails",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_DeletedUserId",
                table: "ProductDetails",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_EditedUserId",
                table: "ProductDetails",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductID",
                table: "ProductDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_CreatedUserId",
                table: "SaleOrder",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_CustomerID",
                table: "SaleOrder",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_DeletedUserId",
                table: "SaleOrder",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_EditedUserId",
                table: "SaleOrder",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_ReviewById",
                table: "SaleOrder",
                column: "ReviewById");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_TransportTypeID",
                table: "SaleOrder",
                column: "TransportTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_VoucherID",
                table: "SaleOrder",
                column: "VoucherID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetail_CreatedUserId",
                table: "SaleOrderDetail",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetail_DeletedUserId",
                table: "SaleOrderDetail",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetail_DiscoutID",
                table: "SaleOrderDetail",
                column: "DiscoutID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetail_EditedUserId",
                table: "SaleOrderDetail",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetail_ProductID",
                table: "SaleOrderDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetail_SaleOrderID",
                table: "SaleOrderDetail",
                column: "SaleOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Store_CreatedUserId",
                table: "Store",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_DeletedUserId",
                table: "Store",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_EditedUserId",
                table: "Store",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubGroup_CreatedUserId",
                table: "SubGroup",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubGroup_DeletedUserId",
                table: "SubGroup",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubGroup_EditedUserId",
                table: "SubGroup",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SubGroup_MainGroupID",
                table: "SubGroup",
                column: "MainGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_System_Policy_CreatedUserId",
                table: "System_Policy",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_System_Policy_DeletedUserId",
                table: "System_Policy",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_System_Policy_EditedUserId",
                table: "System_Policy",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_System_Policy_ReviewUserId",
                table: "System_Policy",
                column: "ReviewUserId");

            migrationBuilder.CreateIndex(
                name: "IX_System_Policy_System_PositionID",
                table: "System_Policy",
                column: "System_PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_System_Position_CreatedUserId",
                table: "System_Position",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_System_Position_DeletedUserId",
                table: "System_Position",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_System_Position_EditedUserId",
                table: "System_Position",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_System_User_Permission_CreatedUserId",
                table: "System_User_Permission",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_System_User_Permission_DeletedUserId",
                table: "System_User_Permission",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_System_User_Permission_EditedUserId",
                table: "System_User_Permission",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_System_User_Permission_RerviewUserId",
                table: "System_User_Permission",
                column: "RerviewUserId");

            migrationBuilder.CreateIndex(
                name: "IX_System_User_Permission_UserId",
                table: "System_User_Permission",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportPrice_CreatedUserId",
                table: "TransportPrice",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportPrice_DeletedUserId",
                table: "TransportPrice",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportPrice_DistrictID",
                table: "TransportPrice",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_TransportPrice_EditedUserId",
                table: "TransportPrice",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportPrice_TransportTypeID",
                table: "TransportPrice",
                column: "TransportTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_TransportType_CreatedUserId",
                table: "TransportType",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportType_DeletedUserId",
                table: "TransportType",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportType_EditedUserId",
                table: "TransportType",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Voucher_CreatedUserId",
                table: "Voucher",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Voucher_DeletedUserId",
                table: "Voucher",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Voucher_EditedUserId",
                table: "Voucher",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ward_DistrictID",
                table: "Ward",
                column: "DistrictID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_AspNetUsers_CreatedUserId",
                table: "Brand",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_AspNetUsers_DeletedUserId",
                table: "Brand",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Brand_AspNetUsers_EditedUserId",
                table: "Brand",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_AspNetUsers_CreatedUserId",
                table: "Category",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_AspNetUsers_DeletedUserId",
                table: "Category",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_AspNetUsers_EditedUserId",
                table: "Category",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CM_Customer_AspNetUsers_CreatedUserId",
                table: "CM_Customer",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CM_Customer_AspNetUsers_DeletedUserId",
                table: "CM_Customer",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CM_Customer_AspNetUsers_EditedUserId",
                table: "CM_Customer",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Discout_AspNetUsers_CreatedUserId",
                table: "Discout",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Discout_AspNetUsers_DeletedUserId",
                table: "Discout",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Discout_AspNetUsers_EditedUserId",
                table: "Discout",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeCarousel_AspNetUsers_CreatedUserId",
                table: "HomeCarousel",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeCarousel_AspNetUsers_DeletedUserId",
                table: "HomeCarousel",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeCarousel_AspNetUsers_EditedUserId",
                table: "HomeCarousel",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeSlider_AspNetUsers_CreatedUserId",
                table: "HomeSlider",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeSlider_AspNetUsers_DeletedUserId",
                table: "HomeSlider",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HomeSlider_AspNetUsers_EditedUserId",
                table: "HomeSlider",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ImageUploadLog_AspNetUsers_CreatedUserId",
                table: "ImageUploadLog",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MainGroup_AspNetUsers_CreatedUserId",
                table: "MainGroup",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MainGroup_AspNetUsers_DeletedUserId",
                table: "MainGroup",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MainGroup_AspNetUsers_EditedUserId",
                table: "MainGroup",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_CreatedUserId",
                table: "Product",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_DeletedUserId",
                table: "Product",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_EditedUserId",
                table: "Product",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_SubGroup_SubGroupID",
                table: "Product",
                column: "SubGroupID",
                principalTable: "SubGroup",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_AspNetUsers_CreatedUserId",
                table: "ProductDetails",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_AspNetUsers_DeletedUserId",
                table: "ProductDetails",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDetails_AspNetUsers_EditedUserId",
                table: "ProductDetails",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_AspNetUsers_CreatedUserId",
                table: "SaleOrder",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_AspNetUsers_DeletedUserId",
                table: "SaleOrder",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_AspNetUsers_EditedUserId",
                table: "SaleOrder",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_AspNetUsers_ReviewById",
                table: "SaleOrder",
                column: "ReviewById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_TransportType_TransportTypeID",
                table: "SaleOrder",
                column: "TransportTypeID",
                principalTable: "TransportType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_Voucher_VoucherID",
                table: "SaleOrder",
                column: "VoucherID",
                principalTable: "Voucher",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrderDetail_AspNetUsers_CreatedUserId",
                table: "SaleOrderDetail",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrderDetail_AspNetUsers_DeletedUserId",
                table: "SaleOrderDetail",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrderDetail_AspNetUsers_EditedUserId",
                table: "SaleOrderDetail",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Store_AspNetUsers_CreatedUserId",
                table: "Store",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Store_AspNetUsers_DeletedUserId",
                table: "Store",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Store_AspNetUsers_EditedUserId",
                table: "Store",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubGroup_AspNetUsers_CreatedUserId",
                table: "SubGroup",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubGroup_AspNetUsers_DeletedUserId",
                table: "SubGroup",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubGroup_AspNetUsers_EditedUserId",
                table: "SubGroup",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_System_Policy_AspNetUsers_CreatedUserId",
                table: "System_Policy",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_System_Policy_AspNetUsers_DeletedUserId",
                table: "System_Policy",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_System_Policy_AspNetUsers_EditedUserId",
                table: "System_Policy",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_System_Policy_AspNetUsers_ReviewUserId",
                table: "System_Policy",
                column: "ReviewUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_System_Policy_System_Position_System_PositionID",
                table: "System_Policy",
                column: "System_PositionID",
                principalTable: "System_Position",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_System_Position_AspNetUsers_CreatedUserId",
                table: "System_Position",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_System_Position_AspNetUsers_DeletedUserId",
                table: "System_Position",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_System_Position_AspNetUsers_EditedUserId",
                table: "System_Position",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_System_Position_AspNetUsers_CreatedUserId",
                table: "System_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_System_Position_AspNetUsers_DeletedUserId",
                table: "System_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_System_Position_AspNetUsers_EditedUserId",
                table: "System_Position");

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
                name: "ErrorLogs");

            migrationBuilder.DropTable(
                name: "HomeCarousel");

            migrationBuilder.DropTable(
                name: "HomeSlider");

            migrationBuilder.DropTable(
                name: "ImageUploadLog");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "SaleOrderDetail");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "System_Policy");

            migrationBuilder.DropTable(
                name: "System_User_Permission");

            migrationBuilder.DropTable(
                name: "TransportPrice");

            migrationBuilder.DropTable(
                name: "Ward");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SaleOrder");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Discout");

            migrationBuilder.DropTable(
                name: "SubGroup");

            migrationBuilder.DropTable(
                name: "CM_Customer");

            migrationBuilder.DropTable(
                name: "TransportType");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "MainGroup");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "System_Position");
        }
    }
}
