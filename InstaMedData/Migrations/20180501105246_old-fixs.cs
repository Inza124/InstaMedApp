using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InstaMedData.Migrations
{
    public partial class oldfixs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TestTypeCategories_testTypeCategoryId",
                table: "Tests");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TestTypeCategories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "testTypeCategoryId",
                table: "Tests",
                newName: "testTypeCategoryCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_testTypeCategoryId",
                table: "Tests",
                newName: "IX_Tests_testTypeCategoryCategoryId");

            migrationBuilder.AlterColumn<float>(
                name: "TSHResult",
                table: "TSHs",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_TestTypeCategories_testTypeCategoryCategoryId",
                table: "Tests",
                column: "testTypeCategoryCategoryId",
                principalTable: "TestTypeCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TestTypeCategories_testTypeCategoryCategoryId",
                table: "Tests");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "TestTypeCategories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "testTypeCategoryCategoryId",
                table: "Tests",
                newName: "testTypeCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_testTypeCategoryCategoryId",
                table: "Tests",
                newName: "IX_Tests_testTypeCategoryId");

            migrationBuilder.AlterColumn<decimal>(
                name: "TSHResult",
                table: "TSHs",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_TestTypeCategories_testTypeCategoryId",
                table: "Tests",
                column: "testTypeCategoryId",
                principalTable: "TestTypeCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
