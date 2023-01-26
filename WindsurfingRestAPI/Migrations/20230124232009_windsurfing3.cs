using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WindsurfingRestAPI.Migrations
{
    /// <inheritdoc />
    public partial class windsurfing3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Windsurfers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Windsurfers",
                newName: "FirstName");

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Windsurfers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Windsurfers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Windsurfers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Windsurfers",
                newName: "Age");
        }
    }
}
