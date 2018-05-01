using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InstaMedData.Migrations
{
    public partial class newmethodresultsvisits2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Visits_VisitId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "IdVisit",
                table: "Results");

            migrationBuilder.RenameColumn(
                name: "VisitId",
                table: "Results",
                newName: "visitId");

            migrationBuilder.RenameIndex(
                name: "IX_Results_VisitId",
                table: "Results",
                newName: "IX_Results_visitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Visits_visitId",
                table: "Results",
                column: "visitId",
                principalTable: "Visits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Visits_visitId",
                table: "Results");

            migrationBuilder.RenameColumn(
                name: "visitId",
                table: "Results",
                newName: "VisitId");

            migrationBuilder.RenameIndex(
                name: "IX_Results_visitId",
                table: "Results",
                newName: "IX_Results_VisitId");

            migrationBuilder.AddColumn<int>(
                name: "IdVisit",
                table: "Results",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Visits_VisitId",
                table: "Results",
                column: "VisitId",
                principalTable: "Visits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
