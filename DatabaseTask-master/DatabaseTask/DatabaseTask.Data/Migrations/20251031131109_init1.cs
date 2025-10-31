using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arstids_Ravikulastuss_RavikulastusId",
                table: "Arstids");

            migrationBuilder.DropForeignKey(
                name: "FK_Maaratudravimids_Ravikulastuss_RavikulastusId",
                table: "Maaratudravimids");

            migrationBuilder.DropForeignKey(
                name: "FK_Patsients_Ravikulastuss_RavikulastusId",
                table: "Patsients");

            migrationBuilder.DropForeignKey(
                name: "FK_Ravimids_Maaratudravimids_MaaratudRavimidId",
                table: "Ravimids");

            migrationBuilder.DropIndex(
                name: "IX_Ravimids_MaaratudRavimidId",
                table: "Ravimids");

            migrationBuilder.DropIndex(
                name: "IX_Patsients_RavikulastusId",
                table: "Patsients");

            migrationBuilder.DropIndex(
                name: "IX_Maaratudravimids_RavikulastusId",
                table: "Maaratudravimids");

            migrationBuilder.DropIndex(
                name: "IX_Arstids_RavikulastusId",
                table: "Arstids");

            migrationBuilder.DropColumn(
                name: "MaaratudRavimidId",
                table: "Ravimids");

            migrationBuilder.DropColumn(
                name: "RavikulastusId",
                table: "Patsients");

            migrationBuilder.DropColumn(
                name: "RavikulastusId",
                table: "Maaratudravimids");

            migrationBuilder.DropColumn(
                name: "RavikulastusId",
                table: "Arstids");

            migrationBuilder.AddColumn<Guid>(
                name: "ArstidId",
                table: "Ravikulastuss",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PatsientId",
                table: "Ravikulastuss",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RavimidId",
                table: "Ravikulastuss",
                type: "uniqueidentifier",
                nullable: true);

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
                name: "IX_Ravikulastuss_ArstidId",
                table: "Ravikulastuss",
                column: "ArstidId");

            migrationBuilder.CreateIndex(
                name: "IX_Ravikulastuss_PatsientId",
                table: "Ravikulastuss",
                column: "PatsientId");

            migrationBuilder.CreateIndex(
                name: "IX_Ravikulastuss_RavimidId",
                table: "Ravikulastuss",
                column: "RavimidId");

            migrationBuilder.CreateIndex(
                name: "IX_MaaratudRavimidRavikulastus_RavikulastusId",
                table: "MaaratudRavimidRavikulastus",
                column: "RavikulastusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ravikulastuss_Arstids_ArstidId",
                table: "Ravikulastuss",
                column: "ArstidId",
                principalTable: "Arstids",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ravikulastuss_Patsients_PatsientId",
                table: "Ravikulastuss",
                column: "PatsientId",
                principalTable: "Patsients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ravikulastuss_Ravimids_RavimidId",
                table: "Ravikulastuss",
                column: "RavimidId",
                principalTable: "Ravimids",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ravikulastuss_Arstids_ArstidId",
                table: "Ravikulastuss");

            migrationBuilder.DropForeignKey(
                name: "FK_Ravikulastuss_Patsients_PatsientId",
                table: "Ravikulastuss");

            migrationBuilder.DropForeignKey(
                name: "FK_Ravikulastuss_Ravimids_RavimidId",
                table: "Ravikulastuss");

            migrationBuilder.DropTable(
                name: "MaaratudRavimidRavikulastus");

            migrationBuilder.DropIndex(
                name: "IX_Ravikulastuss_ArstidId",
                table: "Ravikulastuss");

            migrationBuilder.DropIndex(
                name: "IX_Ravikulastuss_PatsientId",
                table: "Ravikulastuss");

            migrationBuilder.DropIndex(
                name: "IX_Ravikulastuss_RavimidId",
                table: "Ravikulastuss");

            migrationBuilder.DropColumn(
                name: "ArstidId",
                table: "Ravikulastuss");

            migrationBuilder.DropColumn(
                name: "PatsientId",
                table: "Ravikulastuss");

            migrationBuilder.DropColumn(
                name: "RavimidId",
                table: "Ravikulastuss");

            migrationBuilder.AddColumn<Guid>(
                name: "MaaratudRavimidId",
                table: "Ravimids",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RavikulastusId",
                table: "Patsients",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RavikulastusId",
                table: "Maaratudravimids",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RavikulastusId",
                table: "Arstids",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ravimids_MaaratudRavimidId",
                table: "Ravimids",
                column: "MaaratudRavimidId");

            migrationBuilder.CreateIndex(
                name: "IX_Patsients_RavikulastusId",
                table: "Patsients",
                column: "RavikulastusId");

            migrationBuilder.CreateIndex(
                name: "IX_Maaratudravimids_RavikulastusId",
                table: "Maaratudravimids",
                column: "RavikulastusId");

            migrationBuilder.CreateIndex(
                name: "IX_Arstids_RavikulastusId",
                table: "Arstids",
                column: "RavikulastusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arstids_Ravikulastuss_RavikulastusId",
                table: "Arstids",
                column: "RavikulastusId",
                principalTable: "Ravikulastuss",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Maaratudravimids_Ravikulastuss_RavikulastusId",
                table: "Maaratudravimids",
                column: "RavikulastusId",
                principalTable: "Ravikulastuss",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patsients_Ravikulastuss_RavikulastusId",
                table: "Patsients",
                column: "RavikulastusId",
                principalTable: "Ravikulastuss",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ravimids_Maaratudravimids_MaaratudRavimidId",
                table: "Ravimids",
                column: "MaaratudRavimidId",
                principalTable: "Maaratudravimids",
                principalColumn: "Id");
        }
    }
}
