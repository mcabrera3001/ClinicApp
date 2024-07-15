using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicApp.Migrations
{
    /// <inheritdoc />
    public partial class creaciondelsuperadmin : Migration
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
                    { "229a3bf2-8b0f-44cf-8e44-eeb9289948e9", null, "super_admin", "super_admin" },
                    { "a5534be4-ccf4-4ef6-9184-b8bd9c1f42e8", null, "admin", "patient" },
                    { "b98048f0-1488-4b6b-a9e3-df199a0e82d1", null, "doctor", null },
                    { "e3f8eaeb-d0a4-424f-8569-eee554d0e22a", null, "patient", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "229a3bf2-8b0f-44cf-8e44-eeb9289948e9", null, "super_admin", "super_admin" },
                    { "a5534be4-ccf4-4ef6-9184-b8bd9c1f42e8", null, "admin", "patient" },
                    { "b98048f0-1488-4b6b-a9e3-df199a0e82d1", null, "doctor", null },
                    { "e3f8eaeb-d0a4-424f-8569-eee554d0e22a", null, "patient", null }
                });
        }
    }
}
