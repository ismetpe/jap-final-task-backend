using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class InitialCreate : Migration
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
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    MediaType = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    Admin = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    MediaId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    MediaId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    ScreeningId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArchivedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ArchivedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Firstname", "Surname" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5032), "SYSTEM", "Chris", "Hemsworth" },
                    { 34, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5963), "SYSTEM", "Scottie Fleming", "Portman" },
                    { 35, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5966), "SYSTEM", "Mara Baldwin", "Portman" },
                    { 36, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5969), "SYSTEM", "Kristina Hardy", "Portman" },
                    { 37, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5971), "SYSTEM", "Chris Brandt", "Portman" },
                    { 38, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5973), "SYSTEM", "Alva Compton", "Portman" },
                    { 39, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5976), "SYSTEM", "Victoria Alston", "Portman" },
                    { 40, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5978), "SYSTEM", "Victoria Alston", "Portman" },
                    { 41, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5980), "SYSTEM", "Victoria Alston", "Portman" },
                    { 42, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5983), "SYSTEM", "Victoria Alston", "Portman" },
                    { 43, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5985), "SYSTEM", "Victoria Alston", "Portman" },
                    { 44, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5987), "SYSTEM", "Victoria Alston", "Portman" },
                    { 45, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5990), "SYSTEM", "Victoria Alston", "Portman" },
                    { 46, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5992), "SYSTEM", "Victoria Alston", "Portman" },
                    { 47, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5994), "SYSTEM", "Victoria Alston", "Portman" },
                    { 48, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5997), "SYSTEM", "Victoria Alston", "Portman" },
                    { 49, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5999), "SYSTEM", "Victoria Alston", "Portman" },
                    { 50, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(6001), "SYSTEM", "Victoria Alston", "Portman" },
                    { 51, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(6004), "SYSTEM", "Victoria Alston", "Portman" },
                    { 52, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(6006), "SYSTEM", "Victoria", "Alston" },
                    { 53, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(6008), "SYSTEM", "Victoria", "Alston" },
                    { 54, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(6011), "SYSTEM", "Victoria", "Alston" },
                    { 56, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(6015), "SYSTEM", "Victoria", "Alston" },
                    { 57, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(6017), "SYSTEM", "Victoria", "Alston" },
                    { 58, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(6020), "SYSTEM", "Victoria", "Alston" },
                    { 59, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(6022), "SYSTEM", "Victoria", "Alston" },
                    { 60, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(6024), "SYSTEM", "Victoria", "Alston" },
                    { 61, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(6027), "SYSTEM", "Victoria", "Alston" },
                    { 33, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5932), "SYSTEM", "Melissa Schwartz", "Portman" },
                    { 32, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5929), "SYSTEM", "Carlos Ross", "Portman" },
                    { 55, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(6013), "SYSTEM", "Victoria", "Alston" },
                    { 30, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5925), "SYSTEM", "Walter Blankenship", "Portman" },
                    { 31, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5927), "SYSTEM", "Dwayne Wun", "Portman" },
                    { 2, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5846), "SYSTEM", "Natalie", "Portman" },
                    { 3, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5856), "SYSTEM", "Tom Hiddleston", "Portman" },
                    { 4, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5859), "SYSTEM", "Brianna Howe", "Portman" },
                    { 6, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5867), "SYSTEM", "James Hines", "Portman" },
                    { 7, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5869), "SYSTEM", "Leon Jarvis", "Portman" },
                    { 8, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5872), "SYSTEM", "Vinson Moran", "Portman" },
                    { 9, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5874), "SYSTEM", "Simpson Evans", "Portman" },
                    { 10, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5877), "SYSTEM", "Henry Molina", "Portman" },
                    { 11, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5880), "SYSTEM", "Mccullough Curry", "Portman" }
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Firstname", "Surname" },
                values: new object[,]
                {
                    { 12, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5882), "SYSTEM", "Angelia Ruiz", "Portman" },
                    { 13, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5885), "SYSTEM", "Hinton Love", "Portman" },
                    { 14, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5887), "SYSTEM", "Adrienne Logan", "Portman" },
                    { 15, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5889), "SYSTEM", "Broderick Moore", "Portman" },
                    { 5, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5862), "SYSTEM", "Carver Wong", "Portman" },
                    { 17, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5894), "SYSTEM", "Alisha Bentley", "Portman" },
                    { 16, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5891), "SYSTEM", "Saundra West", "Portman" },
                    { 28, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5920), "SYSTEM", "Bradly Obrien", "Portman" },
                    { 27, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5918), "SYSTEM", "Odell Best", "Portman" },
                    { 25, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5913), "SYSTEM", "Alec Davila", "Portman" },
                    { 24, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5911), "SYSTEM", "Rey Romero", "Portman" },
                    { 26, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5915), "SYSTEM", "Nellie Barr", "Portman" },
                    { 29, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5922), "SYSTEM", "Demarcus Boyle", "Portman" },
                    { 22, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5906), "SYSTEM", "Normand Hughes", "Portman" },
                    { 21, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5904), "SYSTEM", "Miriam Cummings", "Portman" },
                    { 20, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5902), "SYSTEM", "Deshawn Arias", "Portman" },
                    { 19, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5899), "SYSTEM", "Larry Garcia", "Portman" },
                    { 23, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5908), "SYSTEM", "Modesto Clements", "Portman" },
                    { 18, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 14, DateTimeKind.Local).AddTicks(5897), "SYSTEM", "Hiram Strickland", "Portman" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Description", "ImgUrl", "MediaType", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 65, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4019), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Kate" },
                    { 66, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4022), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Grown ups 2" },
                    { 67, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4025), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Grown ups" },
                    { 70, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4057), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Playing with fire" },
                    { 69, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4030), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "The Internship" },
                    { 71, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4060), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Monte Carlo" },
                    { 64, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4016), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Work it" },
                    { 72, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4063), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "She is all that" },
                    { 68, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4028), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Blended" },
                    { 73, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4066), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "47 ronin" },
                    { 58, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4000), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "John Wick" },
                    { 62, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4011), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Red 2" },
                    { 61, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4008), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Just friends" },
                    { 60, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4005), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Rudy" },
                    { 59, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4003), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "The perfect date" },
                    { 57, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3998), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "John Wick 2" },
                    { 56, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3995), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "John Wick 3" },
                    { 55, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3992), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Hangover part 1" },
                    { 54, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3990), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Hangover part 2" },
                    { 74, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4068), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Enola Holmes" },
                    { 53, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3987), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Hangover part 3" },
                    { 63, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4013), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Pitch perfect" },
                    { 75, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4071), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Noah" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Description", "ImgUrl", "MediaType", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 90, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4110), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Warrior nun" },
                    { 77, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4076), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Midway" },
                    { 52, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3984), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Swiped" },
                    { 99, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4134), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Shadow hunters" },
                    { 98, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4132), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Shadow and Bone" },
                    { 97, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4129), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Good witch" },
                    { 96, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4126), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Superman and Louise" },
                    { 95, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4124), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Zero chill" },
                    { 94, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4121), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "How I met your mother" },
                    { 93, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4118), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Van Helsing" },
                    { 92, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4116), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Walking Dead" },
                    { 91, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4113), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Merlin" },
                    { 76, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4073), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "In time" },
                    { 89, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4108), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Constantine" },
                    { 87, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4103), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Star trek" },
                    { 86, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4100), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Kong : skull island" },
                    { 85, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4097), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Good boys" },
                    { 84, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4094), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Sweet girl" },
                    { 83, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4092), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Baywatch" },
                    { 82, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4089), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Be somebody" },
                    { 81, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4087), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Tomb Raidler" },
                    { 80, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4084), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Warcraft" },
                    { 79, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4081), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Holidate" },
                    { 78, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4079), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "The Mask" },
                    { 88, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4105), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Journey 2" },
                    { 51, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3982), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Creed" },
                    { 20, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3870), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Invisible city" },
                    { 49, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3976), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Creed 3" },
                    { 22, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3875), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Fate" },
                    { 21, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3873), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Locke is key" },
                    { 100, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(4137), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Dare me" },
                    { 19, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3867), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Teen wolf" },
                    { 18, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3864), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Marlon" },
                    { 17, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3861), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Lucifer" },
                    { 16, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3858), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Vampire diaries" },
                    { 15, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3856), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "ELite" },
                    { 14, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3853), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Flash" },
                    { 13, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3850), "SYSTEM", "A sixth-generation homesteader and devoted father, John Dutton controls the largest contiguous ranch in the United States. He operates in a corrupt world where politicians are compromised by influential oil and lumber corporations and land grabs make developers billions.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN6RB1/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", 1, "2018-06-20", "Yellowstone" },
                    { 23, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3878), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Crew" },
                    { 12, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3848), "SYSTEM", "Michael Burnham and her companions in the USS Discovery travel into the far reaches of space to meet new lifeforms and discover new planets.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN8KT4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", 1, "2017-09-24", "Star Trek: Discovery" },
                    { 10, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3842), "SYSTEM", "After having been missing for nearly 20 years, Rick Sanchez suddenly arrives at daughter Beth's doorstep to move in with her and her family.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN85RB/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", 1, "2013-09-17", "Rick and Morty" },
                    { 9, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3839), "SYSTEM", "Bilbo fights against a number of enemies to save the life of his Dwarf friends and protects the Lonely Mountain after a conflict arises.", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZTH3PF/image?locale=en-nz&purposes=BoxArt&mode=scale&q=90&w=162", 0, "2014-12-11", "The Hobbit: The Battle of the Five Armies" }
                });

            migrationBuilder.InsertData(
                table: "Medias",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Description", "ImgUrl", "MediaType", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 8, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3836), "SYSTEM", "Bilbo Baggins, a hobbit, and his companions face great dangers on their journey to Laketown. Soon, they reach the Lonely Mountain, where Bilbo comes face-to-face with the fearsome dragon Smaug.", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZJ5NLV/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-12-12", "The Hobbit: The Desolation of Smaug" },
                    { 7, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3833), "SYSTEM", "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "The Hobbit: An Unexpected Journey" },
                    { 6, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3830), "SYSTEM", "The former Fellowship members prepare for the final battle. While Frodo and Sam approach Mount Doom to destroy the One Ring, they follow Gollum, unaware of the path he is leading them to", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162", 0, "2013-09-17", "Lord Of The Rings: The Return Of The King" },
                    { 5, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3823), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Brooklyn Nine-Nine" },
                    { 4, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3820), "SYSTEM", "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2012-12-13", "The Hobbit: An Unexpected Journey" },
                    { 3, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3757), "SYSTEM", "Frodo and Sam arrive in Mordor with the help of Gollum. A number of new allies join their former companions to defend Isengard as Saruman launches an assault from his domain", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162", 0, "2002-12-18", "Lord Of The Rings: The Two Towers" },
                    { 2, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3744), "SYSTEM", "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZXZDZ3/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&", 0, "1977-05-17", "Star Wars: A New Hope" },
                    { 1, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(2370), "SYSTEM", "Luke Skywalker attempts to bring his father back to the light side of the Force. At the same time, the rebels hatch a plan to destroy the second Death Star.", "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZZCMJ4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "1983-05-25", "Star Wars: Return of the Jedi" },
                    { 11, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3845), "SYSTEM", "In the wake of a zombie apocalypse, various survivors struggle to stay alive. As they search for safety and evade the undead, they are forced to grapple with rival groups and difficult choices.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN90WK/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=300&w=200&format=jpg", 1, "2010-10-31", "The Walking Dead" },
                    { 50, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3979), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Creed 2" },
                    { 24, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3881), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Riverdale" },
                    { 26, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3887), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Family guy" },
                    { 48, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3974), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Takers" },
                    { 47, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3971), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Crash pad" },
                    { 46, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3968), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Shaft" },
                    { 45, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3966), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Zoung adult" },
                    { 44, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3963), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Transporter 1" },
                    { 43, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3960), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Transporter 2" },
                    { 42, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3958), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Transporter 3" },
                    { 41, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3955), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Wonder" },
                    { 40, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3952), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "POMS" },
                    { 39, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3949), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Defiance" },
                    { 25, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3884), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Ranch" },
                    { 38, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3947), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Gladiator" },
                    { 36, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3914), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Robin Hood" },
                    { 35, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3911), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Endless love" },
                    { 34, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3909), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "The half of it" },
                    { 33, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3905), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Before I fall" },
                    { 32, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3903), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Just like heaven" },
                    { 31, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3900), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Ranch" },
                    { 30, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3898), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Money heist" },
                    { 29, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3895), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "The Witcher" },
                    { 28, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3892), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Good Girls" },
                    { 27, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3889), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 1, "2013-09-17", "Cobra kai" },
                    { 37, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 13, DateTimeKind.Local).AddTicks(3944), "SYSTEM", "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.", "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg", 0, "2013-09-17", "Aladdin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Admin", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Hash", "Salt", "Username" },
                values: new object[] { 1, true, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 8, DateTimeKind.Local).AddTicks(762), "SYSTEM", new byte[] { 137, 198, 180, 81, 86, 131, 211, 37, 51, 106, 248, 86, 133, 99, 101, 237, 54, 165, 57, 177, 97, 186, 142, 4, 14, 16, 187, 140, 16, 110, 97, 107, 77, 91, 228, 237, 42, 241, 75, 212, 59, 155, 99, 145, 197, 133, 132, 89, 81, 119, 128, 20, 56, 50, 94, 78, 143, 14, 207, 107, 173, 253, 148, 49 }, new byte[] { 105, 168, 189, 243, 50, 100, 175, 72, 23, 177, 77, 24, 36, 13, 136, 209, 57, 34, 36, 46, 139, 227, 10, 117, 211, 247, 19, 88, 128, 90, 56, 125, 43, 0, 125, 29, 71, 183, 65, 97, 52, 36, 199, 108, 218, 204, 229, 70, 16, 205, 244, 41, 164, 154, 172, 170, 65, 37, 219, 247, 65, 65, 126, 169, 20, 153, 172, 154, 139, 168, 148, 162, 66, 225, 212, 139, 218, 0, 243, 234, 205, 118, 55, 55, 182, 33, 132, 98, 255, 205, 159, 137, 222, 199, 166, 87, 6, 101, 67, 175, 231, 99, 239, 176, 135, 23, 144, 179, 193, 245, 26, 155, 73, 104, 44, 161, 58, 133, 51, 2, 138, 174, 46, 180, 170, 66, 250, 197 }, "Admin" });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "MediaId", "Rating_value" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(911), "SYSTEM", 1, 4.6f },
                    { 4, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1619), "SYSTEM", 4, 4.5f },
                    { 5, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1622), "SYSTEM", 5, 4.6f },
                    { 6, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1627), "SYSTEM", 6, 4.5f },
                    { 7, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1629), "SYSTEM", 7, 4.5f },
                    { 8, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1631), "SYSTEM", 8, 4.5f },
                    { 9, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1633), "SYSTEM", 9, 4.6f },
                    { 10, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1636), "SYSTEM", 10, 4.5f },
                    { 11, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1639), "SYSTEM", 11, 4.5f },
                    { 12, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1641), "SYSTEM", 12, 4.5f },
                    { 3, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1617), "SYSTEM", 3, 4.5f },
                    { 13, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1643), "SYSTEM", 13, 4.6f },
                    { 15, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1647), "SYSTEM", 15, 4.5f },
                    { 16, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1650), "SYSTEM", 16, 4.5f },
                    { 17, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1652), "SYSTEM", 17, 4.6f },
                    { 19, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1657), "SYSTEM", 19, 4.5f },
                    { 20, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1659), "SYSTEM", 20, 4.5f },
                    { 21, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1661), "SYSTEM", 21, 4.6f },
                    { 22, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1663), "SYSTEM", 22, 4.5f },
                    { 23, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1665), "SYSTEM", 23, 4.5f },
                    { 24, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1668), "SYSTEM", 24, 4.5f },
                    { 14, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1645), "SYSTEM", 14, 4.5f },
                    { 2, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1607), "SYSTEM", 2, 4.5f },
                    { 18, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 15, DateTimeKind.Local).AddTicks(1655), "SYSTEM", 18, 4.5f }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Date", "MediaId", "NumberOfSeats", "NumberOfTickets", "Place", "Time" },
                values: new object[,]
                {
                    { 23, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8460), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8462), 1, 100, 100, "Sarajevo", "11:00" },
                    { 38, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8527), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8529), 81, 100, 100, "Sarajevo", "11:00" },
                    { 39, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8532), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8534), 81, 100, 100, "Sarajevo", "11:00" },
                    { 40, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8536), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8538), 82, 100, 100, "Sarajevo", "11:00" },
                    { 41, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8540), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8542), 82, 100, 100, "Sarajevo", "11:00" },
                    { 42, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8545), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8547), 82, 100, 100, "Sarajevo", "11:00" },
                    { 43, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8549), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8551), 82, 100, 100, "Sarajevo", "11:00" },
                    { 44, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8553), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8555), 82, 100, 100, "Sarajevo", "11:00" },
                    { 45, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8558), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8560), 83, 100, 100, "Sarajevo", "11:00" },
                    { 46, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8597), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8600), 83, 100, 100, "Sarajevo", "11:00" },
                    { 47, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8603), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8605), 83, 100, 100, "Sarajevo", "11:00" },
                    { 48, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8607), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8609), 83, 100, 100, "Sarajevo", "11:00" },
                    { 49, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8611), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8613), 83, 100, 100, "Sarajevo", "11:00" },
                    { 50, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8616), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8618), 84, 100, 100, "Sarajevo", "11:00" },
                    { 51, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8620), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8622), 84, 100, 100, "Sarajevo", "11:00" },
                    { 37, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8523), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8525), 81, 100, 100, "Sarajevo", "11:00" },
                    { 52, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8624), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8626), 84, 100, 100, "Sarajevo", "11:00" },
                    { 54, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8633), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8635), 84, 100, 100, "Sarajevo", "11:00" }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Date", "MediaId", "NumberOfSeats", "NumberOfTickets", "Place", "Time" },
                values: new object[,]
                {
                    { 55, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8637), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8639), 85, 100, 100, "Sarajevo", "11:00" },
                    { 56, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8642), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8644), 85, 100, 100, "Sarajevo", "11:00" },
                    { 57, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8646), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8648), 85, 100, 100, "Sarajevo", "11:00" },
                    { 58, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8650), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8652), 85, 100, 100, "Sarajevo", "11:00" },
                    { 59, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8655), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8657), 85, 100, 100, "Sarajevo", "11:00" },
                    { 60, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8659), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8661), 86, 100, 100, "Sarajevo", "11:00" },
                    { 61, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8663), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8665), 86, 100, 100, "Sarajevo", "11:00" },
                    { 62, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8668), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8670), 86, 100, 100, "Sarajevo", "11:00" },
                    { 63, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8672), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8674), 86, 100, 100, "Sarajevo", "11:00" },
                    { 64, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8676), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8678), 86, 100, 100, "Sarajevo", "11:00" },
                    { 65, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8681), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8683), 87, 100, 100, "Sarajevo", "11:00" },
                    { 66, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8685), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8687), 87, 100, 100, "Sarajevo", "11:00" },
                    { 67, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8691), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8693), 87, 100, 100, "Sarajevo", "11:00" },
                    { 53, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8629), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8631), 84, 100, 100, "Sarajevo", "11:00" },
                    { 36, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8519), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8521), 81, 100, 100, "Sarajevo", "11:00" },
                    { 35, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8514), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8516), 81, 100, 100, "Sarajevo", "11:00" },
                    { 34, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8509), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8511), 80, 100, 100, "Sarajevo", "11:00" },
                    { 25, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8469), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8471), 2, 100, 100, "Sarajevo", "11:00" },
                    { 26, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8474), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8476), 2, 100, 100, "Sarajevo", "11:00" },
                    { 27, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8478), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8480), 2, 100, 100, "Sarajevo", "11:00" },
                    { 28, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8483), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8484), 2, 100, 100, "Sarajevo", "11:00" },
                    { 29, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8487), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8489), 2, 100, 100, "Sarajevo", "11:00" },
                    { 22, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8456), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8458), 1, 100, 100, "Sarajevo", "11:00" },
                    { 21, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8452), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8453), 1, 100, 100, "Sarajevo", "11:00" },
                    { 20, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8447), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8449), 1, 100, 100, "Sarajevo", "11:00" },
                    { 19, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8443), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8445), 1, 100, 100, "Sarajevo", "12:00" },
                    { 18, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8437), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8440), 1, 100, 100, "Sarajevo", "13:00" },
                    { 17, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8433), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8435), 1, 100, 100, "Sarajevo", "14:00" },
                    { 16, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8429), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8431), 1, 100, 100, "Sarajevo", "15:00" },
                    { 15, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8424), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8426), 1, 100, 100, "Sarajevo", "16:00" },
                    { 14, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8420), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8422), 1, 100, 100, "Sarajevo", "17:00" },
                    { 13, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8416), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8417), 1, 100, 100, "Sarajevo", "18:00" },
                    { 12, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8411), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8413), 1, 100, 100, "Sarajevo", "19:00" },
                    { 11, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8406), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8408), 1, 100, 100, "Sarajevo", "20:00" },
                    { 33, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8504), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8506), 80, 100, 100, "Sarajevo", "11:00" },
                    { 32, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8500), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8502), 80, 100, 100, "Sarajevo", "11:00" },
                    { 31, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8496), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8497), 80, 100, 100, "Sarajevo", "11:00" },
                    { 30, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8491), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8493), 80, 100, 100, "Sarajevo", "11:00" },
                    { 1, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(6774), "SYSTEM", new DateTime(2022, 2, 10, 13, 44, 40, 17, DateTimeKind.Local).AddTicks(7085), 1, 100, 100, "Sarajevo", "10:00" },
                    { 2, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8358), "SYSTEM", new DateTime(2021, 11, 8, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8368), 1, 100, 100, "Sarajevo", "11:00" },
                    { 24, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8465), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8467), 1, 100, 100, "Sarajevo", "11:00" },
                    { 3, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8372), "SYSTEM", new DateTime(2021, 11, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8374), 1, 100, 100, "Sarajevo", "08:00" }
                });

            migrationBuilder.InsertData(
                table: "Screenings",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Date", "MediaId", "NumberOfSeats", "NumberOfTickets", "Place", "Time" },
                values: new object[,]
                {
                    { 5, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8381), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8383), 1, 100, 100, "Sarajevo", "10:00" },
                    { 6, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8388), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8390), 1, 100, 100, "Sarajevo", "00:00" },
                    { 68, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8695), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8697), 87, 100, 100, "Sarajevo", "11:00" },
                    { 7, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8392), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8394), 1, 100, 100, "Sarajevo", "23:00" },
                    { 8, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8397), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8399), 1, 100, 100, "Sarajevo", "22:00" },
                    { 9, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8401), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8403), 1, 100, 100, "Sarajevo", "21:00" },
                    { 4, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8377), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8379), 1, 100, 100, "Sarajevo", "09:00" },
                    { 69, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8700), "SYSTEM", new DateTime(2022, 2, 6, 8, 4, 40, 17, DateTimeKind.Local).AddTicks(8702), 87, 100, 100, "Sarajevo", "11:00" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "Id", "ArchivedAt", "ArchivedBy", "CreatedAt", "CreatedBy", "Price", "ScreeningId" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 18, DateTimeKind.Local).AddTicks(1899), "SYSTEM", 5.5f, 1 },
                    { 2, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 18, DateTimeKind.Local).AddTicks(2595), "SYSTEM", 5.5f, 25 },
                    { 3, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 18, DateTimeKind.Local).AddTicks(2605), "SYSTEM", 5.5f, 30 },
                    { 4, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 18, DateTimeKind.Local).AddTicks(2608), "SYSTEM", 5.5f, 35 },
                    { 5, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 18, DateTimeKind.Local).AddTicks(2610), "SYSTEM", 5.5f, 40 },
                    { 6, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 18, DateTimeKind.Local).AddTicks(2615), "SYSTEM", 5.5f, 45 },
                    { 7, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 18, DateTimeKind.Local).AddTicks(2618), "SYSTEM", 5.5f, 50 },
                    { 8, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 18, DateTimeKind.Local).AddTicks(2620), "SYSTEM", 5.5f, 55 },
                    { 9, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 18, DateTimeKind.Local).AddTicks(2622), "SYSTEM", 5.5f, 60 },
                    { 10, null, null, new DateTime(2021, 10, 29, 8, 4, 40, 18, DateTimeKind.Local).AddTicks(2625), "SYSTEM", 5.5f, 65 }
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
