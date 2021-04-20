using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Workshop.Migrations
{
    public partial class databaseModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarType",
                table: "Cars",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "Cars",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Role = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Request",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Result = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Reqistered = table.Column<DateTime>(nullable: false),
                    FinishedOrCancelled = table.Column<DateTime>(nullable: false),
                    CarId = table.Column<Guid>(nullable: true),
                    ManagerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Request", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Request_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Request_Employee_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Result = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Reqistered = table.Column<DateTime>(nullable: false),
                    FinishedOrCancelled = table.Column<DateTime>(nullable: false),
                    ActivityType = table.Column<int>(nullable: false),
                    RequestId = table.Column<Guid>(nullable: true),
                    WorkerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activity_Request_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Request",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activity_Employee_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ClientId",
                table: "Cars",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_RequestId",
                table: "Activity",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_WorkerId",
                table: "Activity",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_CarId",
                table: "Request",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Request_ManagerId",
                table: "Request",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Client_ClientId",
                table: "Cars",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Client_ClientId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Request");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ClientId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "CarType",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Cars");
        }
    }
}
