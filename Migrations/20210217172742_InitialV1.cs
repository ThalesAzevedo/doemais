using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DoeMaisApi.Migrations
{
    public partial class InitialV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blood_center",
                columns: table => new
                {
                    BloodCenterId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Responsible = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_blood_center", x => x.BloodCenterId);
                });

            migrationBuilder.CreateTable(
                name: "donor",
                columns: table => new
                {
                    DonorId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    first_name = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    last_name = table.Column<string>(type: "TEXT", maxLength: 70, nullable: false),
                    birth_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    registration_id = table.Column<string>(type: "TEXT", maxLength: 11, nullable: false),
                    created_at = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    gender = table.Column<string>(type: "TEXT", maxLength: 1, nullable: false),
                    blood_type = table.Column<string>(type: "TEXT", maxLength: 3, nullable: false),
                    localization = table.Column<string>(type: "TEXT", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donor", x => x.DonorId);
                });

            migrationBuilder.CreateTable(
                name: "donations",
                columns: table => new
                {
                    DonationId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DonorId = table.Column<int>(type: "INTEGER", nullable: false),
                    BloodcenterId = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    Schedule = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_donations", x => x.DonationId);
                    table.ForeignKey(
                        name: "FK_donations_blood_center_BloodcenterId",
                        column: x => x.BloodcenterId,
                        principalTable: "blood_center",
                        principalColumn: "BloodCenterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_donations_donor_DonorId",
                        column: x => x.DonorId,
                        principalTable: "donor",
                        principalColumn: "DonorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_donations_BloodcenterId",
                table: "donations",
                column: "BloodcenterId");

            migrationBuilder.CreateIndex(
                name: "IX_donations_DonorId",
                table: "donations",
                column: "DonorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "donations");

            migrationBuilder.DropTable(
                name: "blood_center");

            migrationBuilder.DropTable(
                name: "donor");
        }
    }
}
