using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class MyMigrationName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MediaType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MostRatedMoviesReports",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfRatings = table.Column<int>(type: "int", nullable: false),
                    MovieRating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MoviesWithMostScreeningsReports",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfScreenings = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "MoviesWithMostSoldTicketsReports",
                columns: table => new
                {
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ScreeningName = table.Column<int>(type: "int", nullable: false),
                    SoldTickets = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Hash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Admin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorMedia",
                columns: table => new
                {
                    ActorsId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMedia", x => new { x.ActorsId, x.MediaId });
                    table.ForeignKey(
                        name: "FK_ActorMedia_Actors_ActorsId",
                        column: x => x.ActorsId,
                        principalTable: "Actors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMedia_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating_value = table.Column<float>(type: "real", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Screenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number_of_seats = table.Column<int>(type: "int", nullable: false),
                    Number_of_tickets = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Screenings_Medias_MediaId",
                        column: x => x.MediaId,
                        principalTable: "Medias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchasedTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ScreeningId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchasedTickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchasedTickets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<float>(type: "real", nullable: false),
                    ScreeningId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Screenings_ScreeningId",
                        column: x => x.ScreeningId,
                        principalTable: "Screenings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, "Chris", "Hemsworth" },
                    { 34, "Scottie Fleming", "Portman" },
                    { 35, "Mara Baldwin", "Portman" },
                    { 36, "Kristina Hardy", "Portman" },
                    { 37, "Chris Brandt", "Portman" },
                    { 38, "Alva Compton", "Portman" },
                    { 39, "Victoria Alston", "Portman" },
                    { 40, "Victoria Alston", "Portman" },
                    { 41, "Victoria Alston", "Portman" },
                    { 42, "Victoria Alston", "Portman" },
                    { 43, "Victoria Alston", "Portman" },
                    { 44, "Victoria Alston", "Portman" },
                    { 45, "Victoria Alston", "Portman" },
                    { 46, "Victoria Alston", "Portman" },
                    { 47, "Victoria Alston", "Portman" },
                    { 48, "Victoria Alston", "Portman" },
                    { 49, "Victoria Alston", "Portman" },
                    { 50, "Victoria Alston", "Portman" },
                    { 51, "Victoria Alston", "Portman" },
                    { 52, "Victoria", "Alston" },
                    { 53, "Victoria", "Alston" },
                    { 54, "Victoria", "Alston" },
                    { 56, "Victoria", "Alston" },
                    { 57, "Victoria", "Alston" },
                    { 58, "Victoria", "Alston" },
                    { 59, "Victoria", "Alston" },
                    { 60, "Victoria", "Alston" },
                    { 61, "Victoria", "Alston" },
                    { 33, "Melissa Schwartz", "Portman" },
                    { 32, "Carlos Ross", "Portman" },
                    { 55, "Victoria", "Alston" },
                    { 30, "Walter Blankenship", "Portman" },
                    { 31, "Dwayne Wun", "Portman" },
                    { 2, "Natalie", "Portman" },
                    { 3, "Tom Hiddleston", "Portman" },
                    { 4, "Brianna Howe", "Portman" },
                    { 6, "James Hines", "Portman" },
                    { 7, "Leon Jarvis", "Portman" },
                    { 8, "Vinson Moran", "Portman" },
                    { 9, "Simpson Evans", "Portman" },
                    { 10, "Henry Molina", "Portman" },
                    { 11, "Mccullough Curry", "Portman" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[,]
                {
                    { 12, "Angelia Ruiz", "Portman" },
                    { 13, "Hinton Love", "Portman" },
                    { 14, "Adrienne Logan", "Portman" },
                    { 15, "Broderick Moore", "Portman" },
                    { 5, "Carver Wong", "Portman" },
                    { 17, "Alisha Bentley", "Portman" },
                    { 16, "Saundra West", "Portman" },
                    { 28, "Bradly Obrien", "Portman" },
                    { 27, "Odell Best", "Portman" },
                    { 25, "Alec Davila", "Portman" },
                    { 24, "Rey Romero", "Portman" },
                    { 26, "Nellie Barr", "Portman" },
                    { 29, "Demarcus Boyle", "Portman" },
                    { 22, "Normand Hughes", "Portman" },
                    { 21, "Miriam Cummings", "Portman" },
                    { 20, "Deshawn Arias", "Portman" },
                    { 19, "Larry Garcia", "Portman" },
                    { 23, "Modesto Clements", "Portman" },
                    { 18, "Hiram Strickland", "Portman" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "ImgUrl", "MediaType", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 65, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Kate" },
                    { 66, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Grown ups 2" },
                    { 67, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Grown ups" },
                    { 70, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Playing with fire" },
                    { 69, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "The Internship" },
                    { 71, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Monte Carlo" },
                    { 64, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Work it" },
                    { 72, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "She is all that" },
                    { 68, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Blended" },
                    { 73, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "47 ronin" },
                    { 58, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "John Wick" },
                    { 62, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Red 2" },
                    { 61, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Just friends" },
                    { 60, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Rudy" },
                    { 59, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "The perfect date" },
                    { 57, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "John Wick 2" },
                    { 56, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "John Wick 3" },
                    { 55, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Hangover part 1" },
                    { 54, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Hangover part 2" },
                    { 74, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Enola Holmes" },
                    { 53, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Hangover part 3" },
                    { 63, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Pitch perfect" },
                    { 75, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Noah" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "ImgUrl", "MediaType", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 90, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Warrior nun" },
                    { 77, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Midway" },
                    { 52, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Swiped" },
                    { 99, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Shadow hunters" },
                    { 98, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Shadow and Bone" },
                    { 97, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Good witch" },
                    { 96, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Superman and Louise" },
                    { 95, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Zero chill" },
                    { 94, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "How I met your mother" },
                    { 93, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Van Helsing" },
                    { 92, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Walking Dead" },
                    { 91, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Merlin" },
                    { 76, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "In time" },
                    { 89, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Constantine" },
                    { 87, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Star trek" },
                    { 86, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Kong : skull island" },
                    { 85, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Good boys" },
                    { 84, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Sweet girl" },
                    { 83, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Baywatch" },
                    { 82, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Be somebody" },
                    { 81, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Tomb Raidler" },
                    { 80, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Warcraft" },
                    { 79, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Holidate" },
                    { 78, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "The Mask" },
                    { 88, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Journey 2" },
                    { 51, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Creed" },
                    { 20, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Invisible city" },
                    { 49, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Creed 3" },
                    { 22, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Fate" },
                    { 21, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Locke is key" },
                    { 100, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Dare me" },
                    { 19, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Teen wolf" },
                    { 18, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Marlon" },
                    { 17, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Lucifer" },
                    { 16, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Vampire diaries" },
                    { 15, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "ELite" },
                    { 14, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Flash" },
                    { 13, "A sixth-generation homesteader and devoted father, John Dutton controls the largest contiguous ranch in the United States. He operates in a corrupt world where politicians are compromised by influential oil and lumber corporations and land grabs make developers billions.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN6RB1/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", 1, "2018-06-20", "Yellowstone" },
                    { 23, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Crew" },
                    { 12, "Michael Burnham and her companions in the USS Discovery travel into the far reaches of space to meet new lifeforms and discover new planets.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN8KT4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", 1, "2017-09-24", "Star Trek: Discovery" },
                    { 10, "After having been missing for nearly 20 years, Rick Sanchez suddenly arrives at daughter Beth's doorstep to move in with her and her family.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN85RB/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", 1, "2013-09-17", "Rick and Morty" },
                    { 9, "Bilbo fights against a number of enemies to save the life of his Dwarf friends and protects the Lonely Mountain after a conflict arises.", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZTH3PF/image?locale=en-nz&purposes=BoxArt&mode=scale&q=90&w=162", 0, "2014-12-11", "The Hobbit: The Battle of the Five Armies" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "ImgUrl", "MediaType", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 8, "Bilbo Baggins, a hobbit, and his companions face great dangers on their journey to Laketown. Soon, they reach the Lonely Mountain, where Bilbo comes face-to-face with the fearsome dragon Smaug.", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZJ5NLV/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-12-12", "The Hobbit: The Desolation of Smaug" },
                    { 7, "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "The Hobbit: An Unexpected Journey" },
                    { 6, "The former Fellowship members prepare for the final battle. While Frodo and Sam approach Mount Doom to destroy the One Ring, they follow Gollum, unaware of the path he is leading them to", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162", 0, "2013-09-17", "Lord Of The Rings: The Return Of The King" },
                    { 5, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Brooklyn Nine-Nine" },
                    { 4, "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2012-12-13", "The Hobbit: An Unexpected Journey" },
                    { 3, "Frodo and Sam arrive in Mordor with the help of Gollum. A number of new allies join their former companions to defend Isengard as Saruman launches an assault from his domain", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162", 0, "2002-12-18", "Lord Of The Rings: The Two Towers" },
                    { 2, "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZXZDZ3/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&", 0, "1977-05-17", "Star Wars: A New Hope" },
                    { 1, "Luke Skywalker attempts to bring his father back to the light side of the Force. At the same time, the rebels hatch a plan to destroy the second Death Star.", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZZCMJ4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "1983-05-25", "Star Wars: Return of the Jedi" },
                    { 11, "In the wake of a zombie apocalypse, various survivors struggle to stay alive. As they search for safety and evade the undead, they are forced to grapple with rival groups and difficult choices.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN90WK/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", 1, "2010-10-31", "The Walking Dead" },
                    { 50, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Creed 2" },
                    { 24, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Riverdale" },
                    { 26, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Family guy" },
                    { 48, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Takers" },
                    { 47, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Crash pad" },
                    { 46, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Shaft" },
                    { 45, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Zoung adult" },
                    { 44, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Transporter 1" },
                    { 43, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Transporter 2" },
                    { 42, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Transporter 3" },
                    { 41, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Wonder" },
                    { 40, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "POMS" },
                    { 39, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Defiance" },
                    { 25, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Ranch" },
                    { 38, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Gladiator" },
                    { 36, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Robin Hood" },
                    { 35, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Endless love" },
                    { 34, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "The half of it" },
                    { 33, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Before I fall" },
                    { 32, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Just like heaven" },
                    { 31, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Ranch" },
                    { 30, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Money heist" },
                    { 29, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Witcher" },
                    { 28, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Good Girls" },
                    { 27, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Cobra kai" },
                    { 37, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Aladdin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Admin", "Hash", "Salt", "Username" },
                values: new object[] { 1, true, new byte[] { 13, 237, 167, 170, 17, 44, 111, 123, 20, 131, 136, 9, 69, 176, 74, 70, 206, 197, 95, 21, 86, 92, 97, 69, 150, 27, 6, 68, 177, 185, 185, 240, 170, 159, 39, 191, 242, 125, 118, 108, 172, 182, 158, 152, 239, 87, 244, 249, 77, 219, 109, 31, 235, 16, 82, 177, 2, 32, 100, 242, 136, 50, 96, 191 }, new byte[] { 200, 14, 126, 97, 5, 229, 38, 153, 194, 48, 48, 235, 165, 37, 3, 43, 192, 196, 54, 72, 88, 170, 159, 69, 132, 150, 85, 199, 117, 129, 107, 49, 228, 13, 173, 116, 148, 143, 111, 22, 31, 226, 114, 64, 87, 119, 3, 1, 190, 131, 56, 62, 234, 144, 211, 75, 133, 219, 10, 131, 198, 78, 135, 161, 18, 28, 168, 203, 53, 16, 121, 200, 82, 10, 243, 189, 71, 92, 89, 207, 41, 128, 92, 231, 2, 246, 60, 207, 146, 95, 120, 73, 103, 224, 98, 198, 239, 12, 185, 20, 102, 193, 197, 234, 199, 113, 188, 254, 115, 43, 53, 39, 117, 35, 83, 244, 82, 96, 136, 117, 251, 32, 111, 223, 44, 180, 35, 239 }, "Admin" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "MediaId", "Rating_value" },
                values: new object[,]
                {
                    { 1, 1, 4.6f },
                    { 4, 4, 4.5f },
                    { 5, 5, 4.6f },
                    { 6, 6, 4.5f },
                    { 7, 7, 4.5f },
                    { 8, 8, 4.5f },
                    { 9, 9, 4.6f },
                    { 10, 10, 4.5f },
                    { 11, 11, 4.5f },
                    { 12, 12, 4.5f },
                    { 3, 3, 4.5f },
                    { 13, 13, 4.6f },
                    { 15, 15, 4.5f },
                    { 16, 16, 4.5f },
                    { 17, 17, 4.6f },
                    { 19, 19, 4.5f },
                    { 20, 20, 4.5f },
                    { 21, 21, 4.6f },
                    { 22, 22, 4.5f },
                    { 23, 23, 4.5f },
                    { 24, 24, 4.5f },
                    { 14, 14, 4.5f },
                    { 2, 2, 4.5f },
                    { 18, 18, 4.5f }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Date", "MediaId", "Number_of_seats", "Number_of_tickets", "Place", "Time" },
                values: new object[,]
                {
                    { 23, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4136), 1, 100, 100, "Sarajevo", "11:00" },
                    { 38, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4176), 81, 100, 100, "Sarajevo", "11:00" },
                    { 39, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4178), 81, 100, 100, "Sarajevo", "11:00" },
                    { 40, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4181), 82, 100, 100, "Sarajevo", "11:00" },
                    { 41, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4183), 82, 100, 100, "Sarajevo", "11:00" },
                    { 42, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4186), 82, 100, 100, "Sarajevo", "11:00" },
                    { 43, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4188), 82, 100, 100, "Sarajevo", "11:00" },
                    { 44, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4191), 82, 100, 100, "Sarajevo", "11:00" },
                    { 45, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4193), 83, 100, 100, "Sarajevo", "11:00" },
                    { 46, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4196), 83, 100, 100, "Sarajevo", "11:00" },
                    { 47, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4198), 83, 100, 100, "Sarajevo", "11:00" },
                    { 48, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4201), 83, 100, 100, "Sarajevo", "11:00" },
                    { 49, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4203), 83, 100, 100, "Sarajevo", "11:00" },
                    { 50, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4207), 84, 100, 100, "Sarajevo", "11:00" },
                    { 51, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4209), 84, 100, 100, "Sarajevo", "11:00" },
                    { 37, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4173), 81, 100, 100, "Sarajevo", "11:00" },
                    { 52, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4212), 84, 100, 100, "Sarajevo", "11:00" },
                    { 54, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4217), 84, 100, 100, "Sarajevo", "11:00" }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Date", "MediaId", "Number_of_seats", "Number_of_tickets", "Place", "Time" },
                values: new object[,]
                {
                    { 55, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4219), 85, 100, 100, "Sarajevo", "11:00" },
                    { 56, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4222), 85, 100, 100, "Sarajevo", "11:00" },
                    { 57, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4224), 85, 100, 100, "Sarajevo", "11:00" },
                    { 58, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4227), 85, 100, 100, "Sarajevo", "11:00" },
                    { 59, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4229), 85, 100, 100, "Sarajevo", "11:00" },
                    { 60, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4232), 86, 100, 100, "Sarajevo", "11:00" },
                    { 61, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4234), 86, 100, 100, "Sarajevo", "11:00" },
                    { 62, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4237), 86, 100, 100, "Sarajevo", "11:00" },
                    { 63, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4239), 86, 100, 100, "Sarajevo", "11:00" },
                    { 64, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4242), 86, 100, 100, "Sarajevo", "11:00" },
                    { 65, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4244), 87, 100, 100, "Sarajevo", "11:00" },
                    { 66, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4247), 87, 100, 100, "Sarajevo", "11:00" },
                    { 67, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4250), 87, 100, 100, "Sarajevo", "11:00" },
                    { 53, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4214), 84, 100, 100, "Sarajevo", "11:00" },
                    { 36, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4171), 81, 100, 100, "Sarajevo", "11:00" },
                    { 35, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4168), 81, 100, 100, "Sarajevo", "11:00" },
                    { 34, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4164), 80, 100, 100, "Sarajevo", "11:00" },
                    { 25, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4141), 2, 100, 100, "Sarajevo", "11:00" },
                    { 26, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4144), 2, 100, 100, "Sarajevo", "11:00" },
                    { 27, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4146), 2, 100, 100, "Sarajevo", "11:00" },
                    { 28, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4149), 2, 100, 100, "Sarajevo", "11:00" },
                    { 29, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4151), 2, 100, 100, "Sarajevo", "11:00" },
                    { 22, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4134), 1, 100, 100, "Sarajevo", "11:00" },
                    { 21, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4131), 1, 100, 100, "Sarajevo", "11:00" },
                    { 20, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4128), 1, 100, 100, "Sarajevo", "11:00" },
                    { 19, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4078), 1, 100, 100, "Sarajevo", "12:00" },
                    { 18, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4074), 1, 100, 100, "Sarajevo", "13:00" },
                    { 17, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4071), 1, 100, 100, "Sarajevo", "14:00" },
                    { 16, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4069), 1, 100, 100, "Sarajevo", "15:00" },
                    { 15, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4066), 1, 100, 100, "Sarajevo", "16:00" },
                    { 14, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4063), 1, 100, 100, "Sarajevo", "17:00" },
                    { 13, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4061), 1, 100, 100, "Sarajevo", "18:00" },
                    { 12, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4058), 1, 100, 100, "Sarajevo", "19:00" },
                    { 11, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4055), 1, 100, 100, "Sarajevo", "20:00" },
                    { 33, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4162), 80, 100, 100, "Sarajevo", "11:00" },
                    { 32, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4159), 80, 100, 100, "Sarajevo", "11:00" },
                    { 31, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4156), 80, 100, 100, "Sarajevo", "11:00" },
                    { 30, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4154), 80, 100, 100, "Sarajevo", "11:00" },
                    { 1, new DateTime(2022, 1, 22, 20, 53, 28, 805, DateTimeKind.Local).AddTicks(5974), 1, 100, 100, "Sarajevo", "10:00" },
                    { 2, new DateTime(2021, 10, 20, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4007), 1, 100, 100, "Sarajevo", "11:00" },
                    { 24, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4139), 1, 100, 100, "Sarajevo", "11:00" },
                    { 3, new DateTime(2021, 10, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4032), 1, 100, 100, "Sarajevo", "08:00" }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Date", "MediaId", "Number_of_seats", "Number_of_tickets", "Place", "Time" },
                values: new object[,]
                {
                    { 5, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4039), 1, 100, 100, "Sarajevo", "10:00" },
                    { 6, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4044), 1, 100, 100, "Sarajevo", "00:00" },
                    { 68, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4253), 87, 100, 100, "Sarajevo", "11:00" },
                    { 7, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4047), 1, 100, 100, "Sarajevo", "23:00" },
                    { 8, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4049), 1, 100, 100, "Sarajevo", "22:00" },
                    { 9, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4052), 1, 100, 100, "Sarajevo", "21:00" },
                    { 4, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4036), 1, 100, 100, "Sarajevo", "09:00" },
                    { 69, new DateTime(2022, 1, 18, 15, 13, 28, 807, DateTimeKind.Local).AddTicks(4255), 87, 100, 100, "Sarajevo", "11:00" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "Price", "ScreeningId" },
                values: new object[,]
                {
                    { 1, 5.5f, 1 },
                    { 2, 5.5f, 25 },
                    { 3, 5.5f, 30 },
                    { 4, 5.5f, 35 },
                    { 5, 5.5f, 40 },
                    { 6, 5.5f, 45 },
                    { 7, 5.5f, 50 },
                    { 8, 5.5f, 55 },
                    { 9, 5.5f, 60 },
                    { 10, 5.5f, 65 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMedia_MediaId",
                table: "ActorMedia",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchasedTickets_UserId",
                table: "PurchasedTickets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_MediaId",
                table: "Ratings",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Screenings_MediaId",
                table: "Screenings",
                column: "MediaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ScreeningId",
                table: "Tickets",
                column: "ScreeningId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMedia");

            migrationBuilder.DropTable(
                name: "MostRatedMoviesReports");

            migrationBuilder.DropTable(
                name: "MoviesWithMostScreeningsReports");

            migrationBuilder.DropTable(
                name: "MoviesWithMostSoldTicketsReports");

            migrationBuilder.DropTable(
                name: "PurchasedTickets");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Screenings");

            migrationBuilder.DropTable(
                name: "Medias");
        }
    }
}
