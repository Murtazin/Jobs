using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobsWeb.Migrations
{
    public partial class VacancyNavWordsMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NavigationWords",
                table: "Vacancies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int[]>(
                name: "NavigationWords",
                table: "Vacancies",
                type: "integer[]",
                nullable: true);
        }
    }
}
