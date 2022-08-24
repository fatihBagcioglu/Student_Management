using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University.Data.Migrations
{
    public partial class forth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Lessons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Lessons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
