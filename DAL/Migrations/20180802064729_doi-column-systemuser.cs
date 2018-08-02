using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class doicolumnsystemuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brand_AspNetUsers_CreatedUserId",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_Brand_AspNetUsers_DeletedUserId",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_Brand_AspNetUsers_EditedUserId",
                table: "Brand");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_AspNetUsers_CreatedUserId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_AspNetUsers_DeletedUserId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_AspNetUsers_EditedUserId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_CM_Customer_AspNetUsers_CreatedUserId",
                table: "CM_Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_CM_Customer_AspNetUsers_DeletedUserId",
                table: "CM_Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_CM_Customer_AspNetUsers_EditedUserId",
                table: "CM_Customer");

            migrationBuilder.DropForeignKey(
                name: "FK_Discout_AspNetUsers_CreatedUserId",
                table: "Discout");

            migrationBuilder.DropForeignKey(
                name: "FK_Discout_AspNetUsers_DeletedUserId",
                table: "Discout");

            migrationBuilder.DropForeignKey(
                name: "FK_Discout_AspNetUsers_EditedUserId",
                table: "Discout");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeCarousel_AspNetUsers_CreatedUserId",
                table: "HomeCarousel");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeCarousel_AspNetUsers_DeletedUserId",
                table: "HomeCarousel");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeCarousel_AspNetUsers_EditedUserId",
                table: "HomeCarousel");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeSlider_AspNetUsers_CreatedUserId",
                table: "HomeSlider");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeSlider_AspNetUsers_DeletedUserId",
                table: "HomeSlider");

            migrationBuilder.DropForeignKey(
                name: "FK_HomeSlider_AspNetUsers_EditedUserId",
                table: "HomeSlider");

            migrationBuilder.DropForeignKey(
                name: "FK_ImageUploadLog_AspNetUsers_CreatedUserId",
                table: "ImageUploadLog");

            migrationBuilder.DropForeignKey(
                name: "FK_MainGroup_AspNetUsers_CreatedUserId",
                table: "MainGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_MainGroup_AspNetUsers_DeletedUserId",
                table: "MainGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_MainGroup_AspNetUsers_EditedUserId",
                table: "MainGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_AspNetUsers_CreatedUserId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_AspNetUsers_DeletedUserId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_AspNetUsers_EditedUserId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_AspNetUsers_CreatedUserId",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_AspNetUsers_DeletedUserId",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDetails_AspNetUsers_EditedUserId",
                table: "ProductDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_AspNetUsers_CreatedUserId",
                table: "SaleOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_AspNetUsers_DeletedUserId",
                table: "SaleOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_AspNetUsers_EditedUserId",
                table: "SaleOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_AspNetUsers_ReviewById",
                table: "SaleOrder");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrderDetail_AspNetUsers_CreatedUserId",
                table: "SaleOrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrderDetail_AspNetUsers_DeletedUserId",
                table: "SaleOrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrderDetail_AspNetUsers_EditedUserId",
                table: "SaleOrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_Store_AspNetUsers_CreatedUserId",
                table: "Store");

            migrationBuilder.DropForeignKey(
                name: "FK_Store_AspNetUsers_DeletedUserId",
                table: "Store");

            migrationBuilder.DropForeignKey(
                name: "FK_Store_AspNetUsers_EditedUserId",
                table: "Store");

            migrationBuilder.DropForeignKey(
                name: "FK_SubGroup_AspNetUsers_CreatedUserId",
                table: "SubGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_SubGroup_AspNetUsers_DeletedUserId",
                table: "SubGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_SubGroup_AspNetUsers_EditedUserId",
                table: "SubGroup");

            migrationBuilder.DropForeignKey(
                name: "FK_System_Policy_AspNetUsers_CreatedUserId",
                table: "System_Policy");

            migrationBuilder.DropForeignKey(
                name: "FK_System_Policy_AspNetUsers_DeletedUserId",
                table: "System_Policy");

            migrationBuilder.DropForeignKey(
                name: "FK_System_Policy_AspNetUsers_EditedUserId",
                table: "System_Policy");

            migrationBuilder.DropForeignKey(
                name: "FK_System_Position_AspNetUsers_CreatedUserId",
                table: "System_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_System_Position_AspNetUsers_DeletedUserId",
                table: "System_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_System_Position_AspNetUsers_EditedUserId",
                table: "System_Position");

            migrationBuilder.DropForeignKey(
                name: "FK_System_User_Permission_AspNetUsers_CreatedUserId",
                table: "System_User_Permission");

            migrationBuilder.DropForeignKey(
                name: "FK_System_User_Permission_AspNetUsers_DeletedUserId",
                table: "System_User_Permission");

            migrationBuilder.DropForeignKey(
                name: "FK_System_User_Permission_AspNetUsers_EditedUserId",
                table: "System_User_Permission");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportPrice_AspNetUsers_CreatedUserId",
                table: "TransportPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportPrice_AspNetUsers_DeletedUserId",
                table: "TransportPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportPrice_AspNetUsers_EditedUserId",
                table: "TransportPrice");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportType_AspNetUsers_CreatedUserId",
                table: "TransportType");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportType_AspNetUsers_DeletedUserId",
                table: "TransportType");

            migrationBuilder.DropForeignKey(
                name: "FK_TransportType_AspNetUsers_EditedUserId",
                table: "TransportType");

            migrationBuilder.DropForeignKey(
                name: "FK_Voucher_AspNetUsers_CreatedUserId",
                table: "Voucher");

            migrationBuilder.DropForeignKey(
                name: "FK_Voucher_AspNetUsers_DeletedUserId",
                table: "Voucher");

            migrationBuilder.DropForeignKey(
                name: "FK_Voucher_AspNetUsers_EditedUserId",
                table: "Voucher");

            migrationBuilder.DropIndex(
                name: "IX_Voucher_CreatedUserId",
                table: "Voucher");

            migrationBuilder.DropIndex(
                name: "IX_Voucher_DeletedUserId",
                table: "Voucher");

            migrationBuilder.DropIndex(
                name: "IX_Voucher_EditedUserId",
                table: "Voucher");

            migrationBuilder.DropIndex(
                name: "IX_TransportType_CreatedUserId",
                table: "TransportType");

            migrationBuilder.DropIndex(
                name: "IX_TransportType_DeletedUserId",
                table: "TransportType");

            migrationBuilder.DropIndex(
                name: "IX_TransportType_EditedUserId",
                table: "TransportType");

            migrationBuilder.DropIndex(
                name: "IX_TransportPrice_CreatedUserId",
                table: "TransportPrice");

            migrationBuilder.DropIndex(
                name: "IX_TransportPrice_DeletedUserId",
                table: "TransportPrice");

            migrationBuilder.DropIndex(
                name: "IX_TransportPrice_EditedUserId",
                table: "TransportPrice");

            migrationBuilder.DropIndex(
                name: "IX_System_User_Permission_CreatedUserId",
                table: "System_User_Permission");

            migrationBuilder.DropIndex(
                name: "IX_System_User_Permission_DeletedUserId",
                table: "System_User_Permission");

            migrationBuilder.DropIndex(
                name: "IX_System_User_Permission_EditedUserId",
                table: "System_User_Permission");

            migrationBuilder.DropIndex(
                name: "IX_System_Position_CreatedUserId",
                table: "System_Position");

            migrationBuilder.DropIndex(
                name: "IX_System_Position_DeletedUserId",
                table: "System_Position");

            migrationBuilder.DropIndex(
                name: "IX_System_Position_EditedUserId",
                table: "System_Position");

            migrationBuilder.DropIndex(
                name: "IX_System_Policy_CreatedUserId",
                table: "System_Policy");

            migrationBuilder.DropIndex(
                name: "IX_System_Policy_DeletedUserId",
                table: "System_Policy");

            migrationBuilder.DropIndex(
                name: "IX_System_Policy_EditedUserId",
                table: "System_Policy");

            migrationBuilder.DropIndex(
                name: "IX_SubGroup_CreatedUserId",
                table: "SubGroup");

            migrationBuilder.DropIndex(
                name: "IX_SubGroup_DeletedUserId",
                table: "SubGroup");

            migrationBuilder.DropIndex(
                name: "IX_SubGroup_EditedUserId",
                table: "SubGroup");

            migrationBuilder.DropIndex(
                name: "IX_Store_CreatedUserId",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Store_DeletedUserId",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Store_EditedUserId",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_SaleOrderDetail_CreatedUserId",
                table: "SaleOrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_SaleOrderDetail_DeletedUserId",
                table: "SaleOrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_SaleOrderDetail_EditedUserId",
                table: "SaleOrderDetail");

            migrationBuilder.DropIndex(
                name: "IX_SaleOrder_CreatedUserId",
                table: "SaleOrder");

            migrationBuilder.DropIndex(
                name: "IX_SaleOrder_DeletedUserId",
                table: "SaleOrder");

            migrationBuilder.DropIndex(
                name: "IX_SaleOrder_EditedUserId",
                table: "SaleOrder");

            migrationBuilder.DropIndex(
                name: "IX_SaleOrder_ReviewById",
                table: "SaleOrder");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_CreatedUserId",
                table: "ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_DeletedUserId",
                table: "ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_ProductDetails_EditedUserId",
                table: "ProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_Product_CreatedUserId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_DeletedUserId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_EditedUserId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_MainGroup_CreatedUserId",
                table: "MainGroup");

            migrationBuilder.DropIndex(
                name: "IX_MainGroup_DeletedUserId",
                table: "MainGroup");

            migrationBuilder.DropIndex(
                name: "IX_MainGroup_EditedUserId",
                table: "MainGroup");

            migrationBuilder.DropIndex(
                name: "IX_ImageUploadLog_CreatedUserId",
                table: "ImageUploadLog");

            migrationBuilder.DropIndex(
                name: "IX_HomeSlider_CreatedUserId",
                table: "HomeSlider");

            migrationBuilder.DropIndex(
                name: "IX_HomeSlider_DeletedUserId",
                table: "HomeSlider");

            migrationBuilder.DropIndex(
                name: "IX_HomeSlider_EditedUserId",
                table: "HomeSlider");

            migrationBuilder.DropIndex(
                name: "IX_HomeCarousel_CreatedUserId",
                table: "HomeCarousel");

            migrationBuilder.DropIndex(
                name: "IX_HomeCarousel_DeletedUserId",
                table: "HomeCarousel");

            migrationBuilder.DropIndex(
                name: "IX_HomeCarousel_EditedUserId",
                table: "HomeCarousel");

            migrationBuilder.DropIndex(
                name: "IX_Discout_CreatedUserId",
                table: "Discout");

            migrationBuilder.DropIndex(
                name: "IX_Discout_DeletedUserId",
                table: "Discout");

            migrationBuilder.DropIndex(
                name: "IX_Discout_EditedUserId",
                table: "Discout");

            migrationBuilder.DropIndex(
                name: "IX_CM_Customer_CreatedUserId",
                table: "CM_Customer");

            migrationBuilder.DropIndex(
                name: "IX_CM_Customer_DeletedUserId",
                table: "CM_Customer");

            migrationBuilder.DropIndex(
                name: "IX_CM_Customer_EditedUserId",
                table: "CM_Customer");

            migrationBuilder.DropIndex(
                name: "IX_Category_CreatedUserId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_DeletedUserId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_EditedUserId",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Brand_CreatedUserId",
                table: "Brand");

            migrationBuilder.DropIndex(
                name: "IX_Brand_DeletedUserId",
                table: "Brand");

            migrationBuilder.DropIndex(
                name: "IX_Brand_EditedUserId",
                table: "Brand");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "Voucher",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "Voucher",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Voucher",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "TransportType",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "TransportType",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "TransportType",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "TransportPrice",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "TransportPrice",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "TransportPrice",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "System_User_Permission",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "System_User_Permission",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "System_User_Permission",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "System_Position",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "System_Position",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "System_Position",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "System_Policy",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "System_Policy",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "System_Policy",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "SubGroup",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "SubGroup",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "SubGroup",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "Store",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "Store",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Store",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "SaleOrderDetail",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "SaleOrderDetail",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "SaleOrderDetail",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "ReviewById",
                table: "SaleOrder",
                newName: "ReviewBy");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "SaleOrder",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "SaleOrder",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "SaleOrder",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "ProductDetails",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "ProductDetails",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "ProductDetails",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "Product",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "Product",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Product",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "MainGroup",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "MainGroup",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "MainGroup",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "ImageUploadLog",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "HomeSlider",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "HomeSlider",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "HomeSlider",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "HomeCarousel",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "HomeCarousel",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "HomeCarousel",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "Discout",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "Discout",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Discout",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "CM_Customer",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "CM_Customer",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "CM_Customer",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "Category",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "Category",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Category",
                newName: "CreatedUser");

            migrationBuilder.RenameColumn(
                name: "EditedUserId",
                table: "Brand",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "DeletedUserId",
                table: "Brand",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Brand",
                newName: "CreatedUser");

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "Voucher",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "Voucher",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "Voucher",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "TransportType",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "TransportType",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "TransportType",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "TransportPrice",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "TransportPrice",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "TransportPrice",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "System_User_Permission",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "System_User_Permission",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "System_User_Permission",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "System_Position",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "System_Position",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "System_Position",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "System_Policy",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "System_Policy",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "System_Policy",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "SubGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "SubGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "SubGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "Store",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "Store",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "Store",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "SaleOrderDetail",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "SaleOrderDetail",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "SaleOrderDetail",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReviewBy",
                table: "SaleOrder",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "SaleOrder",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "SaleOrder",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "SaleOrder",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "ProductDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "ProductDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "ProductDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "MainGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "MainGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "MainGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "ImageUploadLog",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "HomeSlider",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "HomeSlider",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "HomeSlider",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "HomeCarousel",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "HomeCarousel",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "HomeCarousel",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "Discout",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "Discout",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "Discout",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "CM_Customer",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "CM_Customer",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "CM_Customer",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "Category",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "Category",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "Category",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUser",
                table: "Brand",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUser",
                table: "Brand",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUser",
                table: "Brand",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "Voucher",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "Voucher",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "Voucher",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "TransportType",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "TransportType",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "TransportType",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "TransportPrice",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "TransportPrice",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "TransportPrice",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "System_User_Permission",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "System_User_Permission",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "System_User_Permission",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "System_Position",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "System_Position",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "System_Position",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "System_Policy",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "System_Policy",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "System_Policy",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "SubGroup",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "SubGroup",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "SubGroup",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "Store",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "Store",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "Store",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "SaleOrderDetail",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "SaleOrderDetail",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "SaleOrderDetail",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "ReviewBy",
                table: "SaleOrder",
                newName: "ReviewById");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "SaleOrder",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "SaleOrder",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "SaleOrder",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "ProductDetails",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "ProductDetails",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "ProductDetails",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "Product",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "Product",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "Product",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "MainGroup",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "MainGroup",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "MainGroup",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "ImageUploadLog",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "HomeSlider",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "HomeSlider",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "HomeSlider",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "HomeCarousel",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "HomeCarousel",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "HomeCarousel",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "Discout",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "Discout",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "Discout",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "CM_Customer",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "CM_Customer",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "CM_Customer",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "Category",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "Category",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "Category",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "Brand",
                newName: "EditedUserId");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "Brand",
                newName: "DeletedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "Brand",
                newName: "CreatedUserId");

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "Voucher",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "Voucher",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "Voucher",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "TransportType",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "TransportType",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "TransportType",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "TransportPrice",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "TransportPrice",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "TransportPrice",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "System_User_Permission",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "System_User_Permission",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "System_User_Permission",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "System_Position",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "System_Position",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "System_Position",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "System_Policy",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "System_Policy",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "System_Policy",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "SubGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "SubGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "SubGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "Store",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "Store",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "Store",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "SaleOrderDetail",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "SaleOrderDetail",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "SaleOrderDetail",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReviewById",
                table: "SaleOrder",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "SaleOrder",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "SaleOrder",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "SaleOrder",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "ProductDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "ProductDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "ProductDetails",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "MainGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "MainGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "MainGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "ImageUploadLog",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "HomeSlider",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "HomeSlider",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "HomeSlider",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "HomeCarousel",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "HomeCarousel",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "HomeCarousel",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "Discout",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "Discout",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "Discout",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "CM_Customer",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "CM_Customer",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "CM_Customer",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "Category",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "Category",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "Category",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EditedUserId",
                table: "Brand",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DeletedUserId",
                table: "Brand",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedUserId",
                table: "Brand",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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
                name: "IX_TransportPrice_CreatedUserId",
                table: "TransportPrice",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportPrice_DeletedUserId",
                table: "TransportPrice",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportPrice_EditedUserId",
                table: "TransportPrice",
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
                name: "IX_SaleOrderDetail_CreatedUserId",
                table: "SaleOrderDetail",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetail_DeletedUserId",
                table: "SaleOrderDetail",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderDetail_EditedUserId",
                table: "SaleOrderDetail",
                column: "EditedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrder_CreatedUserId",
                table: "SaleOrder",
                column: "CreatedUserId");

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
                name: "IX_Product_CreatedUserId",
                table: "Product",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_DeletedUserId",
                table: "Product",
                column: "DeletedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_EditedUserId",
                table: "Product",
                column: "EditedUserId");

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
                name: "IX_ImageUploadLog_CreatedUserId",
                table: "ImageUploadLog",
                column: "CreatedUserId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_System_User_Permission_AspNetUsers_CreatedUserId",
                table: "System_User_Permission",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_System_User_Permission_AspNetUsers_DeletedUserId",
                table: "System_User_Permission",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_System_User_Permission_AspNetUsers_EditedUserId",
                table: "System_User_Permission",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportPrice_AspNetUsers_CreatedUserId",
                table: "TransportPrice",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportPrice_AspNetUsers_DeletedUserId",
                table: "TransportPrice",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportPrice_AspNetUsers_EditedUserId",
                table: "TransportPrice",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportType_AspNetUsers_CreatedUserId",
                table: "TransportType",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportType_AspNetUsers_DeletedUserId",
                table: "TransportType",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransportType_AspNetUsers_EditedUserId",
                table: "TransportType",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Voucher_AspNetUsers_CreatedUserId",
                table: "Voucher",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Voucher_AspNetUsers_DeletedUserId",
                table: "Voucher",
                column: "DeletedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Voucher_AspNetUsers_EditedUserId",
                table: "Voucher",
                column: "EditedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
