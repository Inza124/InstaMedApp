using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InstaMedData.Migrations
{
    public partial class newmethodresultsvisits3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "TSHs");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "T3T4s");

            migrationBuilder.AddColumn<bool>(
                name: "isTSH",
                table: "TSHs",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "isT3T4",
                table: "T3T4s",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isTSH",
                table: "TSHs");

            migrationBuilder.DropColumn(
                name: "isT3T4",
                table: "T3T4s");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "TSHs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "T3T4s",
                nullable: true);
        }
    }
}
