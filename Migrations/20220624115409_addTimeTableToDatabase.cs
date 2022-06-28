using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VGC.Migrations
{
    public partial class addTimeTableToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TopicInfo",
                table: "Topics",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TopicInfo",
                table: "Topics");
        }
    }
}
