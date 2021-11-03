using Core.Entities;
using Database.Services;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.Infrastructure.Database.Seeds;


namespace Database
{
    public class DataContext : DbContext
    {

        public DataContext() : base()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Data Source=movie-app-task.db");

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

            modelBuilder.Entity<MostRatedMoviesReport>().HasNoKey();
            modelBuilder.Entity<MostScreenedMoviesReport>().HasNoKey();
            modelBuilder.Entity<MovieWithMostSoldTicketsReport>().HasNoKey();
        }
    }
}
