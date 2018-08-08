using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class them_bang_system_permission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Permission",
                table: "System_User_Permission");

            migrationBuilder.DropForeignKey(
                name: "FK_System_User_Permission_System_User_UserID",
                table: "System_User_Permission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_System_User_Permission",
                table: "System_User_Permission");

            migrationBuilder.DropIndex(
                name: "IX_System_User_Permission_ReviewUserID",
                table: "System_User_Permission");

            migrationBuilder.RenameTable(
                name: "System_User_Permission",
                newName: "Systemm_User_Permission");

            migrationBuilder.RenameColumn(
                name: "UserPermissionValue",
                table: "Systemm_User_Permission",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "UserPermission",
                table: "Systemm_User_Permission",
                newName: "System_UserId");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Systemm_User_Permission",
                newName: "System_PermissionID");

            migrationBuilder.RenameColumn(
                name: "ReviewUserID",
                table: "Systemm_User_Permission",
                newName: "ReviewUserName");

            migrationBuilder.RenameIndex(
                name: "IX_System_User_Permission_UserID",
                table: "Systemm_User_Permission",
                newName: "IX_Systemm_User_Permission_System_PermissionID");

            migrationBuilder.AlterColumn<string>(
                name: "System_UserId",
                table: "Systemm_User_Permission",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReviewUserName",
                table: "Systemm_User_Permission",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Systemm_User_Permission",
                table: "Systemm_User_Permission",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "System_Permission",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CreatedUser = table.Column<string>(nullable: true),
                    DeletedDate = table.Column<DateTime>(nullable: false),
                    DeletedUser = table.Column<string>(nullable: true),
                    EditedDate = table.Column<DateTime>(nullable: false),
                    EditedUser = table.Column<string>(nullable: true),
                    PermissionCode = table.Column<string>(nullable: true),
                    PermissionName = table.Column<string>(nullable: true),
                    PermissionValue = table.Column<string>(nullable: true),
                    isDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_System_Permission", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Systemm_User_Permission_System_UserId",
                table: "Systemm_User_Permission",
                column: "System_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserPermission_SystemPermission",
                table: "Systemm_User_Permission",
                column: "System_PermissionID",
                principalTable: "System_Permission",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Systemm_User_Permission_System_User_System_UserId",
                table: "Systemm_User_Permission",
                column: "System_UserId",
                principalTable: "System_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserPermission_SystemPermission",
                table: "Systemm_User_Permission");

            migrationBuilder.DropForeignKey(
                name: "FK_Systemm_User_Permission_System_User_System_UserId",
                table: "Systemm_User_Permission");

            migrationBuilder.DropTable(
                name: "System_Permission");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Systemm_User_Permission",
                table: "Systemm_User_Permission");

            migrationBuilder.DropIndex(
                name: "IX_Systemm_User_Permission_System_UserId",
                table: "Systemm_User_Permission");

            migrationBuilder.RenameTable(
                name: "Systemm_User_Permission",
                newName: "System_User_Permission");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "System_User_Permission",
                newName: "UserPermissionValue");

            migrationBuilder.RenameColumn(
                name: "System_UserId",
                table: "System_User_Permission",
                newName: "UserPermission");

            migrationBuilder.RenameColumn(
                name: "System_PermissionID",
                table: "System_User_Permission",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "ReviewUserName",
                table: "System_User_Permission",
                newName: "ReviewUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Systemm_User_Permission_System_PermissionID",
                table: "System_User_Permission",
                newName: "IX_System_User_Permission_UserID");

            migrationBuilder.AlterColumn<string>(
                name: "UserPermission",
                table: "System_User_Permission",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReviewUserID",
                table: "System_User_Permission",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_System_User_Permission",
                table: "System_User_Permission",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_System_User_Permission_ReviewUserID",
                table: "System_User_Permission",
                column: "ReviewUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Permission",
                table: "System_User_Permission",
                column: "ReviewUserID",
                principalTable: "System_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_System_User_Permission_System_User_UserID",
                table: "System_User_Permission",
                column: "UserID",
                principalTable: "System_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
