using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WanderlustItinerary.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Package",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "PackageName", "Price", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 13, 12, 43, 29, 826, DateTimeKind.Local).AddTicks(84), new DateTime(2025, 12, 13, 12, 43, 29, 826, DateTimeKind.Local).AddTicks(100), "7-day Tokyo & Kyoto tour", "Japan Explorer", 2500m, "System" },
                    { 2, "System", new DateTime(2025, 12, 13, 12, 43, 29, 826, DateTimeKind.Local).AddTicks(104), new DateTime(2025, 12, 13, 12, 43, 29, 826, DateTimeKind.Local).AddTicks(104), "5-day Seoul & Busan tour", "Korea Highlights", 1800m, "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Package",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
