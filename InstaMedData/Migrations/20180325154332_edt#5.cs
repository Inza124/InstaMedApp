using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InstaMedData.Migrations
{
    public partial class edt5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestTypeNames_TestTypeCategories_categoryId",
                table: "TestTypeNames");

            migrationBuilder.DropIndex(
                name: "IX_TestTypeNames_categoryId",
                table: "TestTypeNames");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "TestTypeNames",
                newName: "CategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "TestTypeNames",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "TestTypeNames",
                newName: "categoryId");

            migrationBuilder.AlterColumn<int>(
                name: "categoryId",
                table: "TestTypeNames",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_TestTypeNames_categoryId",
                table: "TestTypeNames",
                column: "categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestTypeNames_TestTypeCategories_categoryId",
                table: "TestTypeNames",
                column: "categoryId",
                principalTable: "TestTypeCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
