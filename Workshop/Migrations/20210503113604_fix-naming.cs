using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Workshop.Migrations
{
    public partial class fixnaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_ActivityType_ActivityTypeCode",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Request_RequestId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Employee_WorkerId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarType_CarTypeCode",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Client_ClientId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_Cars_CarId",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_Employee_ManagerId",
                table: "Request");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Reqistered",
                table: "Activity");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.AlterColumn<Guid>(
                name: "ManagerId",
                table: "Request",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CarId",
                table: "Request",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Client",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Client",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Client",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeName",
                table: "CarType",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RegistrationNumber",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CarTypeCode",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityName",
                table: "ActivityType",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkerId",
                table: "Activity",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RequestId",
                table: "Activity",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ActivityTypeCode",
                table: "Activity",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Registered",
                table: "Activity",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "SequenceNumber",
                table: "Activity",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_RegistrationNumber",
                table: "Cars",
                column: "RegistrationNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Username",
                table: "Employees",
                column: "Username",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_ActivityType_ActivityTypeCode",
                table: "Activity",
                column: "ActivityTypeCode",
                principalTable: "ActivityType",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Request_RequestId",
                table: "Activity",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Employees_WorkerId",
                table: "Activity",
                column: "WorkerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarType_CarTypeCode",
                table: "Cars",
                column: "CarTypeCode",
                principalTable: "CarType",
                principalColumn: "Code",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Client_ClientId",
                table: "Cars",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Cars_CarId",
                table: "Request",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Employees_ManagerId",
                table: "Request",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_ActivityType_ActivityTypeCode",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Request_RequestId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Employees_WorkerId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarType_CarTypeCode",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Client_ClientId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_Cars_CarId",
                table: "Request");

            migrationBuilder.DropForeignKey(
                name: "FK_Request_Employees_ManagerId",
                table: "Request");

            migrationBuilder.DropIndex(
                name: "IX_Cars_RegistrationNumber",
                table: "Cars");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_Username",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Registered",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "SequenceNumber",
                table: "Activity");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.AlterColumn<Guid>(
                name: "ManagerId",
                table: "Request",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "CarId",
                table: "Request",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "TypeName",
                table: "CarType",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "RegistrationNumber",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "ClientId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "CarTypeCode",
                table: "Cars",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ActivityName",
                table: "ActivityType",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<Guid>(
                name: "WorkerId",
                table: "Activity",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "RequestId",
                table: "Activity",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<string>(
                name: "ActivityTypeCode",
                table: "Activity",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<DateTime>(
                name: "Reqistered",
                table: "Activity",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_ActivityType_ActivityTypeCode",
                table: "Activity",
                column: "ActivityTypeCode",
                principalTable: "ActivityType",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Request_RequestId",
                table: "Activity",
                column: "RequestId",
                principalTable: "Request",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Employee_WorkerId",
                table: "Activity",
                column: "WorkerId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarType_CarTypeCode",
                table: "Cars",
                column: "CarTypeCode",
                principalTable: "CarType",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Client_ClientId",
                table: "Cars",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Cars_CarId",
                table: "Request",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Request_Employee_ManagerId",
                table: "Request",
                column: "ManagerId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
