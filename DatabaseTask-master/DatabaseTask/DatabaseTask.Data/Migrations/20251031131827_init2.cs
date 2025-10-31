using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ravikulastuss_Ravimids_RavimidId",
                table: "Ravikulastuss");

            migrationBuilder.DropIndex(
                name: "IX_Ravikulastuss_RavimidId",
                table: "Ravikulastuss");

            migrationBuilder.DropColumn(
                name: "RavimidId",
                table: "Ravikulastuss");

            migrationBuilder.AddColumn<Guid>(
                name: "RavimidId",
                table: "Maaratudravimids",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Maaratudravimids_RavimidId",
                table: "Maaratudravimids",
                column: "RavimidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Maaratudravimids_Ravimids_RavimidId",
                table: "Maaratudravimids",
                column: "RavimidId",
                principalTable: "Ravimids",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Maaratudravimids_Ravimids_RavimidId",
                table: "Maaratudravimids");

            migrationBuilder.DropIndex(
                name: "IX_Maaratudravimids_RavimidId",
                table: "Maaratudravimids");

            migrationBuilder.DropColumn(
                name: "RavimidId",
                table: "Maaratudravimids");

            migrationBuilder.AddColumn<Guid>(
                name: "RavimidId",
                table: "Ravikulastuss",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ravikulastuss_RavimidId",
                table: "Ravikulastuss",
                column: "RavimidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ravikulastuss_Ravimids_RavimidId",
                table: "Ravikulastuss",
                column: "RavimidId",
                principalTable: "Ravimids",
                principalColumn: "Id");
        }
    }
}
