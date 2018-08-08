using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class continueupdatedatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quality",
                table: "ProductDetails",
                newName: "Quatity");

            migrationBuilder.AddColumn<string>(
                name: "CommentArea",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Specification",
                table: "Product",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CommentArea",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Specification",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Quatity",
                table: "ProductDetails",
                newName: "Quality");
        }
    }
}
