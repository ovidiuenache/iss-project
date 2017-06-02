using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class UpdateSectionEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionLeaderUserId",
                table: "Sections",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_SectionLeaderUserId",
                table: "Sections",
                column: "SectionLeaderUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Users_SectionLeaderUserId",
                table: "Sections",
                column: "SectionLeaderUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Users_SectionLeaderUserId",
                table: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Sections_SectionLeaderUserId",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "SectionLeaderUserId",
                table: "Sections");
        }
    }
}
