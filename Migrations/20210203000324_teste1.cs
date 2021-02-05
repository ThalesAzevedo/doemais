using Microsoft.EntityFrameworkCore.Migrations;

namespace DoeMaisApi.Migrations
{
    public partial class teste1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "donor",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "RegistrationId",
                table: "donor",
                newName: "registration_id");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "donor",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "BloodType",
                table: "donor",
                newName: "blood_type");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "donor",
                newName: "birth_date");

            migrationBuilder.AlterColumn<string>(
                name: "gender",
                table: "donor",
                type: "TEXT",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "registration_id",
                table: "donor",
                type: "TEXT",
                maxLength: 11,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "donor",
                type: "TEXT",
                maxLength: 70,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "blood_type",
                table: "donor",
                type: "TEXT",
                maxLength: 3,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "birth_date",
                table: "donor",
                type: "TEXT",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "gender",
                table: "donor",
                newName: "Gender");

            migrationBuilder.RenameColumn(
                name: "registration_id",
                table: "donor",
                newName: "RegistrationId");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "donor",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "blood_type",
                table: "donor",
                newName: "BloodType");

            migrationBuilder.RenameColumn(
                name: "birth_date",
                table: "donor",
                newName: "BirthDate");

            migrationBuilder.AlterColumn<string>(
                name: "Gender",
                table: "donor",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "RegistrationId",
                table: "donor",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 11);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "donor",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "BloodType",
                table: "donor",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "BirthDate",
                table: "donor",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 30);
        }
    }
}
