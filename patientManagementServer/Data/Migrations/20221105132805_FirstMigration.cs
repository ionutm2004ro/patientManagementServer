using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace patientManagementServer.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    firstname = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    lastname = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    dob = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    patientsex = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    town = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "dob", "email", "firstname", "lastname", "patientsex", "town" },
                values: new object[] { 1, new DateOnly(2000, 10, 20), "mail1@mail.mail", "firstname1", "lastname1", "Female", "town1" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "dob", "email", "firstname", "lastname", "patientsex", "town" },
                values: new object[] { 2, new DateOnly(2000, 10, 20), "mail2@mail.mail", "firstname2", "lastname2", "Male", "town2" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "dob", "email", "firstname", "lastname", "patientsex", "town" },
                values: new object[] { 3, new DateOnly(2000, 10, 20), "mail3@mail.mail", "firstname3", "lastname3", "Female", "town3" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "dob", "email", "firstname", "lastname", "patientsex", "town" },
                values: new object[] { 4, new DateOnly(2000, 10, 20), "mail4@mail.mail", "firstname4", "lastname4", "Male", "town4" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "dob", "email", "firstname", "lastname", "patientsex", "town" },
                values: new object[] { 5, new DateOnly(2000, 10, 20), "mail5@mail.mail", "firstname5", "lastname5", "Female", "town5" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "dob", "email", "firstname", "lastname", "patientsex", "town" },
                values: new object[] { 6, new DateOnly(2000, 10, 20), "mail6@mail.mail", "firstname6", "lastname6", "Male", "town6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patients");
        }
    }
}
