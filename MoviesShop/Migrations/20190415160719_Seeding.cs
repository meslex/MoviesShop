using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesShop.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movies",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movies",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Title" },
                values: new object[] { 1, "Comedy is a genre of film in which the main emphasis is on humour. These films are designed to make the audience laugh through amusement and most often work by exaggerating characteristics for humorous effect.", "Comedy" });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Description", "Title" },
                values: new object[] { 2, "In film and television, drama is a genre of narrative fiction (or semi-fiction) intended to be more serious than humorous in tone. Drama of this kind is usually qualified with additional terms that specify its particular subgenre, such as police crime drama, political drama, legal drama, historical period drama, domestic drama, or comedy - drama.", "Drama" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Country", "Director", "GenreId", "Price", "ProductionCompany", "ReleaseDate", "Title" },
                values: new object[] { 1, "USA", "Michael Lehman", 1, 13m, "New World Pictures", new DateTime(1989, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heathers" });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Country", "Director", "GenreId", "Price", "ProductionCompany", "ReleaseDate", "Title" },
                values: new object[] { 2, "USA", "Sam Mendes", 2, 35m, "DreamWorks", new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "American Beauty" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "GenreId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movies");

            migrationBuilder.AlterColumn<int>(
                name: "Title",
                table: "Movies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
