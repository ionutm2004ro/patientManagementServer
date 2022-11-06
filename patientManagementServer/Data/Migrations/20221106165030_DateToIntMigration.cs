using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace patientManagementServer.Data.Migrations
{
    public partial class DateToIntMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "dob",
                table: "Patients",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(DateOnly),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "dob",
                value: 20000102);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "dob",
                value: 20000204);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "dob",
                value: 20000306);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "dob",
                value: 20000408);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "dob",
                value: 20000510);

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                column: "dob",
                value: 20000612);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateOnly>(
                name: "dob",
                table: "Patients",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 1,
                column: "dob",
                value: new DateOnly(2000, 10, 20));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 2,
                column: "dob",
                value: new DateOnly(2000, 10, 20));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 3,
                column: "dob",
                value: new DateOnly(2000, 10, 20));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 4,
                column: "dob",
                value: new DateOnly(2000, 10, 20));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 5,
                column: "dob",
                value: new DateOnly(2000, 10, 20));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: 6,
                column: "dob",
                value: new DateOnly(2000, 10, 20));
        }
    }
}
