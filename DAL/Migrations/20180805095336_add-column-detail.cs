using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class addcolumndetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "ProductDetails");

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "ProductDetails",
                nullable: true);
        }
    }
}
