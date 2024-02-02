using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_MusicProgram.Migrations
{
    /// <inheritdoc />
    public partial class AddRating : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tracks_Playlists_PlaylistId",
                table: "Tracks");

            migrationBuilder.DropIndex(
                name: "IX_Tracks_PlaylistId",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "PlaylistId",
                table: "Tracks");

            migrationBuilder.AddColumn<int>(
                name: "Auditions",
                table: "Tracks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Tracks",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "TrackText",
                table: "Tracks",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PlaylistTrack",
                columns: table => new
                {
                    PlaylistsId = table.Column<int>(type: "int", nullable: false),
                    TracksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistTrack", x => new { x.PlaylistsId, x.TracksId });
                    table.ForeignKey(
                        name: "FK_PlaylistTrack_Playlists_PlaylistsId",
                        column: x => x.PlaylistsId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistTrack_Tracks_TracksId",
                        column: x => x.TracksId,
                        principalTable: "Tracks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistTrack_TracksId",
                table: "PlaylistTrack",
                column: "TracksId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaylistTrack");

            migrationBuilder.DropColumn(
                name: "Auditions",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Tracks");

            migrationBuilder.DropColumn(
                name: "TrackText",
                table: "Tracks");

            migrationBuilder.AddColumn<int>(
                name: "PlaylistId",
                table: "Tracks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tracks_PlaylistId",
                table: "Tracks",
                column: "PlaylistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tracks_Playlists_PlaylistId",
                table: "Tracks",
                column: "PlaylistId",
                principalTable: "Playlists",
                principalColumn: "Id");
        }
    }
}
