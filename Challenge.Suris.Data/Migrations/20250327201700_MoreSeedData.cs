using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Challenge.Suris.Data.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ServiceSchedules",
                columns: new[] { "ScheduleId", "ServiceId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 2 },
                    { 9, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 8, 2 });

            migrationBuilder.DeleteData(
                table: "ServiceSchedules",
                keyColumns: new[] { "ScheduleId", "ServiceId" },
                keyValues: new object[] { 9, 2 });
        }
    }
}
