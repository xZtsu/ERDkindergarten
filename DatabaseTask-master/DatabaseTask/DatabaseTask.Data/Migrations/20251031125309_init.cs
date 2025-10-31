using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OsakonnaInfos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Asukoht = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KontaktTelefon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OsakonnaInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ravikulastuss",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Kuupaev = table.Column<DateOnly>(type: "date", nullable: false),
                    Kirjeldus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ravikulastuss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Arstids",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eriala = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TooTelefon = table.Column<int>(type: "int", nullable: false),
                    RavikulastusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arstids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arstids_Ravikulastuss_RavikulastusId",
                        column: x => x.RavikulastusId,
                        principalTable: "Ravikulastuss",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Maaratudravimids",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Toimeaine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Annus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RavikulastusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maaratudravimids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Maaratudravimids_Ravikulastuss_RavikulastusId",
                        column: x => x.RavikulastusId,
                        principalTable: "Ravikulastuss",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patsients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Isikukood = table.Column<int>(type: "int", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sunnikuupaev = table.Column<DateOnly>(type: "date", nullable: false),
                    KontaktTelefon = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RavikulastusId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patsients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patsients_Ravikulastuss_RavikulastusId",
                        column: x => x.RavikulastusId,
                        principalTable: "Ravikulastuss",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Osakonds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OsakonnaNimi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArstidId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OsakonnaInfoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Osakonds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Osakonds_Arstids_ArstidId",
                        column: x => x.ArstidId,
                        principalTable: "Arstids",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Osakonds_OsakonnaInfos_OsakonnaInfoId",
                        column: x => x.OsakonnaInfoId,
                        principalTable: "OsakonnaInfos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ravimids",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ravim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaaratudRavimidId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ravimids", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ravimids_Maaratudravimids_MaaratudRavimidId",
                        column: x => x.MaaratudRavimidId,
                        principalTable: "Maaratudravimids",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arstids_RavikulastusId",
                table: "Arstids",
                column: "RavikulastusId");

            migrationBuilder.CreateIndex(
                name: "IX_Maaratudravimids_RavikulastusId",
                table: "Maaratudravimids",
                column: "RavikulastusId");

            migrationBuilder.CreateIndex(
                name: "IX_Osakonds_ArstidId",
                table: "Osakonds",
                column: "ArstidId");

            migrationBuilder.CreateIndex(
                name: "IX_Osakonds_OsakonnaInfoId",
                table: "Osakonds",
                column: "OsakonnaInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_Patsients_RavikulastusId",
                table: "Patsients",
                column: "RavikulastusId");

            migrationBuilder.CreateIndex(
                name: "IX_Ravimids_MaaratudRavimidId",
                table: "Ravimids",
                column: "MaaratudRavimidId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Osakonds");

            migrationBuilder.DropTable(
                name: "Patsients");

            migrationBuilder.DropTable(
                name: "Ravimids");

            migrationBuilder.DropTable(
                name: "Arstids");

            migrationBuilder.DropTable(
                name: "OsakonnaInfos");

            migrationBuilder.DropTable(
                name: "Maaratudravimids");

            migrationBuilder.DropTable(
                name: "Ravikulastuss");
        }
    }
}
