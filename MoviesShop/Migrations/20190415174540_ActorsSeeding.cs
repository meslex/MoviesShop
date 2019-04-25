using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MoviesShop.Migrations
{
    public partial class ActorsSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Movies",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "Birthday", "Country", "Firstname", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(1971, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Winona", "Ryder" },
                    { 2, new DateTime(1969, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Christian", "Slater" },
                    { 3, new DateTime(1959, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Kevin", "Spacey" },
                    { 4, new DateTime(1958, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "USA", "Annette", "Bening" }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "Description",
                value: "In order to get out of the snobby clique that is destroying her good-girl reputation, an intelligent teen teams up with a dark sociopath in a plot to kill the cool kids.");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "Description",
                value: "A sexually frustrated suburban father has a mid-life crisis after becoming infatuated with his daughter's best friend.");

            migrationBuilder.InsertData(
                table: "MainActors",
                columns: new[] { "ActorId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MainActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MainActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MainActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "MainActors",
                keyColumns: new[] { "ActorId", "MovieId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Movies");
        }
    }
}
