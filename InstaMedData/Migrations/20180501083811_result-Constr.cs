using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InstaMedData.Migrations
{
    public partial class resultConstr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "TSHs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "T3T4s",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "TSHs");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "T3T4s");
        }
    }
}
