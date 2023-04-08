using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BinaAzAPI.Migrations
{
    /// <inheritdoc />
    public partial class dataSeedToEnumValue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EnumValues",
                columns: new[] { "Id", "KeyId", "Value" },
                values: new object[,]
                {
                    { 1, 1, "New Building" },
                    { 2, 1, "Old Building" },
                    { 3, 2, "I Sell" },
                    { 4, 2, "I Rent" },
                    { 5, 3, "1 room" },
                    { 6, 3, "2 rooms" },
                    { 7, 3, "3 rooms" },
                    { 8, 3, "4 rooms" },
                    { 9, 3, "5 rooms" },
                    { 10, 3, "6 rooms" },
                    { 11, 4, "Per Day" },
                    { 12, 4, "Per Month" },
                    { 13, 5, "Repaired" },
                    { 14, 5, "Unrepaired" },
                    { 15, 6, "I am the Owner" },
                    { 16, 6, "I am an Agent" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "EnumValues",
                keyColumn: "Id",
                keyValue: 16);
        }
    }
}
