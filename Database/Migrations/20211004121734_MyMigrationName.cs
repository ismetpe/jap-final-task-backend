﻿using System;
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
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    { 55, "Victoria", "Alston" },
                    { 57, "Victoria", "Alston" },
                    { 58, "Victoria", "Alston" },
                    { 59, "Victoria", "Alston" },
                    { 60, "Victoria", "Alston" },
                    { 61, "Victoria", "Alston" },
                    { 33, "Melissa Schwartz", "Portman" },
                    { 32, "Carlos Ross", "Portman" },
                    { 56, "Victoria", "Alston" },
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
                    { 29, "Demarcus Boyle", "Portman" },
                    { 26, "Nellie Barr", "Portman" },
                    { 25, "Alec Davila", "Portman" },
                    { 24, "Rey Romero", "Portman" },
                    { 27, "Odell Best", "Portman" },
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
                    { 74, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Enola Holmes" },
                    { 65, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Kate" },
                    { 66, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Grown ups 2" },
                    { 67, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Grown ups" },
                    { 68, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Blended" },
                    { 70, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Playing with fire" },
                    { 71, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Monte Carlo" },
                    { 72, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "She is all that" },
                    { 73, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "47 ronin" },
                    { 69, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "The Internship" },
                    { 64, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Work it" },
                    { 58, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "John Wick" },
                    { 62, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Red 2" },
                    { 61, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Just friends" },
                    { 60, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Rudy" },
                    { 59, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "The perfect date" },
                    { 57, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "John Wick 2" },
                    { 56, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "John Wick 3" },
                    { 55, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Hangover part 1" },
                    { 54, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Hangover part 2" },
                    { 75, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Noah" },
                    { 53, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Hangover part 3" },
                    { 63, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Pitch perfect" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "Description", "ImgUrl", "MediaType", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 76, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "In time" },
                    { 91, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Merlin" },
                    { 78, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "The Mask" },
                    { 52, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Swiped" },
                    { 100, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Dare me" },
                    { 99, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Shadow hunters" },
                    { 98, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Shadow and Bone" },
                    { 97, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Good witch" },
                    { 96, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Superman and Louise" },
                    { 95, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Zero chill" },
                    { 94, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "How I met your mother" },
                    { 93, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Van Helsing" },
                    { 92, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Walking Dead" },
                    { 77, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Midway" },
                    { 90, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Warrior nun" },
                    { 88, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Journey 2" },
                    { 87, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Star trek" },
                    { 86, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Kong : skull island" },
                    { 85, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Good boys" },
                    { 84, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Sweet girl" },
                    { 83, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Baywatch" },
                    { 82, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Be somebody" },
                    { 81, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Tomb Raidler" },
                    { 80, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Warcraft" },
                    { 79, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Holidate" },
                    { 89, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Constantine" },
                    { 51, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Creed" },
                    { 22, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Fate" },
                    { 49, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Creed 3" },
                    { 21, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Locke is key" },
                    { 20, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Invisible city" },
                    { 19, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Teen wolf" },
                    { 18, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Marlon" },
                    { 17, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Lucifer" },
                    { 16, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Vampire diaries" },
                    { 15, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "ELite" },
                    { 14, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Flash" },
                    { 13, "A sixth-generation homesteader and devoted father, John Dutton controls the largest contiguous ranch in the United States. He operates in a corrupt world where politicians are compromised by influential oil and lumber corporations and land grabs make developers billions.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN6RB1/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", 1, "2018-06-20", "Yellowstone" },
                    { 12, "Michael Burnham and her companions in the USS Discovery travel into the far reaches of space to meet new lifeforms and discover new planets.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN8KT4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", 1, "2017-09-24", "Star Trek: Discovery" },
                    { 11, "In the wake of a zombie apocalypse, various survivors struggle to stay alive. As they search for safety and evade the undead, they are forced to grapple with rival groups and difficult choices.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN90WK/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", 1, "2010-10-31", "The Walking Dead" },
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
                    { 50, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Creed 2" },
                    { 24, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Riverdale" },
                    { 23, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Crew" },
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
                    { 25, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Ranch" },
                    { 38, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Gladiator" },
                    { 39, "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Defiance" },
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
                columns: new[] { "Id", "Password", "Username" },
                values: new object[,]
                {
                    { 4, "123456", "user4" },
                    { 1, "123456", "user1" },
                    { 2, "123456", "user2" },
                    { 3, "123456", "user3" },
                    { 5, "123456", "user5" }
                });

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
                    { 23, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9005), 1, 100, 100, "Sarajevo", "11:00" },
                    { 38, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9050), 81, 100, 100, "Sarajevo", "11:00" },
                    { 39, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9053), 81, 100, 100, "Sarajevo", "11:00" },
                    { 40, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9056), 82, 100, 100, "Sarajevo", "11:00" },
                    { 41, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9059), 82, 100, 100, "Sarajevo", "11:00" },
                    { 42, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9061), 82, 100, 100, "Sarajevo", "11:00" },
                    { 43, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9064), 82, 100, 100, "Sarajevo", "11:00" },
                    { 44, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9067), 82, 100, 100, "Sarajevo", "11:00" },
                    { 45, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9070), 83, 100, 100, "Sarajevo", "11:00" },
                    { 46, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9073), 83, 100, 100, "Sarajevo", "11:00" },
                    { 47, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9076), 83, 100, 100, "Sarajevo", "11:00" },
                    { 48, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9079), 83, 100, 100, "Sarajevo", "11:00" },
                    { 49, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9082), 83, 100, 100, "Sarajevo", "11:00" },
                    { 50, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9084), 84, 100, 100, "Sarajevo", "11:00" },
                    { 51, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9087), 84, 100, 100, "Sarajevo", "11:00" },
                    { 37, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9047), 81, 100, 100, "Sarajevo", "11:00" },
                    { 52, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9089), 84, 100, 100, "Sarajevo", "11:00" },
                    { 54, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9095), 84, 100, 100, "Sarajevo", "11:00" }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Date", "MediaId", "Number_of_seats", "Number_of_tickets", "Place", "Time" },
                values: new object[,]
                {
                    { 55, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9098), 85, 100, 100, "Sarajevo", "11:00" },
                    { 56, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9137), 85, 100, 100, "Sarajevo", "11:00" },
                    { 57, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9140), 85, 100, 100, "Sarajevo", "11:00" },
                    { 58, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9143), 85, 100, 100, "Sarajevo", "11:00" },
                    { 59, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9146), 85, 100, 100, "Sarajevo", "11:00" },
                    { 60, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9148), 86, 100, 100, "Sarajevo", "11:00" },
                    { 61, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9151), 86, 100, 100, "Sarajevo", "11:00" },
                    { 62, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9154), 86, 100, 100, "Sarajevo", "11:00" },
                    { 63, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9156), 86, 100, 100, "Sarajevo", "11:00" },
                    { 64, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9159), 86, 100, 100, "Sarajevo", "11:00" },
                    { 65, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9162), 87, 100, 100, "Sarajevo", "11:00" },
                    { 66, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9165), 87, 100, 100, "Sarajevo", "11:00" },
                    { 67, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9169), 87, 100, 100, "Sarajevo", "11:00" },
                    { 53, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9092), 84, 100, 100, "Sarajevo", "11:00" },
                    { 36, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9044), 81, 100, 100, "Sarajevo", "11:00" },
                    { 35, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9042), 81, 100, 100, "Sarajevo", "11:00" },
                    { 34, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9038), 80, 100, 100, "Sarajevo", "11:00" },
                    { 25, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9010), 2, 100, 100, "Sarajevo", "11:00" },
                    { 26, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9013), 2, 100, 100, "Sarajevo", "11:00" },
                    { 27, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9015), 2, 100, 100, "Sarajevo", "11:00" },
                    { 28, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9018), 2, 100, 100, "Sarajevo", "11:00" },
                    { 29, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9021), 2, 100, 100, "Sarajevo", "11:00" },
                    { 22, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9002), 1, 100, 100, "Sarajevo", "11:00" },
                    { 21, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8998), 1, 100, 100, "Sarajevo", "11:00" },
                    { 20, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8995), 1, 100, 100, "Sarajevo", "11:00" },
                    { 19, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8993), 1, 100, 100, "Sarajevo", "12:00" },
                    { 18, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8989), 1, 100, 100, "Sarajevo", "13:00" },
                    { 17, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8986), 1, 100, 100, "Sarajevo", "14:00" },
                    { 16, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8983), 1, 100, 100, "Sarajevo", "15:00" },
                    { 15, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8980), 1, 100, 100, "Sarajevo", "16:00" },
                    { 14, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8977), 1, 100, 100, "Sarajevo", "17:00" },
                    { 13, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8974), 1, 100, 100, "Sarajevo", "18:00" },
                    { 12, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8971), 1, 100, 100, "Sarajevo", "19:00" },
                    { 11, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8968), 1, 100, 100, "Sarajevo", "20:00" },
                    { 33, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9035), 80, 100, 100, "Sarajevo", "11:00" },
                    { 32, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9032), 80, 100, 100, "Sarajevo", "11:00" },
                    { 31, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9030), 80, 100, 100, "Sarajevo", "11:00" },
                    { 30, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9027), 80, 100, 100, "Sarajevo", "11:00" },
                    { 1, new DateTime(2022, 1, 16, 19, 57, 33, 746, DateTimeKind.Local).AddTicks(8635), 1, 100, 100, "Sarajevo", "10:00" },
                    { 2, new DateTime(2021, 10, 14, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8907), 1, 100, 100, "Sarajevo", "11:00" },
                    { 24, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9007), 1, 100, 100, "Sarajevo", "11:00" },
                    { 3, new DateTime(2021, 10, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8940), 1, 100, 100, "Sarajevo", "08:00" }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "Date", "MediaId", "Number_of_seats", "Number_of_tickets", "Place", "Time" },
                values: new object[,]
                {
                    { 5, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8948), 1, 100, 100, "Sarajevo", "10:00" },
                    { 6, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8956), 1, 100, 100, "Sarajevo", "00:00" },
                    { 68, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9171), 87, 100, 100, "Sarajevo", "11:00" },
                    { 7, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8958), 1, 100, 100, "Sarajevo", "23:00" },
                    { 8, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8961), 1, 100, 100, "Sarajevo", "22:00" },
                    { 9, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8964), 1, 100, 100, "Sarajevo", "21:00" },
                    { 4, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(8945), 1, 100, 100, "Sarajevo", "09:00" },
                    { 69, new DateTime(2022, 1, 12, 14, 17, 33, 748, DateTimeKind.Local).AddTicks(9174), 87, 100, 100, "Sarajevo", "11:00" }
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
            string GetMoviesWithMostSoldTicketsWithoutRating = @" CREATE PROCEDURE GetMoviesWithMostSoldTicketsWithoutRating
                                                             AS
                                                             BEGIN
                                                             SET NOCOUNT ON

                                                             SELECT  m.Id, m.Title, s.Id AS Screening,COUNT(t.Id) AS Sold_tickets
                                                             FROM Medias m
                                                             JOIN Screenings s ON s.MediaId = m.Id
                                                             JOIN Tickets t ON t.ScreeningId = s.Id
                                                             WHERE (    SELECT COUNT(*) 
                                                                        FROM Ratings r 
                                                                        WHERE r.MediaId = m.Id ) = 0
                                                             AND MediaType = 0
                                                             GROUP BY m.Id,m.Title,s.Id
                                                             ORDER BY Count(t.Id) DESC;

                                                             END";

            string GetTopTenMoviesWithMostRating = @"CREATE PROCEDURE GetTopTenMoviesWithMostRating
                                             AS
                                             BEGIN
                                             SET NOCOUNT ON

                                             SELECT TOP 10  m.Id, m.Title, Count(r.MediaId) as NumberOfRatings, avg(r.rating_value) AS Movie_rating 
                                             FROM Medias m 
                                             JOIN Ratings r On r.MediaId = m.Id
                                             WHERE MediaType = 0 
                                             GROUP BY m.Id, Title
                                             ORDER BY avg(r.rating_value) DESC;

                                             END";




            string GetTopTenMoviesWithMostScreening = @"CREATE PROCEDURE GetTopTenMoviesWithMostScreening
                                             @start_date DateTime,@end_date DateTime
                                             AS
                                             BEGIN
                                             SET NOCOUNT ON

                                             SELECT TOP 10  m.Id, m.Title, Count(s.Id) as NumberOfScreenings
                                             FROM Medias m 
                                             JOIN Screenings s On s.MediaId = m.Id
                                             WHERE s.Date BETWEEN @start_date AND @end_date AND MediaType = 0
                                             GROUP BY m.Id, Title
                                             ORDER BY Count(s.Id) DESC;

                                              END";
            migrationBuilder.Sql(GetMoviesWithMostSoldTicketsWithoutRating);
            migrationBuilder.Sql(GetTopTenMoviesWithMostRating);
            migrationBuilder.Sql(GetTopTenMoviesWithMostScreening);
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
            migrationBuilder.DropTable(
name: "MostRatedMoviesReports");

            migrationBuilder.DropTable(
                name: "MoviesWithMostScreeningsReports");

            migrationBuilder.DropTable(
                name: "MoviesWithMostSoldTicketsReports"); 
        }
    }
}
