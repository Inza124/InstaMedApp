using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InstaMedData.Migrations
{
    public partial class edt4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TestTypes_testTypeId",
                table: "Tests");

            migrationBuilder.DropTable(
                name: "TestTypes");

            migrationBuilder.RenameColumn(
                name: "testTypeId",
                table: "Tests",
                newName: "testTypeNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_testTypeId",
                table: "Tests",
                newName: "IX_Tests_testTypeNameId");

            migrationBuilder.AddColumn<int>(
                name: "testTypeCategoryId",
                table: "Tests",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TestTypeCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTypeCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestTypeNames",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    categoryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTypeNames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestTypeNames_TestTypeCategories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "TestTypeCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tests_testTypeCategoryId",
                table: "Tests",
                column: "testTypeCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TestTypeNames_categoryId",
                table: "TestTypeNames",
                column: "categoryId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TestTypeCategories_testTypeCategoryId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TestTypeNames_testTypeNameId",
                table: "Tests");

            migrationBuilder.DropTable(
                name: "TestTypeNames");

            migrationBuilder.DropTable(
                name: "TestTypeCategories");

            migrationBuilder.DropIndex(
                name: "IX_Tests_testTypeCategoryId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "testTypeCategoryId",
                table: "Tests");

            migrationBuilder.RenameColumn(
                name: "testTypeNameId",
                table: "Tests",
                newName: "testTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_testTypeNameId",
                table: "Tests",
                newName: "IX_Tests_testTypeId");

            migrationBuilder.CreateTable(
                name: "TestTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestTypes", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_TestTypes_testTypeId",
                table: "Tests",
                column: "testTypeId",
                principalTable: "TestTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
