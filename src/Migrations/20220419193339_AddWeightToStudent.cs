using Microsoft.EntityFrameworkCore.Migrations;

namespace EFAndLinqPractice_SchoolAPI.Migrations
{
    public partial class AddWeightToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "Students",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Students");
        }
    }
}
