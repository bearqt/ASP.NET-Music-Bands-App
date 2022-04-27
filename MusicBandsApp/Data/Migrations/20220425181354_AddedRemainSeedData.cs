using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicBandsApp.Data.Migrations
{
    public partial class AddedRemainSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "AlbumTitle", "AlbumYear", "ArtistId" },
                values: new object[,]
                {
                    { 1, "AlbumTitle1", 1, 1 },
                    { 2, "AlbumTitle2", 2, 2 },
                    { 3, "AlbumTitle3", 3, 3 },
                    { 4, "AlbumTitle4", 4, 4 },
                    { 5, "AlbumTitle5", 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "ArtistId", "GroupName" },
                values: new object[,]
                {
                    { 1, 1, "GroupName1" },
                    { 2, 2, "GroupName2" },
                    { 3, 3, "GroupName3" },
                    { 4, 4, "GroupName4" },
                    { 5, 5, "GroupName5" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "SongId", "SongDuration", "SongTitle" },
                values: new object[,]
                {
                    { 1, 1.0, "SongTitle1" },
                    { 2, 2.0, "SongTitle2" },
                    { 3, 3.0, "SongTitle3" },
                    { 4, 4.0, "SongTitle4" },
                    { 5, 5.0, "SongTitle5" }
                });

            migrationBuilder.InsertData(
                table: "AlbumSongs",
                columns: new[] { "AlbumId", "SongId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "AlbumSongs",
                keyColumns: new[] { "AlbumId", "SongId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "AlbumId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "SongId",
                keyValue: 5);
        }
    }
}
