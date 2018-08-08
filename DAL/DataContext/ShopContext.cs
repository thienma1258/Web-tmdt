using DAL.Model;
using DAL.Model.CM;
using DAL.Model.Log;
using DAL.Model.PM;
using DAL.Model.SM;
using DAL.Model.System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.DataContext
{
    public class ShopContext : IdentityDbContext<System_User>
    {
        private string connectString = "Server=.; Database= ShopTMDT; Integrated Security=True;";
        #region DBsetModel
        #region System
        public DbSet<System_Policy> System_Policies { get; set; }
        public DbSet<System_Position> System_Positions { get; set; }
        public DbSet<System_User_Permission> System_User_Permissions { get; set; }
       public DbSet<System_Permission> System_Permissions { get; set; }

        #endregion
        #region PM
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Province> Provinces { get; set; }
        

        public DbSet<HomeCarousel> HomeCarousels { get; set; }
        public DbSet<HomeSlider> HomeSliders { get; set; }
        public DbSet<MainGroup> MainGroups { get; set; }
        public DbSet<SubGroup> SubGroups { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet <TransportType> TransportTypes { get; set; }
        public DbSet<TransportPrice> TransportPrices { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Discout> Discouts { get; set; }
        #endregion
        public DbSet<CM_Customer> Customers { get; set; }
        #region SM
        public DbSet<SaleOrder> SaleOrders { get; set; }
        public DbSet<SaleOrderDetail> SaleOrderDetails { get; set; }
        #endregion
        #region Log
        public DbSet<ErrorLogs> ErrorLogs{ get; set; }
        public DbSet<ImageUploadLog> ImageUploadLogs { get; set; }

        #endregion
        #endregion
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
        }
     
   
        public ShopContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            #region System
            builder.Entity<System_Policy>().ToTable("System_Policy").HasOne(p => p.System_Position).WithMany(p => p.List_System_Policies).HasForeignKey(p => p.System_PositionID).HasConstraintName("FK_System_Position_Policies");
            builder.Entity<System_User>().ToTable("System_User").HasOne(p => p.Position).WithMany(p => p.List_Position_Users).HasForeignKey(p=>p.PositionID).HasConstraintName("FK_Position_Users");
            builder.Entity<System_Position>().ToTable("System_Position");

            builder.Entity<System_Permission>().ToTable("System_Permission").HasIndex(p=>p.PermissionName).IsUnique();

            builder.Entity<System_User_Permission>().ToTable("Systemm_User_Permission").HasOne(p=>p.System_Permission).WithMany(p=>p.System_User_Permissions).HasForeignKey(p => p.System_PermissionID).HasConstraintName("FK_UserPermission_SystemPermission");

            #endregion
            #region CM
            builder.Entity<CM_Customer>().ToTable("CM_Customer");
            #endregion
            #region PM
            builder.Entity<Brand>().ToTable("Brand");
            builder.Entity<Category>().ToTable("Category");
            builder.Entity<HomeCarousel>().ToTable("HomeCarousel");
            builder.Entity<HomeSlider>().ToTable("HomeSlider");
            builder.Entity<MainGroup>().ToTable("MainGroup");
            builder.Entity<SubGroup>().ToTable("SubGroup").HasOne(p=>p.MainGroup).WithMany(p=>p.SubGroups).HasForeignKey(p=>p.MainGroupID).HasConstraintName("FK_SubGroup_MainGroup");
            builder.Entity<Store>().ToTable("Store").HasOne(p=>p.District).WithMany(p=>p.Stores).HasForeignKey(p=>p.DistrictID).HasConstraintName("FK_Store_District");
            builder.Entity<Province>().ToTable("Province");
            builder.Entity<District>().ToTable("District");

            builder.Entity<Voucher>().ToTable("Voucher");
            builder.Entity<Discout>().ToTable("Discout");
            builder.Entity<Product>().ToTable("Product").HasOne(p=>p.Brand).WithMany(p=>p.Products).HasForeignKey(p=>p.BrandID).HasConstraintName("FK_Brand_Products");
            builder.Entity<Product>().HasOne(p => p.Category).WithMany(p => p.Products).HasForeignKey(p => p.CategoryID).HasConstraintName("FK_Category_Products");

            builder.Entity<ProductDetails>().ToTable("ProductDetails").HasOne(p=>p.Product).WithMany(p=>p.ListProductDetails).HasForeignKey(p=>p.ProductID).HasConstraintName("FK_Product_ProductDetails");
            builder.Entity<TransportType>().ToTable("TransportType");
            builder.Entity<TransportPrice>().ToTable("TransportPrice").HasOne(p=>p.TransportType).WithMany(p=>p.TransportPrices).HasForeignKey(p=>p.TransportTypeID).HasConstraintName("FK_TransportType_TransportPrice");
            #endregion
            #region SM
            builder.Entity<SaleOrder>().ToTable("SaleOrder").HasOne(p=>p.Voucher).WithMany(p=>p.SaleOrders).HasForeignKey(p=>p.VoucherID).HasConstraintName("FK_Voucher_SaleOrders");
            builder.Entity<SaleOrderDetail>().ToTable("SaleOrderDetail").HasOne(p=>p.Discout).WithMany(p=>p.SaleOrderDetails).HasForeignKey(p=>p.DiscoutID).HasConstraintName("FK_Discout_SaleOrderDetails");
            #endregion
            #region Log
            builder.Entity<ErrorLogs>().ToTable("ErrorLogs");
            builder.Entity<ImageUploadLog>().ToTable("ImageUploadLog");
            builder.Entity<ImageUploadLog>().ToTable("ImageUploadLog");

            #endregion
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
