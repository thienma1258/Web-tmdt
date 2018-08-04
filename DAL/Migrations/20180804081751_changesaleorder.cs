using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class changesaleorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_TransportType_TransportTypeID",
                table: "SaleOrder");

            migrationBuilder.RenameColumn(
                name: "TransportTypeID",
                table: "SaleOrder",
                newName: "TransportPriceID");

            migrationBuilder.RenameIndex(
                name: "IX_SaleOrder_TransportTypeID",
                table: "SaleOrder",
                newName: "IX_SaleOrder_TransportPriceID");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_TransportPrice_TransportPriceID",
                table: "SaleOrder",
                column: "TransportPriceID",
                principalTable: "TransportPrice",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_TransportPrice_TransportPriceID",
                table: "SaleOrder");

            migrationBuilder.RenameColumn(
                name: "TransportPriceID",
                table: "SaleOrder",
                newName: "TransportTypeID");

            migrationBuilder.RenameIndex(
                name: "IX_SaleOrder_TransportPriceID",
                table: "SaleOrder",
                newName: "IX_SaleOrder_TransportTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_TransportType_TransportTypeID",
                table: "SaleOrder",
                column: "TransportTypeID",
                principalTable: "TransportType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
