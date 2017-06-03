using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class UpdateSectionEntityAddRoom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Room",
                table: "Sections",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sections_Room",
                table: "Sections",
                column: "Room",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Sections_Room",
                table: "Sections");

            migrationBuilder.DropColumn(
                name: "Room",
                table: "Sections");
        }
    }
}
