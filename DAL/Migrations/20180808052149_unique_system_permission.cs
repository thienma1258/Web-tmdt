using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class unique_system_permission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PermissionValue",
                table: "System_Permission");

            migrationBuilder.AlterColumn<string>(
                name: "PermissionName",
                table: "System_Permission",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_System_Permission_PermissionName",
                table: "System_Permission",
                column: "PermissionName",
                unique: true,
                filter: "[PermissionName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_System_Permission_PermissionName",
                table: "System_Permission");

            migrationBuilder.AlterColumn<string>(
                name: "PermissionName",
                table: "System_Permission",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PermissionValue",
                table: "System_Permission",
                nullable: true);
        }
    }
}
