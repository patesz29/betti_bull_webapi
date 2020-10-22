using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BullService.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cows",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    EarNumber = table.Column<int>(nullable: false),
                    EnarNumber = table.Column<int>(nullable: false),
                    Site = table.Column<int>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    CalvingNumber = table.Column<int>(nullable: false),
                    LastCalvingDate = table.Column<DateTime>(nullable: false),
                    DaysOfGestations = table.Column<int>(nullable: false),
                    LastFertilizationDate = table.Column<DateTime>(nullable: false),
                    CourseOfCalving = table.Column<int>(nullable: false),
                    ClosedLactationMilkProd = table.Column<float>(nullable: false),
                    LastMilkingResult = table.Column<float>(nullable: false),
                    Treatment = table.Column<int>(nullable: false),
                    CalfSex = table.Column<int>(nullable: false),
                    CalfWeight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cows", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CowMeasurements",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CowId = table.Column<string>(nullable: true),
                    MeasurementType = table.Column<int>(nullable: false),
                    MeasurementDate = table.Column<DateTime>(nullable: false),
                    Bcs = table.Column<float>(nullable: false),
                    Lesion = table.Column<string>(nullable: true),
                    UterusStatus = table.Column<int>(nullable: false),
                    CervixDiameter = table.Column<float>(nullable: false),
                    HornDiameter = table.Column<float>(nullable: false),
                    RightOvaryState = table.Column<int>(nullable: false),
                    LeftOvaryState = table.Column<int>(nullable: false),
                    CitologyResultCervix = table.Column<int>(nullable: false),
                    CitologyResultEndometrium = table.Column<int>(nullable: false),
                    Nefa = table.Column<float>(nullable: false),
                    Bhb = table.Column<float>(nullable: false),
                    BetaKarotin = table.Column<float>(nullable: false),
                    QLazResult = table.Column<int>(nullable: false),
                    PregnancyDetectionResult30Day = table.Column<string>(nullable: true),
                    PregnancyDetectionResult60Day = table.Column<string>(nullable: true),
                    FirstSuccessfulFertilizationDate = table.Column<DateTime>(nullable: false),
                    SuccessfulFertilizationNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CowMeasurements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CowMeasurements_Cows_CowId",
                        column: x => x.CowId,
                        principalTable: "Cows",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CowPictures",
                columns: table => new
                {
                    PictureId = table.Column<Guid>(nullable: false),
                    PictureDescription = table.Column<string>(nullable: true),
                    PicturePaths = table.Column<string>(nullable: true),
                    MeasurementId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CowPictures", x => x.PictureId);
                    table.ForeignKey(
                        name: "FK_CowPictures_CowMeasurements_MeasurementId",
                        column: x => x.MeasurementId,
                        principalTable: "CowMeasurements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CowMeasurements_CowId",
                table: "CowMeasurements",
                column: "CowId");

            migrationBuilder.CreateIndex(
                name: "IX_CowPictures_MeasurementId",
                table: "CowPictures",
                column: "MeasurementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CowPictures");

            migrationBuilder.DropTable(
                name: "CowMeasurements");

            migrationBuilder.DropTable(
                name: "Cows");
        }
    }
}
