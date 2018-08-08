using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class delete_fk_permission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Systemm_User_Permission_System_User_System_UserId",
                table: "Systemm_User_Permission");

            migrationBuilder.DropIndex(
                name: "IX_Systemm_User_Permission_System_UserId",
                table: "Systemm_User_Permission");

            migrationBuilder.DropColumn(
                name: "System_UserId",
                table: "Systemm_User_Permission");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "System_UserId",
                table: "Systemm_User_Permission",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Systemm_User_Permission_System_UserId",
                table: "Systemm_User_Permission",
                column: "System_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Systemm_User_Permission_System_User_System_UserId",
                table: "Systemm_User_Permission",
                column: "System_UserId",
                principalTable: "System_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
