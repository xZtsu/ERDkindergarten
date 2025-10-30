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
            migrationBuilder.CreateTable(
                name: "Absense",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Absense", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ChildGroupHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildGroupHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Morning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MorningSnack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lunch = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DinnerSnack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dinner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateFood = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Portions = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Queue",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobTitle",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JobTitle_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Child",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AbsenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChildGroupHistoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QueuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Child", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Child_Absense_AbsenseId",
                        column: x => x.AbsenseId,
                        principalTable: "Absense",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Child_ChildGroupHistory_ChildGroupHistoryId",
                        column: x => x.ChildGroupHistoryId,
                        principalTable: "ChildGroupHistory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Child_Queue_QueuesId",
                        column: x => x.QueuesId,
                        principalTable: "Queue",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChildCount = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AbsenseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChildGroupHistoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MenuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    QueuesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_Absense_AbsenseId",
                        column: x => x.AbsenseId,
                        principalTable: "Absense",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Group_ChildGroupHistory_ChildGroupHistoryId",
                        column: x => x.ChildGroupHistoryId,
                        principalTable: "ChildGroupHistory",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Group_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Group_Menu_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menu",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Group_Queue_QueuesId",
                        column: x => x.QueuesId,
                        principalTable: "Queue",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Child_AbsenseId",
                table: "Child",
                column: "AbsenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Child_ChildGroupHistoryId",
                table: "Child",
                column: "ChildGroupHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Child_QueuesId",
                table: "Child",
                column: "QueuesId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_AbsenseId",
                table: "Group",
                column: "AbsenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_ChildGroupHistoryId",
                table: "Group",
                column: "ChildGroupHistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_EmployeeId",
                table: "Group",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_MenuId",
                table: "Group",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_QueuesId",
                table: "Group",
                column: "QueuesId");

            migrationBuilder.CreateIndex(
                name: "IX_JobTitle_EmployeeId",
                table: "JobTitle",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Child");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "JobTitle");

            migrationBuilder.DropTable(
                name: "Absense");

            migrationBuilder.DropTable(
                name: "ChildGroupHistory");

            migrationBuilder.DropTable(
                name: "Menu");

            migrationBuilder.DropTable(
                name: "Queue");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
