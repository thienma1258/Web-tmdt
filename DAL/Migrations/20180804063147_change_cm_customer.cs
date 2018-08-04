using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class change_cm_customer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_CM_Customer_CustomerID",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "CreatedTime",
                table: "CM_Customer");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "CM_Customer");

            migrationBuilder.DropColumn(
                name: "EditedDate",
                table: "CM_Customer");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "SaleOrder",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_SaleOrder_CustomerID",
                table: "SaleOrder",
                newName: "IX_SaleOrder_CustomerId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "CM_Customer",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "CM_Customer",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "EditedUser",
                table: "CM_Customer",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "DeletedUser",
                table: "CM_Customer",
                newName: "SecurityStamp");

            migrationBuilder.RenameColumn(
                name: "CreatedUser",
                table: "CM_Customer",
                newName: "PhoneNumber");

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "CM_Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "CM_Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "CM_Customer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "CM_Customer",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "CM_Customer",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "CM_Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "CM_Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "CM_Customer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PasswordHash",
                table: "CM_Customer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "CM_Customer",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_CM_Customer_CustomerId",
                table: "SaleOrder",
                column: "CustomerId",
                principalTable: "CM_Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_CM_Customer_CustomerId",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "CM_Customer");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "CM_Customer");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "CM_Customer");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "CM_Customer");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "CM_Customer");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "CM_Customer");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "CM_Customer");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "CM_Customer");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "CM_Customer");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "CM_Customer");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "SaleOrder",
                newName: "CustomerID");

            migrationBuilder.RenameIndex(
                name: "IX_SaleOrder_CustomerId",
                table: "SaleOrder",
                newName: "IX_SaleOrder_CustomerID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CM_Customer",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "CM_Customer",
                newName: "EditedUser");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "CM_Customer",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "CM_Customer",
                newName: "DeletedUser");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "CM_Customer",
                newName: "CreatedUser");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedTime",
                table: "CM_Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "CM_Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedDate",
                table: "CM_Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_CM_Customer_CustomerID",
                table: "SaleOrder",
                column: "CustomerID",
                principalTable: "CM_Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
