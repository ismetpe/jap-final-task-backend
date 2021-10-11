using Core.Entities;
using Database.Services;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Infrastructure.Database.Seeds;


namespace Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Media> Medias { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<MostRatedMoviesReport> MostRatedMoviesReports { get; set; }
        public DbSet<MostScreenedMoviesReport> MoviesWithMostScreeningsReports { get; set; }
        public DbSet<MovieWithMostSoldTicketsReport> MoviesWithMostSoldTicketsReports { get; set; }
        public DbSet<PurchasedTicket> PurchasedTickets { get; set; }

        public object MostScreenedMoviesReports { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            AuthService.CreatePasswordHash("admin", out byte[] passHash, out byte[] passSalt);
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "Admin", Admin = true, Salt = passSalt, Hash = passHash }
            );
            modelBuilder.Entity<Media>().HasData(MediaSeed.Medias);

            modelBuilder.Entity<Actor>().HasData(ActorsSeed.Actors);

            modelBuilder.Entity<Rating>().HasData(RatingsSeed.Ratings);

            modelBuilder.Entity<Screening>().HasData(ScreeningsSeed.Screenings);

            modelBuilder.Entity<Ticket>().HasData(TicketsSeed.Tickets);



            /*              string GetMoviesWithMostSoldTicketsWithoutRating = @" CREATE PROCEDURE GetMoviesWithMostSoldTicketsWithoutRating
                                                             AS
                                                             BEGIN
                                                             SET NOCOUNT ON

                                                             SELECT  m.Id, m.Title, s.Id AS ScreeningName,COUNT(t.Id) AS SoldTickets
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
            migrationBuilder.Sql(GetTopTenMoviesWithMostScreening);*/
            modelBuilder.Entity<MostRatedMoviesReport>().HasNoKey();
            modelBuilder.Entity<MostScreenedMoviesReport>().HasNoKey();
            modelBuilder.Entity<MovieWithMostSoldTicketsReport>().HasNoKey();
        }
    }
}
