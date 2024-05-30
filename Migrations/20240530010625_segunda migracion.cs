using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class Segundamigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
