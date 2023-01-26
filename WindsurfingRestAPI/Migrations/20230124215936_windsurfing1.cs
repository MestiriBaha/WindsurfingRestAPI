using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WindsurfingRestAPI.Migrations
{
    /// <inheritdoc />
    public partial class windsurfing1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spots",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Hearts = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spots", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Windsurfers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Windsurfers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SpotWindsurfer",
                columns: table => new
                {
                    SpotsName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WindsurfersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpotWindsurfer", x => new { x.SpotsName, x.WindsurfersID });
                    table.ForeignKey(
                        name: "FK_SpotWindsurfer_Spots_SpotsName",
                        column: x => x.SpotsName,
                        principalTable: "Spots",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpotWindsurfer_Windsurfers_WindsurfersID",
                        column: x => x.WindsurfersID,
                        principalTable: "Windsurfers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpotWindsurfer_WindsurfersID",
                table: "SpotWindsurfer",
                column: "WindsurfersID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpotWindsurfer");

            migrationBuilder.DropTable(
                name: "Spots");

            migrationBuilder.DropTable(
                name: "Windsurfers");
        }
    }
}
