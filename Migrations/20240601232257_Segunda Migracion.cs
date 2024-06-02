using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class SegundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c285b3e-85db-4da9-8536-088361fa8082");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4798a0dd-9093-4565-ba2e-d6d06ac269c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "efdabdc4-e855-403d-9f75-704cf13a7a4c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4d1ba252-011d-44ae-ba60-d1054e1af807", null, "patient", null },
                    { "6ba99747-f954-4f60-98a2-c45f48aeac83", null, "client", null },
                    { "88c37930-f441-43bd-abce-c28bf9219bd0", null, "admin", "patient" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d1ba252-011d-44ae-ba60-d1054e1af807");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ba99747-f954-4f60-98a2-c45f48aeac83");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "88c37930-f441-43bd-abce-c28bf9219bd0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c285b3e-85db-4da9-8536-088361fa8082", null, "client", null },
                    { "4798a0dd-9093-4565-ba2e-d6d06ac269c5", null, "admin", "patient" },
                    { "efdabdc4-e855-403d-9f75-704cf13a7a4c", null, "patient", null }
                });
        }
    }
}
