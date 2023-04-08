using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BinaAzAPI.Migrations
{
    /// <inheritdoc />
    public partial class dataSeedCityDistrictTownship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Baku" });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "Name" },
                values: new object[] { 1, 1, "Nerimanov" });

            migrationBuilder.InsertData(
                table: "Townships",
                columns: new[] { "Id", "DistrictId", "Name" },
                values: new object[] { 1, 1, "Boyukshor" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Townships",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
