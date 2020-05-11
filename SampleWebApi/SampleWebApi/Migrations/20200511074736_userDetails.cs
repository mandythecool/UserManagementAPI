using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleWebApi.Migrations
{
    public partial class userDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ethnicity",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "ProfileImage",
                table: "Users",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DOB",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Ethnicity",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "Users");
        }
    }
}
