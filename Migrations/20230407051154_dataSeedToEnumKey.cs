using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BinaAzAPI.Migrations
{
    /// <inheritdoc />
    public partial class dataSeedToEnumKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EnumKeys",
                columns: new[] { "Id", "Key" },
                values: new object[,]
                {
                    { 1, "apartmentType" },
                    { 2, "actionType" },
                    { 3, "rooms" },
                    { 4, "pricePerDayMonth" },
                    { 5, "repair" },
                    { 6, "adOwner" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnumKeys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EnumKeys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EnumKeys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EnumKeys",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EnumKeys",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EnumKeys",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
