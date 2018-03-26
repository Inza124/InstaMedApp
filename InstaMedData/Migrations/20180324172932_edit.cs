using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InstaMedData.Migrations
{
    public partial class edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Tests_TestId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_AspNetUsers_TestUserId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "TestType",
                table: "Tests");

            migrationBuilder.RenameColumn(
                name: "TestUserId",
                table: "Tests",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_TestUserId",
                table: "Tests",
                newName: "IX_Tests_ApplicationUserId");

            migrationBuilder.RenameColumn(
                name: "TestId",
                table: "Results",
                newName: "visitId");

            migrationBuilder.RenameIndex(
                name: "IX_Results_TestId",
                table: "Results",
                newName: "IX_Results_visitId");

            migrationBuilder.AddColumn<int>(
                name: "VisitId",
                table: "Tests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "testTypeId",
                table: "Tests",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TestType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    dateTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visit_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tests_VisitId",
                table: "Tests",
                column: "VisitId");

            migrationBuilder.CreateIndex(
                name: "IX_Tests_testTypeId",
                table: "Tests",
                column: "testTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Visit_UserId",
                table: "Visit",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Visit_visitId",
                table: "Results",
                column: "visitId",
                principalTable: "Visit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_AspNetUsers_ApplicationUserId",
                table: "Tests",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Visit_VisitId",
                table: "Tests",
                column: "VisitId",
                principalTable: "Visit",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_TestType_testTypeId",
                table: "Tests",
                column: "testTypeId",
                principalTable: "TestType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Visit_visitId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_AspNetUsers_ApplicationUserId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Visit_VisitId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TestType_testTypeId",
                table: "Tests");

            migrationBuilder.DropTable(
                name: "TestType");

            migrationBuilder.DropTable(
                name: "Visit");

            migrationBuilder.DropIndex(
                name: "IX_Tests_VisitId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_testTypeId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "VisitId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "testTypeId",
                table: "Tests");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Tests",
                newName: "TestUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tests_ApplicationUserId",
                table: "Tests",
                newName: "IX_Tests_TestUserId");

            migrationBuilder.RenameColumn(
                name: "visitId",
                table: "Results",
                newName: "TestId");

            migrationBuilder.RenameIndex(
                name: "IX_Results_visitId",
                table: "Results",
                newName: "IX_Results_TestId");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Tests",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Tests",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TestType",
                table: "Tests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Tests_TestId",
                table: "Results",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_AspNetUsers_TestUserId",
                table: "Tests",
                column: "TestUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
