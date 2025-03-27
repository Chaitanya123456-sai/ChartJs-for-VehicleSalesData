using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VehicleAPI.Migrations
{
    /// <inheritdoc />
    public partial class initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentCloseRate",
                table: "VehicleData");

            migrationBuilder.DropColumn(
                name: "AppointmentSetRate",
                table: "VehicleData");

            migrationBuilder.AddColumn<int>(
                name: "AppointmentClosed",
                table: "VehicleData",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppointmentSet",
                table: "VehicleData",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppointmentClosed",
                table: "VehicleData");

            migrationBuilder.DropColumn(
                name: "AppointmentSet",
                table: "VehicleData");

            migrationBuilder.AddColumn<decimal>(
                name: "AppointmentCloseRate",
                table: "VehicleData",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AppointmentSetRate",
                table: "VehicleData",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
