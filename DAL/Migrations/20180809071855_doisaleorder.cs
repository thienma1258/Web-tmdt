using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class doisaleorder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.AddColumn<decimal>(
                name: "CurrentTransportPrice",
                table: "SaleOrder",
                nullable: false,
                defaultValue: 0m);

          
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleOrder_TransportType_TransportPriceID",
                table: "SaleOrder");

            migrationBuilder.DropColumn(
                name: "CurrentTransportPrice",
                table: "SaleOrder");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleOrder_TransportPrice_TransportPriceID",
                table: "SaleOrder",
                column: "TransportPriceID",
                principalTable: "TransportPrice",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
