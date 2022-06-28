using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VGC.Migrations
{
    public partial class addMarksToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreateAssessment",
                columns: table => new
                {
                    AssessmentName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AssessmentDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssessmentCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreateAssessment", x => x.AssessmentName);
                });

            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    MarkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Activity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mark = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.MarkId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CreateAssessment");

            migrationBuilder.DropTable(
                name: "Marks");
        }
    }
}
