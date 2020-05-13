using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleWebApi.Migrations
{
    public partial class lostchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProfileImage",
                table: "Users",
                newName: "Profileimage");

            migrationBuilder.RenameColumn(
                name: "DOB",
                table: "Users",
                newName: "Dob");

            migrationBuilder.AlterColumn<string>(
                name: "Profileimage",
                table: "Users",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Profileimage",
                table: "Users",
                newName: "ProfileImage");

            migrationBuilder.RenameColumn(
                name: "Dob",
                table: "Users",
                newName: "DOB");

            migrationBuilder.AlterColumn<byte[]>(
                name: "ProfileImage",
                table: "Users",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
