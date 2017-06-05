using Microsoft.EntityFrameworkCore.Migrations;

namespace App.Migrations
{
    public partial class UpdateSectionEntityAddProposalsList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "Proposals",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proposals_SectionId",
                table: "Proposals",
                column: "SectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proposals_Sections_SectionId",
                table: "Proposals",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proposals_Sections_SectionId",
                table: "Proposals");

            migrationBuilder.DropIndex(
                name: "IX_Proposals_SectionId",
                table: "Proposals");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "Proposals");
        }
    }
}
