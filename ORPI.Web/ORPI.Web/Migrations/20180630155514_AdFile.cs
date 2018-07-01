using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ORPI.Web.Migrations
{
    public partial class AdFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Agency",
                table: "Agency");

            migrationBuilder.AlterColumn<string>(
                name: "AgencyId",
                table: "Agency",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OpriId",
                table: "Agency",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agency",
                table: "Agency",
                column: "AgencyId");

            migrationBuilder.CreateTable(
                name: "AdFile",
                columns: table => new
                {
                    AdFileId = table.Column<string>(nullable: false),
                    AdvertisingInEnglish = table.Column<string>(nullable: true),
                    AdvertisingInFrench = table.Column<string>(nullable: true),
                    AdvertisingPoster = table.Column<string>(nullable: true),
                    AgencyId = table.Column<string>(nullable: true),
                    AmountOfCommissionTTC = table.Column<string>(nullable: true),
                    AnnualFee = table.Column<string>(nullable: true),
                    AreaSurface = table.Column<string>(nullable: true),
                    BuildType = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    GIEId = table.Column<string>(nullable: true),
                    GeneralAvailabilityOfHousing = table.Column<string>(nullable: true),
                    IndefiniteJointOwnership = table.Column<string>(nullable: true),
                    InsuranceDeposit = table.Column<string>(nullable: true),
                    JointLease = table.Column<string>(nullable: true),
                    LandType = table.Column<string>(nullable: true),
                    LivingArea = table.Column<string>(nullable: true),
                    Null1 = table.Column<string>(nullable: true),
                    Null100 = table.Column<string>(nullable: true),
                    Null101 = table.Column<string>(nullable: true),
                    Null102 = table.Column<string>(nullable: true),
                    Null103 = table.Column<string>(nullable: true),
                    Null104 = table.Column<string>(nullable: true),
                    Null105 = table.Column<string>(nullable: true),
                    Null106 = table.Column<string>(nullable: true),
                    Null107 = table.Column<string>(nullable: true),
                    Null108 = table.Column<string>(nullable: true),
                    Null109 = table.Column<string>(nullable: true),
                    Null110 = table.Column<string>(nullable: true),
                    Null111 = table.Column<string>(nullable: true),
                    Null112 = table.Column<string>(nullable: true),
                    Null113 = table.Column<string>(nullable: true),
                    Null114 = table.Column<string>(nullable: true),
                    Null115 = table.Column<string>(nullable: true),
                    Null116 = table.Column<string>(nullable: true),
                    Null117 = table.Column<string>(nullable: true),
                    Null118 = table.Column<string>(nullable: true),
                    Null119 = table.Column<string>(nullable: true),
                    Null120 = table.Column<string>(nullable: true),
                    Null121 = table.Column<string>(nullable: true),
                    Null122 = table.Column<string>(nullable: true),
                    Null123 = table.Column<string>(nullable: true),
                    Null124 = table.Column<string>(nullable: true),
                    Null125 = table.Column<string>(nullable: true),
                    Null126 = table.Column<string>(nullable: true),
                    Null127 = table.Column<string>(nullable: true),
                    Null2 = table.Column<string>(nullable: true),
                    Null3 = table.Column<string>(nullable: true),
                    Null4 = table.Column<string>(nullable: true),
                    Null5 = table.Column<string>(nullable: true),
                    NumberOfChamber = table.Column<string>(nullable: true),
                    NumberOfFloor = table.Column<string>(nullable: true),
                    NumberOfMandate = table.Column<string>(nullable: true),
                    NumberOfRooms = table.Column<string>(nullable: true),
                    Photo1 = table.Column<string>(nullable: true),
                    Photo10 = table.Column<string>(nullable: true),
                    Photo11 = table.Column<string>(nullable: true),
                    Photo12 = table.Column<string>(nullable: true),
                    Photo13 = table.Column<string>(nullable: true),
                    Photo14 = table.Column<string>(nullable: true),
                    Photo15 = table.Column<string>(nullable: true),
                    Photo16 = table.Column<string>(nullable: true),
                    Photo17 = table.Column<string>(nullable: true),
                    Photo18 = table.Column<string>(nullable: true),
                    Photo19 = table.Column<string>(nullable: true),
                    Photo2 = table.Column<string>(nullable: true),
                    Photo20 = table.Column<string>(nullable: true),
                    Photo3 = table.Column<string>(nullable: true),
                    Photo4 = table.Column<string>(nullable: true),
                    Photo5 = table.Column<string>(nullable: true),
                    Photo6 = table.Column<string>(nullable: true),
                    Photo7 = table.Column<string>(nullable: true),
                    Photo8 = table.Column<string>(nullable: true),
                    Photo9 = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    Rent = table.Column<string>(nullable: true),
                    RentOfFurniture = table.Column<string>(nullable: true),
                    RentTTC = table.Column<string>(nullable: true),
                    ShortAdvertisement = table.Column<string>(nullable: true),
                    Square = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    TypeOfBuilding = table.Column<string>(nullable: true),
                    TypeOfMandate = table.Column<string>(nullable: true),
                    TypeOfOwnership = table.Column<string>(nullable: true),
                    VirtualPartnersURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdFile", x => x.AdFileId);
                    table.ForeignKey(
                        name: "FK_AdFile_Agency_AgencyId",
                        column: x => x.AgencyId,
                        principalTable: "Agency",
                        principalColumn: "AgencyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdFile_AgencyId",
                table: "AdFile",
                column: "AgencyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdFile");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agency",
                table: "Agency");

            migrationBuilder.AlterColumn<string>(
                name: "OpriId",
                table: "Agency",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AgencyId",
                table: "Agency",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agency",
                table: "Agency",
                column: "OpriId");
        }
    }
}
