using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace InstaMedData.Migrations
{
    public partial class edit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tests_AspNetUsers_ApplicationUserId",
                table: "Tests");

            migrationBuilder.DropIndex(
                name: "IX_Tests_ApplicationUserId",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Tests");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Tests",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tests_ApplicationUserId",
                table: "Tests",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tests_AspNetUsers_ApplicationUserId",
                table: "Tests",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
