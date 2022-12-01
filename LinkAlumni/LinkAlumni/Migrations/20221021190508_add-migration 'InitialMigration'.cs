using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LinkAlumni.Migrations
{
    public partial class addmigrationInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlumniInformation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(8000)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(8000)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(8000)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(8000)", nullable: false),
                    PhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(8000)", nullable: false),
                    GraduationYear = table.Column<int>(type: "int", nullable: false),
                    DegreeReceived = table.Column<string>(type: "nvarchar(8000)", nullable: false),
                    Major = table.Column<string>(type: "nvarchar(8000)", nullable: false),
                    PostGraduateDegree = table.Column<string>(type: "nvarchar(8000)", nullable: false),
                    Certificates = table.Column<string>(type: "nvarchar(8000)", nullable: false),
                    Internships = table.Column<string>(type: "nvarchar(8000)", nullable: false),
                    CurrentJobTitle = table.Column<string>(type: "nvarchar(8000)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(8000)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(8000)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(8000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlumniInformation", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlumniInformation");
        }
    }
}
