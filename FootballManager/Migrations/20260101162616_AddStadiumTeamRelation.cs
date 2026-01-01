using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FootballManager.Migrations
{
    /// <inheritdoc />
    public partial class AddStadiumTeamRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Stadiums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stadiums_TeamId",
                table: "Stadiums",
                column: "TeamId",
                unique: true,
                filter: "[TeamId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Stadiums_Teams_TeamId",
                table: "Stadiums",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stadiums_Teams_TeamId",
                table: "Stadiums");

            migrationBuilder.DropIndex(
                name: "IX_Stadiums_TeamId",
                table: "Stadiums");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Stadiums");
        }
    }
}
