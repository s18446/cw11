using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace cw11.Migrations
{
    public partial class wypelnianie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "sad@sadfk.pl", "Jan", "Kowalski" },
                    { 2, "Padfgdgtyk@kss.pl", "Mariusz", "ToSarius" },
                    { 3, "asdadad@kggk.pl", "Ania", "Nowak" },
                    { 4, "dgfgdgdgdfg@asd.pl", "Tadeusz", "Soplica" }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "IdMedicament", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "na bakterie", "Asdafsa", "Antybiotyk" },
                    { 2, "wit C", "WitaminaC", "Witamina" },
                    { 3, "Na gardlo", "Tamtum", "Aerozol" }
                });

            migrationBuilder.InsertData(
                table: "Patiens",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1998, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", "Rogowski" },
                    { 2, new DateTime(2002, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Piotr", "Kowalski" },
                    { 3, new DateTime(1987, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hanna", "Nowak" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, new DateTime(2018, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 3, new DateTime(2018, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 4, new DateTime(2019, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 5, new DateTime(2019, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Prescription_Medicaments",
                columns: new[] { "IdMedicament", "IdPrescription", "Details", "Dose" },
                values: new object[,]
                {
                    { 3, 1, "asdadadad", 4 },
                    { 1, 1, "sadadasfafsaf", 20 },
                    { 2, 2, "dfgdgdgdfgdg", 8 },
                    { 2, 3, "asdadafdsafsf", 15 },
                    { 3, 3, "asdasfsgfsgsg", 10 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumns: new[] { "IdMedicament", "IdPrescription" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "IdMedicament",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patiens",
                keyColumn: "IdPatient",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Patiens",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patiens",
                keyColumn: "IdPatient",
                keyValue: 2);
        }
    }
}
