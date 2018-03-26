using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InstaMedData.Migrations
{
    public partial class edt6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TestTypeCategories_testTypeCategoryId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TestTypeNames_testTypeNameId",
                table: "Tests");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TestTypeNames",
                newName: "NameId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TestTypeCategories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "testTypeNameId",
                table: "Tests",
                newName: "testTypeNameNameId");

            migrationBuilder.RenameColumn(
                name: "testTypeCategoryId",
                table: "Tests",
                newName: "testTypeCategoryCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_testTypeNameId",
                table: "Tests",
                newName: "IX_Tests_testTypeNameNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_testTypeCategoryId",
                table: "Tests",
                newName: "IX_Tests_testTypeCategoryCategoryId");

            migrationBuilder.AddColumn<int>(
                name: "NameId",
                table: "TestTypeCategories",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_TestTypeCategories_testTypeCategoryCategoryId",
                table: "Tests",
                column: "testTypeCategoryCategoryId",
                principalTable: "TestTypeCategories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_TestTypeNames_testTypeNameNameId",
                table: "Tests",
                column: "testTypeNameNameId",
                principalTable: "TestTypeNames",
                principalColumn: "NameId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TestTypeCategories_testTypeCategoryCategoryId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TestTypeNames_testTypeNameNameId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "NameId",
                table: "TestTypeCategories");

            migrationBuilder.RenameColumn(
                name: "NameId",
                table: "TestTypeNames",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "TestTypeCategories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "testTypeNameNameId",
                table: "Tests",
                newName: "testTypeNameId");

            migrationBuilder.RenameColumn(
                name: "testTypeCategoryCategoryId",
                table: "Tests",
                newName: "testTypeCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_testTypeNameNameId",
                table: "Tests",
                newName: "IX_Tests_testTypeNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_testTypeCategoryCategoryId",
                table: "Tests",
                newName: "IX_Tests_testTypeCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_TestTypeCategories_testTypeCategoryId",
                table: "Tests",
                column: "testTypeCategoryId",
                principalTable: "TestTypeCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_TestTypeNames_testTypeNameId",
                table: "Tests",
                column: "testTypeNameId",
                principalTable: "TestTypeNames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
