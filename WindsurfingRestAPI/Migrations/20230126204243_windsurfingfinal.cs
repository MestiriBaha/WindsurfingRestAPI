using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WindsurfingRestAPI.Migrations
{
    /// <inheritdoc />
    public partial class windsurfingfinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "Windsurfers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "password",
                table: "Windsurfers");
        }
    }
}
