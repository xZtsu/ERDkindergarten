using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaaratudRavimidRavikulastus");

            migrationBuilder.AddColumn<Guid>(
                name: "MaaratudRavimidId",
                table: "Ravikulastuss",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ravikulastuss_MaaratudRavimidId",
                table: "Ravikulastuss",
                column: "MaaratudRavimidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ravikulastuss_Maaratudravimids_MaaratudRavimidId",
                table: "Ravikulastuss",
                column: "MaaratudRavimidId",
                principalTable: "Maaratudravimids",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ravikulastuss_Maaratudravimids_MaaratudRavimidId",
                table: "Ravikulastuss");

            migrationBuilder.DropIndex(
                name: "IX_Ravikulastuss_MaaratudRavimidId",
                table: "Ravikulastuss");

            migrationBuilder.DropColumn(
                name: "MaaratudRavimidId",
                table: "Ravikulastuss");

            migrationBuilder.CreateTable(
                name: "MaaratudRavimidRavikulastus",
                columns: table => new
                {
                    MaaratudRavimidsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RavikulastusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaaratudRavimidRavikulastus", x => new { x.MaaratudRavimidsId, x.RavikulastusId });
                    table.ForeignKey(
                        name: "FK_MaaratudRavimidRavikulastus_Maaratudravimids_MaaratudRavimidsId",
                        column: x => x.MaaratudRavimidsId,
                        principalTable: "Maaratudravimids",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaaratudRavimidRavikulastus_Ravikulastuss_RavikulastusId",
                        column: x => x.RavikulastusId,
                        principalTable: "Ravikulastuss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaaratudRavimidRavikulastus_RavikulastusId",
                table: "MaaratudRavimidRavikulastus",
                column: "RavikulastusId");
        }
    }
}
