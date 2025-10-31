using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class init6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Osakonds_Arstids_ArstidId",
                table: "Osakonds");

            migrationBuilder.DropIndex(
                name: "IX_Osakonds_ArstidId",
                table: "Osakonds");

            migrationBuilder.DropColumn(
                name: "ArstidId",
                table: "Osakonds");

            migrationBuilder.AddColumn<Guid>(
                name: "OsakondId",
                table: "Arstids",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Arstids_OsakondId",
                table: "Arstids",
                column: "OsakondId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arstids_Osakonds_OsakondId",
                table: "Arstids",
                column: "OsakondId",
                principalTable: "Osakonds",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arstids_Osakonds_OsakondId",
                table: "Arstids");

            migrationBuilder.DropIndex(
                name: "IX_Arstids_OsakondId",
                table: "Arstids");

            migrationBuilder.DropColumn(
                name: "OsakondId",
                table: "Arstids");

            migrationBuilder.AddColumn<Guid>(
                name: "ArstidId",
                table: "Osakonds",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Osakonds_ArstidId",
                table: "Osakonds",
                column: "ArstidId");

            migrationBuilder.AddForeignKey(
                name: "FK_Osakonds_Arstids_ArstidId",
                table: "Osakonds",
                column: "ArstidId",
                principalTable: "Arstids",
                principalColumn: "Id");
        }
    }
}
