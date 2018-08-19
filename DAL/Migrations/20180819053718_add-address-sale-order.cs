using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class addaddresssaleorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CMNN",
                table: "CM_Customer",
                newName: "CMND");

            migrationBuilder.AddColumn<string>(
                name: "DistrictID",
                table: "SaleOrder",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReceiveAddress",
                table: "SaleOrder",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "CM_Customer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DistrictID",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "ReceiveAddress",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "CM_Customer");

            migrationBuilder.RenameColumn(
                name: "CMND",
                table: "CM_Customer",
                newName: "CMNN");
        }
    }
}
