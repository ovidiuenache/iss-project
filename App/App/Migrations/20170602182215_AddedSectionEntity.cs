using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.Migrations
{
    public partial class AddedSectionEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SectionId",
                table: "Topics",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    SectionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.SectionId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_SectionId",
                table: "Users",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_SectionId",
                table: "Topics",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_Name",
                table: "Sections",
                column: "Name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Sections_SectionId",
                table: "Topics",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Sections_SectionId",
                table: "Users",
                column: "SectionId",
                principalTable: "Sections",
                principalColumn: "SectionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Sections_SectionId",
                table: "Topics");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Sections_SectionId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropIndex(
                name: "IX_Users_SectionId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Topics_SectionId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SectionId",
                table: "Topics");
        }
    }
}
