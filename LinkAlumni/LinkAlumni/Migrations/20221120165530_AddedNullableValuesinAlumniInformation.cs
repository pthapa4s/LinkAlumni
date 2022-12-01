using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinkAlumni.Migrations
{
    public partial class AddedNullableValuesinAlumniInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PostGraduateDegree",
                table: "AlumniInformation",
                type: "nvarchar(8000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8000)");

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "AlumniInformation",
                type: "nvarchar(8000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8000)");

            migrationBuilder.AlterColumn<string>(
                name: "Internships",
                table: "AlumniInformation",
                type: "nvarchar(8000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8000)");

            migrationBuilder.AlterColumn<string>(
                name: "CurrentJobTitle",
                table: "AlumniInformation",
                type: "nvarchar(8000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8000)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "AlumniInformation",
                type: "nvarchar(8000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8000)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyAddress",
                table: "AlumniInformation",
                type: "nvarchar(8000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8000)");

            migrationBuilder.AlterColumn<string>(
                name: "Certificates",
                table: "AlumniInformation",
                type: "nvarchar(8000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(8000)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PostGraduateDegree",
                table: "AlumniInformation",
                type: "nvarchar(8000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(8000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "AlumniInformation",
                type: "nvarchar(8000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(8000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Internships",
                table: "AlumniInformation",
                type: "nvarchar(8000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(8000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CurrentJobTitle",
                table: "AlumniInformation",
                type: "nvarchar(8000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(8000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "AlumniInformation",
                type: "nvarchar(8000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(8000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CompanyAddress",
                table: "AlumniInformation",
                type: "nvarchar(8000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(8000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Certificates",
                table: "AlumniInformation",
                type: "nvarchar(8000)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(8000)",
                oldNullable: true);
        }
    }
}
