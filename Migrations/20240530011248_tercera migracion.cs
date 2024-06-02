using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class Terceramigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ab77cf94-544e-4355-a7f6-7f6d54132716");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b155d600-9462-4fe6-9eee-ee5789eb346f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e13bc328-9ef7-4933-b435-c16baa3fa653");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6439a933-afaa-4385-aadf-281fa15aafef", null, "admin", "patient" },
                    { "8a06e7a3-d763-4550-95d2-cf3406cb1925", null, "patient", null },
                    { "9f3c4c7b-28ed-451d-9a39-8b015af315c6", null, "client", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6439a933-afaa-4385-aadf-281fa15aafef");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a06e7a3-d763-4550-95d2-cf3406cb1925");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f3c4c7b-28ed-451d-9a39-8b015af315c6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ab77cf94-544e-4355-a7f6-7f6d54132716", null, "patient", null },
                    { "b155d600-9462-4fe6-9eee-ee5789eb346f", null, "client", null },
                    { "e13bc328-9ef7-4933-b435-c16baa3fa653", null, "admim", "patient" }
                });
        }
    }
}
