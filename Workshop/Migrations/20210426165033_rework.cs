using Microsoft.EntityFrameworkCore.Migrations;

namespace Workshop.Migrations
{
    public partial class rework : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarType",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ActivityType",
                table: "Activity");

            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "Request",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsHidden",
                table: "Request",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsHidden",
                table: "Employee",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Employee",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHidden",
                table: "Client",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CarTypeCode",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHidden",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationNumber",
                table: "Cars",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Result",
                table: "Activity",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "ActivityTypeCode",
                table: "Activity",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsHidden",
                table: "Activity",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ActivityType",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    IsHidden = table.Column<bool>(nullable: false),
                    ActivityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityType", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "CarType",
                columns: table => new
                {
                    Code = table.Column<string>(nullable: false),
                    IsHidden = table.Column<bool>(nullable: false),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarType", x => x.Code);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarTypeCode",
                table: "Cars",
                column: "CarTypeCode");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_ActivityTypeCode",
                table: "Activity",
                column: "ActivityTypeCode");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_ActivityType_ActivityTypeCode",
                table: "Activity",
                column: "ActivityTypeCode",
                principalTable: "ActivityType",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarType_CarTypeCode",
                table: "Cars",
                column: "CarTypeCode",
                principalTable: "CarType",
                principalColumn: "Code",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_ActivityType_ActivityTypeCode",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarType_CarTypeCode",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "ActivityType");

            migrationBuilder.DropTable(
                name: "CarType");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CarTypeCode",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Activity_ActivityTypeCode",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "IsHidden",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "IsHidden",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "IsHidden",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "CarTypeCode",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "IsHidden",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "RegistrationNumber",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "ActivityTypeCode",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "IsHidden",
                table: "Activity");

            migrationBuilder.AlterColumn<int>(
                name: "Result",
                table: "Request",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarType",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Result",
                table: "Activity",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ActivityType",
                table: "Activity",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
