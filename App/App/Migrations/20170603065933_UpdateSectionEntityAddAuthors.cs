using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class UpdateSectionEntityAddAuthors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionId1",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_SectionId1",
                table: "Users",
                column: "SectionId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Sections_SectionId1",
                table: "Users",
                column: "SectionId1",
                principalTable: "Sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Sections_SectionId1",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_SectionId1",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SectionId1",
                table: "Users");
        }
    }
}
