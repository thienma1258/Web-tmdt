using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class indexurl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SubGroup_Name",
                table: "SubGroup");

            migrationBuilder.DropIndex(
                name: "IX_Product_Model",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Category_Name",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Brand_Name",
                table: "Brand");

            migrationBuilder.AlterColumn<string>(
                name: "UrlFriendly",
                table: "SubGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SubGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrlFriendly",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrlFriendly",
                table: "Category",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrlFriendly",
                table: "Brand",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brand",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubGroup_UrlFriendly",
                table: "SubGroup",
                column: "UrlFriendly",
                unique: true,
                filter: "[UrlFriendly] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UrlFriendly",
                table: "Product",
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
                name: "IX_Brand_UrlFriendly",
                table: "Brand",
                column: "UrlFriendly",
                unique: true,
                filter: "[UrlFriendly] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SubGroup_UrlFriendly",
                table: "SubGroup");

            migrationBuilder.DropIndex(
                name: "IX_Product_UrlFriendly",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Category_UrlFriendly",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Brand_UrlFriendly",
                table: "Brand");

            migrationBuilder.AlterColumn<string>(
                name: "UrlFriendly",
                table: "SubGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SubGroup",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrlFriendly",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Product",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrlFriendly",
                table: "Category",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UrlFriendly",
                table: "Brand",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Brand",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SubGroup_Name",
                table: "SubGroup",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Model",
                table: "Product",
                column: "Model",
                unique: true,
                filter: "[Model] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Category_Name",
                table: "Category",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Brand_Name",
                table: "Brand",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");
        }
    }
}
