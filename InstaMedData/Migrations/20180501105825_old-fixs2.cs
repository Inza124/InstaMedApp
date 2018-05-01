using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InstaMedData.Migrations
{
    public partial class oldfixs2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TestTypeNames_testTypeNameId",
                table: "Tests");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TestTypeNames",
                newName: "NameId");

            migrationBuilder.RenameColumn(
                name: "testTypeNameId",
                table: "Tests",
                newName: "testTypeNameNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_testTypeNameId",
                table: "Tests",
                newName: "IX_Tests_testTypeNameNameId");

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
                name: "FK_Tests_TestTypeNames_testTypeNameNameId",
                table: "Tests");

            migrationBuilder.RenameColumn(
                name: "NameId",
                table: "TestTypeNames",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "testTypeNameNameId",
                table: "Tests",
                newName: "testTypeNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_testTypeNameNameId",
                table: "Tests",
                newName: "IX_Tests_testTypeNameId");

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
