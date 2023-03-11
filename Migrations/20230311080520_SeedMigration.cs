using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Country_Information.Migrations
{
    /// <inheritdoc />
    public partial class SeedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "continents",
                columns: new[] { "id", "description", "name" },
                values: new object[,]
                {
                    { 1, "The only one who aliens invade", "America" },
                    { 2, "The third most populous continent", "Europe" },
                    { 3, "The largest continent", "Asia" },
                    { 4, "kangaroos", "Oceania" },
                    { 5, "The N word", "Africa" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "continents",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "continents",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "continents",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "continents",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "continents",
                keyColumn: "id",
                keyValue: 5);
        }
    }
}
