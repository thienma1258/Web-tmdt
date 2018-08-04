using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DAL.Migrations
{
    public partial class unique_code_voucher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                           name: "UniqueCode",
                           table: "Voucher"
                           );
            migrationBuilder.AddColumn<int>(
                  name: "UniqueCode",
                table: "Voucher",
            nullable: false).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);



            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                            name: "UniqueCode",
                            table: "Voucher"
                            );
            migrationBuilder.AddColumn<string>(
                            name: "UniqueCode",
                            table: "Voucher"
                            );
        }
    }
}
