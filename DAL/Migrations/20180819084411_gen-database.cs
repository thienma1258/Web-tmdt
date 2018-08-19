using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class gendatabase : Migration
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
                name: "Brand",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DefaultImage = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
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
                    CreatedUser = table.Column<string>(nullable: true),
                    DefaultImage = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
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
                    Id = table.Column<string>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    CMND = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    ConfirmCode = table.Column<string>(nullable: true),
                    CustomerName = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<string>(nullable: true),
                    CustomerStateEnum = table.Column<int>(nullable: false),
                    DefaultImage = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    Prestige = table.Column<int>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    TypeCustomerEnum = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CM_Customer", x => x.Id);
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
                name: "HomeCarousel",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
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
                    CreatedUser = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
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
                    CreatedUser = table.Column<string>(nullable: true),
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
                    CreatedUser = table.Column<string>(nullable: true),
                    DefaultImage = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_MainGroup", x => x.ID);
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
                name: "SubscribeEmail",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscribeEmail", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "System_Permission",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
                    PermissionCode = table.Column<string>(nullable: true),
                    PermissionName = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Permission", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "System_Position",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    NamePosition = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Position", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TransportType",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Prestige = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Voucher",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    DiscoutRate = table.Column<int>(nullable: false),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
                    ExperiedTime = table.Column<DateTime>(nullable: false),
                    UniqueCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voucher", x => x.ID);
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
                name: "SubGroup",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DefaultImage = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
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
                        name: "FK_SubGroup_MainGroup",
                        column: x => x.MainGroupID,
                        principalTable: "MainGroup",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Systemm_User_Permission",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<DateTime>(nullable: false),
                    ReviewUserName = table.Column<string>(nullable: true),
                    System_PermissionID = table.Column<string>(nullable: true),
                    UserName = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Systemm_User_Permission", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserPermission_SystemPermission",
                        column: x => x.System_PermissionID,
                        principalTable: "System_Permission",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "System_User",
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
                    table.PrimaryKey("PK_System_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Position_Users",
                        column: x => x.PositionID,
                        principalTable: "System_Position",
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
                    CreatedUser = table.Column<string>(nullable: true),
                    CurrentTransportPrice = table.Column<decimal>(nullable: false),
                    CustomerID = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    DistrictID = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
                    IsPay = table.Column<bool>(nullable: false),
                    PaymentMethod = table.Column<int>(nullable: false),
                    ReceiveAddress = table.Column<string>(nullable: true),
                    ReviewBy = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<DateTime>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false),
                    TransportPriceID = table.Column<string>(nullable: true),
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleOrder_TransportType_TransportPriceID",
                        column: x => x.TransportPriceID,
                        principalTable: "TransportType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Voucher_SaleOrders",
                        column: x => x.VoucherID,
                        principalTable: "Voucher",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    BrandID = table.Column<string>(nullable: true),
                    CategoryID = table.Column<string>(nullable: true),
                    CommentArea = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DefaultImage = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    Details = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
                    IsAllowComment = table.Column<bool>(nullable: false),
                    LadingPage = table.Column<string>(nullable: true),
                    MetaDescription = table.Column<string>(nullable: true),
                    MetaKey = table.Column<string>(nullable: true),
                    MetaTitle = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Specification = table.Column<string>(nullable: true),
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
                        name: "FK_Brand_Products",
                        column: x => x.BrandID,
                        principalTable: "Brand",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Category_Products",
                        column: x => x.CategoryID,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_SubGroup_SubGroupID",
                        column: x => x.SubGroupID,
                        principalTable: "SubGroup",
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
                    CreatedUser = table.Column<string>(nullable: true),
                    DefaultImage = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DistrictID = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
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
                    table.ForeignKey(
                        name: "FK_Store_District",
                        column: x => x.DistrictID,
                        principalTable: "District",
                        principalColumn: "DistrictID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransportPrice",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    DistrictID = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    TransportTypeID = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportPrice", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TransportPrice_District_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "District",
                        principalColumn: "DistrictID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TransportType_TransportPrice",
                        column: x => x.TransportTypeID,
                        principalTable: "TransportType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
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
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_System_User_UserId",
                        column: x => x.UserId,
                        principalTable: "System_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_System_User_UserId",
                        column: x => x.UserId,
                        principalTable: "System_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_System_User_UserId",
                        column: x => x.UserId,
                        principalTable: "System_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_System_User_UserId",
                        column: x => x.UserId,
                        principalTable: "System_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "System_Policy",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<DateTime>(nullable: false),
                    ReviewUserID = table.Column<string>(nullable: true),
                    System_PositionID = table.Column<string>(nullable: true),
                    System_Position_Policy = table.Column<string>(nullable: true),
                    System_Position_Policy_Value = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Policy", x => x.ID);
                    table.ForeignKey(
                        name: "FK_System_Policy_System_User_ReviewUserID",
                        column: x => x.ReviewUserID,
                        principalTable: "System_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_System_Position_Policies",
                        column: x => x.System_PositionID,
                        principalTable: "System_Position",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Discout",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    DiscoutRate = table.Column<int>(nullable: false),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
                    EndTime = table.Column<DateTime>(nullable: false),
                    IsUsed = table.Column<bool>(nullable: false),
                    ProductID = table.Column<string>(nullable: true),
                    StartTime = table.Column<DateTime>(nullable: false),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discout", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Discout_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DefaultImage = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
                    MaxQuantityBuy = table.Column<int>(nullable: false),
                    Note = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ProductID = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Size = table.Column<int>(nullable: false),
                    Specification = table.Column<string>(nullable: true),
                    StockMin = table.Column<int>(nullable: false),
                    TypeColor = table.Column<int>(nullable: false),
                    isDeleted = table.Column<bool>(nullable: false),
                    listImages = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_ProductDetails",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SaleOrderDetail",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    DiscoutID = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    ProductDetailId = table.Column<string>(nullable: true),
                    Quality = table.Column<int>(nullable: false),
                    SaleOrderID = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrderDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Discout_SaleOrderDetails",
                        column: x => x.DiscoutID,
                        principalTable: "Discout",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleOrderDetail_ProductDetails_ProductDetailId",
                        column: x => x.ProductDetailId,
                        principalTable: "ProductDetails",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SaleOrderDetail_SaleOrder_SaleOrderID",
                        column: x => x.SaleOrderID,
                        principalTable: "SaleOrder",
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
                name: "IX_Brand_UrlFriendly",
                table: "Brand",
                column: "UrlFriendly",
                unique: true,
                filter: "[UrlFriendly] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Category_UrlFriendly",
                table: "Category",
                column: "UrlFriendly",
                unique: true,
                filter: "[UrlFriendly] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Discout_ProductID",
                table: "Discout",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_District_ProvinceID",
                table: "District",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_MainGroup_Name",
                table: "MainGroup",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandID",
                table: "Product",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SubGroupID",
                table: "Product",
                column: "SubGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UrlFriendly",
                table: "Product",
                column: "UrlFriendly",
                unique: true,
                filter: "[UrlFriendly] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDetails_ProductID",
                table: "ProductDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_CustomerID",
                table: "SaleOrder",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_TransportPriceID",
                table: "SaleOrder",
                column: "TransportPriceID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_VoucherID",
                table: "SaleOrder",
                column: "VoucherID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetail_DiscoutID",
                table: "SaleOrderDetail",
                column: "DiscoutID");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetail_ProductDetailId",
                table: "SaleOrderDetail",
                column: "ProductDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetail_SaleOrderID",
                table: "SaleOrderDetail",
                column: "SaleOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Store_DistrictID",
                table: "Store",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_SubGroup_MainGroupID",
                table: "SubGroup",
                column: "MainGroupID");

            migrationBuilder.CreateIndex(
                name: "IX_SubGroup_UrlFriendly",
                table: "SubGroup",
                column: "UrlFriendly",
                unique: true,
                filter: "[UrlFriendly] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_System_Permission_PermissionName",
                table: "System_Permission",
                column: "PermissionName",
                unique: true,
                filter: "[PermissionName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_System_Policy_ReviewUserID",
                table: "System_Policy",
                column: "ReviewUserID");

            migrationBuilder.CreateIndex(
                name: "IX_System_Policy_System_PositionID",
                table: "System_Policy",
                column: "System_PositionID");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "System_User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "System_User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_System_User_PositionID",
                table: "System_User",
                column: "PositionID");

            migrationBuilder.CreateIndex(
                name: "IX_Systemm_User_Permission_System_PermissionID",
                table: "Systemm_User_Permission",
                column: "System_PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_TransportPrice_DistrictID",
                table: "TransportPrice",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_TransportPrice_TransportTypeID",
                table: "TransportPrice",
                column: "TransportTypeID");
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
                name: "ErrorLogs");

            migrationBuilder.DropTable(
                name: "HomeCarousel");

            migrationBuilder.DropTable(
                name: "HomeSlider");

            migrationBuilder.DropTable(
                name: "ImageUploadLog");

            migrationBuilder.DropTable(
                name: "SaleOrderDetail");

            migrationBuilder.DropTable(
                name: "Store");

            migrationBuilder.DropTable(
                name: "SubscribeEmail");

            migrationBuilder.DropTable(
                name: "System_Policy");

            migrationBuilder.DropTable(
                name: "Systemm_User_Permission");

            migrationBuilder.DropTable(
                name: "TransportPrice");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Discout");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "SaleOrder");

            migrationBuilder.DropTable(
                name: "System_User");

            migrationBuilder.DropTable(
                name: "System_Permission");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "CM_Customer");

            migrationBuilder.DropTable(
                name: "TransportType");

            migrationBuilder.DropTable(
                name: "Voucher");

            migrationBuilder.DropTable(
                name: "System_Position");

            migrationBuilder.DropTable(
                name: "Province");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "SubGroup");

            migrationBuilder.DropTable(
                name: "MainGroup");
        }
    }
}
