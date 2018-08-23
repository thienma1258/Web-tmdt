using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class thembangsaleorderlogs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SaleOrderLogs",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    AuthenticationMethodGuid = table.Column<string>(nullable: true),
                    CreatedTime = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<string>(nullable: true),
                    IsPay = table.Column<bool>(nullable: false),
                    Logs = table.Column<string>(nullable: true),
                    LogsSaleOrderID = table.Column<string>(nullable: true),
                    PaymentMethod = table.Column<int>(nullable: false),
                    ReviewBy = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<DateTime>(nullable: false),
                    State = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false),
                    TransportTypePrice = table.Column<decimal>(nullable: false),
                    VAT = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleOrderLogs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SaleOrderLogs_CM_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "CM_Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaleOrderLogs_CustomerId",
                table: "SaleOrderLogs",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaleOrderLogs");
        }
    }
}
