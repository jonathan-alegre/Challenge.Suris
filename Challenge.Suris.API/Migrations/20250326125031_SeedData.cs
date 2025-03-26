using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Challenge.Suris.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedData: Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "ScheduleId", "DateTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 3, 31, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2025, 3, 31, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2025, 3, 31, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2025, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2025, 4, 1, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2025, 4, 1, 14, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2025, 4, 2, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2025, 4, 2, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2025, 4, 2, 13, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "ServiceId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Limpieza de Palier y Ascensores", "Limpieza" },
                    { 2, "Arreglos de fonatenería y destapaciones", "Plomería" },
                    { 3, "Instalaciones y reparaciones eléctricas de unidades departamentales", "Electricidad" }
                });

            migrationBuilder.InsertData(
                table: "ServiceSchedules",
                columns: new[] { "ScheduleId", "ServiceId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 3 },
                    { 7, 3 },
                    { 8, 3 },
                    { 9, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 7, 3 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 8, 3 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ScheduleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ScheduleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ScheduleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ScheduleId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ScheduleId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ScheduleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ScheduleId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ScheduleId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Schedules",
                keyColumn: "ScheduleId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "ServiceId",
                keyValue: 3);
        }
    }
}
