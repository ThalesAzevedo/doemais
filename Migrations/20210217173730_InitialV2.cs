using Microsoft.EntityFrameworkCore.Migrations;

namespace DoeMaisApi.Migrations
{
    public partial class InitialV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "blood_center",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "blood_center");
        }
    }
}
