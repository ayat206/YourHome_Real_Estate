using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Domain_Models.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataForChoiceAndTypeEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Choise",
                columns: new[] { "id", "choise" },
                values: new object[,]
                {
                    { 1, "Sell" },
                    { 2, "Rent" }
                });

            migrationBuilder.InsertData(
                table: "Type",
                columns: new[] { "id", "type" },
                values: new object[,]
                {
                    { 1, "Apartment" },
                    { 2, "Villa" },
                    { 3, "Home" },
                    { 4, "Townhouse" },
                    { 5, "Building" },
                    { 6, "Office" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Choise",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Choise",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Type",
                keyColumn: "id",
                keyValue: 6);
        }
    }
}
