using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InstaMedData.Migrations
{
    public partial class initianlnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "T3T4TestId",
                table: "Results",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Results_T3T4TestId",
                table: "Results",
                column: "T3T4TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_T3T4s_T3T4TestId",
                table: "Results",
                column: "T3T4TestId",
                principalTable: "T3T4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_T3T4s_T3T4TestId",
                table: "Results");

            migrationBuilder.DropIndex(
                name: "IX_Results_T3T4TestId",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "T3T4TestId",
                table: "Results");
        }
    }
}
