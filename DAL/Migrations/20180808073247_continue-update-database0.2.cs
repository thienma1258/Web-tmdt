using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class continueupdatedatabase02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quatity",
                table: "ProductDetails",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "MaxQualityBuy",
                table: "ProductDetails",
                newName: "MaxQuantityBuy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "ProductDetails",
                newName: "Quatity");

            migrationBuilder.RenameColumn(
                name: "MaxQuantityBuy",
                table: "ProductDetails",
                newName: "MaxQualityBuy");
        }
    }
}
