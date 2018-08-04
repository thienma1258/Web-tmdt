using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class detailsSaleOrderLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthenticationID",
                table: "CM_Customer");

            migrationBuilder.DropColumn(
                name: "CustomerAddress",
                table: "CM_Customer");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "CM_Customer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthenticationID",
                table: "CM_Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerAddress",
                table: "CM_Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "CM_Customer",
                nullable: true);
        }
    }
}
