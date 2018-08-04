using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class them_sale_order_logs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DistrictID",
                table: "Store",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPay",
                table: "SaleOrder",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Store_DistrictID",
                table: "Store",
                column: "DistrictID");

            migrationBuilder.AddForeignKey(
                name: "FK_Store_District_DistrictID",
                table: "Store",
                column: "DistrictID",
                principalTable: "District",
                principalColumn: "DistrictID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Store_District_DistrictID",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Store_DistrictID",
                table: "Store");

            migrationBuilder.DropColumn(
                name: "DistrictID",
                table: "Store");

            migrationBuilder.DropColumn(
                name: "IsPay",
                table: "SaleOrder");
        }
    }
}
