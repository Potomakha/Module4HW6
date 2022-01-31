using Microsoft.EntityFrameworkCore.Migrations;

namespace Module4HW6.Migrations
{
    public partial class AddNewTitles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistSong_Artists_ArtistsArtistId",
                table: "ArtistSong");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistSong_Songs_SongsSongId",
                table: "ArtistSong");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Genres_GenreId",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Songs",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genres",
                table: "Genres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artists",
                table: "Artists");

            migrationBuilder.RenameTable(
                name: "Songs",
                newName: "Song");

            migrationBuilder.RenameTable(
                name: "Genres",
                newName: "Genre");

            migrationBuilder.RenameTable(
                name: "Artists",
                newName: "Artist");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_GenreId",
                table: "Song",
                newName: "IX_Song_GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Song",
                table: "Song",
                column: "SongId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artist",
                table: "Artist",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistSong_Artist_ArtistsArtistId",
                table: "ArtistSong",
                column: "ArtistsArtistId",
                principalTable: "Artist",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistSong_Song_SongsSongId",
                table: "ArtistSong",
                column: "SongsSongId",
                principalTable: "Song",
                principalColumn: "SongId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Song_Genre_GenreId",
                table: "Song",
                column: "GenreId",
                principalTable: "Genre",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistSong_Artist_ArtistsArtistId",
                table: "ArtistSong");

            migrationBuilder.DropForeignKey(
                name: "FK_ArtistSong_Song_SongsSongId",
                table: "ArtistSong");

            migrationBuilder.DropForeignKey(
                name: "FK_Song_Genre_GenreId",
                table: "Song");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Song",
                table: "Song");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Artist",
                table: "Artist");

            migrationBuilder.RenameTable(
                name: "Song",
                newName: "Songs");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "Genres");

            migrationBuilder.RenameTable(
                name: "Artist",
                newName: "Artists");

            migrationBuilder.RenameIndex(
                name: "IX_Song_GenreId",
                table: "Songs",
                newName: "IX_Songs_GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Songs",
                table: "Songs",
                column: "SongId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genres",
                table: "Genres",
                column: "GenreId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Artists",
                table: "Artists",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistSong_Artists_ArtistsArtistId",
                table: "ArtistSong",
                column: "ArtistsArtistId",
                principalTable: "Artists",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistSong_Songs_SongsSongId",
                table: "ArtistSong",
                column: "SongsSongId",
                principalTable: "Songs",
                principalColumn: "SongId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Genres_GenreId",
                table: "Songs",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
