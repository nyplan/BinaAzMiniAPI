using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BinaAzAPI.Migrations
{
    /// <inheritdoc />
    public partial class addAds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AdNumber = table.Column<int>(type: "integer", nullable: false),
                    ApartmentTypeId = table.Column<int>(type: "integer", nullable: false),
                    ActionTypeId = table.Column<int>(type: "integer", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    RoomsId = table.Column<int>(type: "integer", nullable: false),
                    Area = table.Column<int>(type: "integer", nullable: false),
                    Floor = table.Column<int>(type: "integer", nullable: false),
                    NumberOfFloors = table.Column<int>(type: "integer", nullable: false),
                    AdditionalInformation = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<int>(type: "integer", nullable: false),
                    PricePerDayMonthId = table.Column<int>(type: "integer", nullable: false),
                    RepairId = table.Column<int>(type: "integer", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: true),
                    DistrictId = table.Column<int>(type: "integer", nullable: false),
                    TownshipId = table.Column<int>(type: "integer", nullable: false),
                    RelevantPerson = table.Column<string>(type: "text", nullable: true),
                    AdOwnerId = table.Column<int>(type: "integer", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ads_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ads_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ads_EnumValues_ActionTypeId",
                        column: x => x.ActionTypeId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ads_EnumValues_AdOwnerId",
                        column: x => x.AdOwnerId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ads_EnumValues_ApartmentTypeId",
                        column: x => x.ApartmentTypeId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ads_EnumValues_PricePerDayMonthId",
                        column: x => x.PricePerDayMonthId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ads_EnumValues_RepairId",
                        column: x => x.RepairId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ads_EnumValues_RoomsId",
                        column: x => x.RoomsId,
                        principalTable: "EnumValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ads_Townships_TownshipId",
                        column: x => x.TownshipId,
                        principalTable: "Townships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ads_ActionTypeId",
                table: "Ads",
                column: "ActionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_AdOwnerId",
                table: "Ads",
                column: "AdOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_ApartmentTypeId",
                table: "Ads",
                column: "ApartmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_CityId",
                table: "Ads",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_DistrictId",
                table: "Ads",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_PricePerDayMonthId",
                table: "Ads",
                column: "PricePerDayMonthId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_RepairId",
                table: "Ads",
                column: "RepairId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_RoomsId",
                table: "Ads",
                column: "RoomsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ads_TownshipId",
                table: "Ads",
                column: "TownshipId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ads");
        }
    }
}
