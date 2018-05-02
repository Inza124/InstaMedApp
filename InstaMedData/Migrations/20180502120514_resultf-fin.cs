using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InstaMedData.Migrations
{
    public partial class resultffin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Testosteron_TestosteronTestId",
                table: "Results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Testosteron",
                table: "Testosteron");

            migrationBuilder.RenameTable(
                name: "Testosteron",
                newName: "Testosterons");

            migrationBuilder.AddColumn<string>(
                name: "DocName",
                table: "USGSzyis",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocName",
                table: "USGSercas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocName",
                table: "USGPiersis",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocName",
                table: "Morves5",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocName",
                table: "Morves",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocName",
                table: "Moczs",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testosterons",
                table: "Testosterons",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Testosterons_TestosteronTestId",
                table: "Results",
                column: "TestosteronTestId",
                principalTable: "Testosterons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Testosterons_TestosteronTestId",
                table: "Results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Testosterons",
                table: "Testosterons");

            migrationBuilder.DropColumn(
                name: "DocName",
                table: "USGSzyis");

            migrationBuilder.DropColumn(
                name: "DocName",
                table: "USGSercas");

            migrationBuilder.DropColumn(
                name: "DocName",
                table: "USGPiersis");

            migrationBuilder.DropColumn(
                name: "DocName",
                table: "Morves5");

            migrationBuilder.DropColumn(
                name: "DocName",
                table: "Morves");

            migrationBuilder.DropColumn(
                name: "DocName",
                table: "Moczs");

            migrationBuilder.RenameTable(
                name: "Testosterons",
                newName: "Testosteron");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testosteron",
                table: "Testosteron",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Testosteron_TestosteronTestId",
                table: "Results",
                column: "TestosteronTestId",
                principalTable: "Testosteron",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
