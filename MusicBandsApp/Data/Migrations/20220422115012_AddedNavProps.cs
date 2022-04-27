using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicBandsApp.Data.Migrations
{
    public partial class AddedNavProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AlbumSongs_SongId",
                table: "AlbumSongs",
                column: "SongId");

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumSongs_Albums_AlbumId",
                table: "AlbumSongs",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "AlbumId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AlbumSongs_Songs_SongId",
                table: "AlbumSongs",
                column: "SongId",
                principalTable: "Songs",
                principalColumn: "SongId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AlbumSongs_Albums_AlbumId",
                table: "AlbumSongs");

            migrationBuilder.DropForeignKey(
                name: "FK_AlbumSongs_Songs_SongId",
                table: "AlbumSongs");

            migrationBuilder.DropIndex(
                name: "IX_AlbumSongs_SongId",
                table: "AlbumSongs");
        }
    }
}
