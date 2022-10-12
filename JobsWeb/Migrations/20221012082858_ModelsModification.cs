using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobsWeb.Migrations
{
    public partial class ModelsModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyTitle",
                table: "Summaries");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Summaries");

            migrationBuilder.AlterColumn<string>(
                name: "Salary",
                table: "Vacancies",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Vacancies",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<List<string>>(
                name: "KeySkills",
                table: "Vacancies",
                type: "text[]",
                nullable: true,
                oldClrType: typeof(List<string>),
                oldType: "text[]");

            migrationBuilder.AddColumn<int>(
                name: "Schedule",
                table: "Vacancies",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "MailAddress",
                table: "Users",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Logo",
                table: "Users",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WorkingExperienceDuration",
                table: "Summaries",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Salary",
                table: "Summaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "InstitutionTitle",
                table: "Summaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "InstitutionFaculty",
                table: "Summaries",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "GraduationYear",
                table: "Summaries",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<List<string>>(
                name: "AdditionalCourses",
                table: "Summaries",
                type: "text[]",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Busyness",
                table: "Summaries",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Summaries",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<List<string>>(
                name: "KeySkills",
                table: "Summaries",
                type: "text[]",
                nullable: true);

            migrationBuilder.AddColumn<List<string>>(
                name: "LanguagesProficiency",
                table: "Summaries",
                type: "text[]",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastCompanyTitle",
                table: "Summaries",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastPosition",
                table: "Summaries",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Schedule",
                table: "Summaries",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Companies",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Companies",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WebSite",
                table: "Companies",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CompanyId",
                table: "Chats",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chats_CompanyId",
                table: "Chats",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chats_Companies_CompanyId",
                table: "Chats",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chats_Companies_CompanyId",
                table: "Chats");

            migrationBuilder.DropIndex(
                name: "IX_Chats_CompanyId",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "Schedule",
                table: "Vacancies");

            migrationBuilder.DropColumn(
                name: "Logo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "AdditionalCourses",
                table: "Summaries");

            migrationBuilder.DropColumn(
                name: "Busyness",
                table: "Summaries");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Summaries");

            migrationBuilder.DropColumn(
                name: "KeySkills",
                table: "Summaries");

            migrationBuilder.DropColumn(
                name: "LanguagesProficiency",
                table: "Summaries");

            migrationBuilder.DropColumn(
                name: "LastCompanyTitle",
                table: "Summaries");

            migrationBuilder.DropColumn(
                name: "LastPosition",
                table: "Summaries");

            migrationBuilder.DropColumn(
                name: "Schedule",
                table: "Summaries");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "WebSite",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Chats");

            migrationBuilder.AlterColumn<string>(
                name: "Salary",
                table: "Vacancies",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Vacancies",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<List<string>>(
                name: "KeySkills",
                table: "Vacancies",
                type: "text[]",
                nullable: false,
                oldClrType: typeof(List<string>),
                oldType: "text[]",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MailAddress",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WorkingExperienceDuration",
                table: "Summaries",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Salary",
                table: "Summaries",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InstitutionTitle",
                table: "Summaries",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "InstitutionFaculty",
                table: "Summaries",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GraduationYear",
                table: "Summaries",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyTitle",
                table: "Summaries",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Summaries",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Logo",
                table: "Companies",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
