using Microsoft.EntityFrameworkCore.Migrations;

namespace DoeMaisApi.Migrations
{
    public partial class teste8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "donor",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BloodType",
                table: "donor",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "donor",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "donor",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RegistrationId",
                table: "donor",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "donor");

            migrationBuilder.DropColumn(
                name: "BloodType",
                table: "donor");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "donor");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "donor");

            migrationBuilder.DropColumn(
                name: "RegistrationId",
                table: "donor");
        }
    }
}
