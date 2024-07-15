using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class creaciondelsuperadmin1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "229a3bf2-8b0f-44cf-8e44-eeb9289948e9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5534be4-ccf4-4ef6-9184-b8bd9c1f42e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b98048f0-1488-4b6b-a9e3-df199a0e82d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3f8eaeb-d0a4-424f-8569-eee554d0e22a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1295d0ea-2050-4ea9-a0a9-7a833b6b37fb", null, "patient", null },
                    { "14326acb-3dce-4aab-9567-317d05d9da9a", null, "admin", "patient" },
                    { "4178f865-57cd-430f-821c-c0e2f7b3c966", null, "super_admin", "super_admin" },
                    { "918e74a5-90d1-4aff-bb52-ba79ab0cb395", null, "doctor", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1295d0ea-2050-4ea9-a0a9-7a833b6b37fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14326acb-3dce-4aab-9567-317d05d9da9a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4178f865-57cd-430f-821c-c0e2f7b3c966");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "918e74a5-90d1-4aff-bb52-ba79ab0cb395");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "229a3bf2-8b0f-44cf-8e44-eeb9289948e9", null, "super_admin", "super_admin" },
                    { "a5534be4-ccf4-4ef6-9184-b8bd9c1f42e8", null, "admin", "patient" },
                    { "b98048f0-1488-4b6b-a9e3-df199a0e82d1", null, "doctor", null },
                    { "e3f8eaeb-d0a4-424f-8569-eee554d0e22a", null, "patient", null }
                });
        }
    }
}
