using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Workshop.Migrations
{
    public partial class workernotrequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Employees_WorkerId",
                table: "Activities");

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkerId",
                table: "Activities",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Employees_WorkerId",
                table: "Activities",
                column: "WorkerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Employees_WorkerId",
                table: "Activities");

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkerId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Employees_WorkerId",
                table: "Activities",
                column: "WorkerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
