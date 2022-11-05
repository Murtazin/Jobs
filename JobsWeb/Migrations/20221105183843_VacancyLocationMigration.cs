using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobsWeb.Migrations
{
    public partial class VacancyLocationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Vacancies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Vacancies",
                type: "text",
                nullable: true);
        }
    }
}
