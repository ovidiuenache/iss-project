using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace App.Migrations
{
    public partial class RemoveProposalMetaInformationEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ProposalMetaInformations_ProposalMetaInformationId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "ProposalMetaInformations");

            migrationBuilder.RenameColumn(
                name: "ProposalMetaInformationId",
                table: "Users",
                newName: "ProposalId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ProposalMetaInformationId",
                table: "Users",
                newName: "IX_Users_ProposalId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Proposals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Proposals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Proposals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Proposals_ProposalId",
                table: "Users",
                column: "ProposalId",
                principalTable: "Proposals",
                principalColumn: "ProposalId",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Proposals_ProposalId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Proposals");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Proposals");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Proposals");

            migrationBuilder.RenameColumn(
                name: "ProposalId",
                table: "Users",
                newName: "ProposalMetaInformationId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ProposalId",
                table: "Users",
                newName: "IX_Users_ProposalMetaInformationId");

            migrationBuilder.CreateTable(
                name: "ProposalMetaInformations",
                columns: table => new
                {
                    ProposalMetaInformationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    ProposalForeignKey = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProposalMetaInformations", x => x.ProposalMetaInformationId);
                    table.ForeignKey(
                        name: "FK_ProposalMetaInformations_Proposals_ProposalForeignKey",
                        column: x => x.ProposalForeignKey,
                        principalTable: "Proposals",
                        principalColumn: "ProposalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProposalMetaInformations_ProposalForeignKey",
                table: "ProposalMetaInformations",
                column: "ProposalForeignKey",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ProposalMetaInformations_ProposalMetaInformationId",
                table: "Users",
                column: "ProposalMetaInformationId",
                principalTable: "ProposalMetaInformations",
                principalColumn: "ProposalMetaInformationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
