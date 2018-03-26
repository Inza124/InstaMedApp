using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InstaMedData.Migrations
{
    public partial class edt3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Visit_visitId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Visit_VisitId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TestType_testTypeId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_AspNetUsers_UserId",
                table: "Visit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Visit",
                table: "Visit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestType",
                table: "TestType");

            migrationBuilder.RenameTable(
                name: "Visit",
                newName: "Visits");

            migrationBuilder.RenameTable(
                name: "TestType",
                newName: "TestTypes");

            migrationBuilder.RenameIndex(
                name: "IX_Visit_UserId",
                table: "Visits",
                newName: "IX_Visits_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visits",
                table: "Visits",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestTypes",
                table: "TestTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Visits_visitId",
                table: "Results",
                column: "visitId",
                principalTable: "Visits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_Visits_VisitId",
                table: "Tests",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_TestTypes_testTypeId",
                table: "Tests",
                column: "testTypeId",
                principalTable: "TestTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visits_AspNetUsers_UserId",
                table: "Visits",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Visits_visitId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_Visits_VisitId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Tests_TestTypes_testTypeId",
                table: "Tests");

            migrationBuilder.DropForeignKey(
                name: "FK_Visits_AspNetUsers_UserId",
                table: "Visits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Visits",
                table: "Visits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestTypes",
                table: "TestTypes");

            migrationBuilder.RenameTable(
                name: "Visits",
                newName: "Visit");

            migrationBuilder.RenameTable(
                name: "TestTypes",
                newName: "TestType");

            migrationBuilder.RenameIndex(
                name: "IX_Visits_UserId",
                table: "Visit",
                newName: "IX_Visit_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Visit",
                table: "Visit",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestType",
                table: "TestType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Visit_visitId",
                table: "Results",
                column: "visitId",
                principalTable: "Visit",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_AspNetUsers_UserId",
                table: "Visit",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
