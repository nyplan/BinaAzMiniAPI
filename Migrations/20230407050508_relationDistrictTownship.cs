using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BinaAzAPI.Migrations
{
    /// <inheritdoc />
    public partial class relationDistrictTownship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Townships",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Townships_DistrictId",
                table: "Townships",
                column: "DistrictId");

            migrationBuilder.AddForeignKey(
                name: "FK_Townships_Districts_DistrictId",
                table: "Townships",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Townships_Districts_DistrictId",
                table: "Townships");

            migrationBuilder.DropIndex(
                name: "IX_Townships_DistrictId",
                table: "Townships");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Townships");
        }
    }
}
