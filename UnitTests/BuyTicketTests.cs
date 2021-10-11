using AutoMapper;
using Core.Entities;
using Core.Models.Models;
using Database;
using Database.Services;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        DataContext _context;
        ScreeningsService screeningsService;
        private IMapper _mapper;
        [SetUp]
        public async Task Setup()
        {
            var options = new DbContextOptionsBuilder<DataContext>()
             .UseInMemoryDatabase(databaseName: "moviedb1")
             .Options;
            _context = new DataContext(options);

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new movie_app_task_backend.AutoMapperProfile());
            });
            _mapper = mappingConfig.CreateMapper();



            _context.Medias.Add(
                        new Media
                        {
                            Id = 1,
                            Title = "Star Wars: Return of the Jedi",
                            ReleaseYear = "1983-05-25",
                            Description = "Luke Skywalker attempts to bring his father back to the light side of the Force. At the same time, the rebels hatch a plan to destroy the second Death Star.",
                            ImgUrl = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZZCMJ4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                            MediaType = 0,

                        });
            _context.Medias.Add(
                              new Media
                              {
                                  Id = 2,
                                  Title = "Star Wars: A New Hope",
                                  ReleaseYear = "1977-05-17",
                                  Description = "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.",
                                  ImgUrl = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZXZDZ3/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&",
                                  MediaType = 0,

                              });
            _context.Medias.Add(
                              new Media
                              {
                                  Id = 3,
                                  Title = "Lord Of The Rings: The Two Towers",
                                  ReleaseYear = "2002-12-18",
                                  Description = "Frodo and Sam arrive in Mordor with the help of Gollum. A number of new allies join their former companions to defend Isengard as Saruman launches an assault from his domain",
                                  ImgUrl = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162",
                                  MediaType = 0,

                              });

            _context.Medias.Add(
                              new Media
                              {
                                  Id = 4,
                                  Title = "The Hobbit: An Unexpected Journey",
                                  ReleaseYear = "2012-12-13",
                                  Description = "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.",
                                  ImgUrl = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  MediaType = 0,

                              });
            _context.Medias.Add(
                              new Media
                              {
                                  Id = 5,
                                  Title = "Brooklyn Nine-Nine",
                                  ReleaseYear = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  ImgUrl = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  MediaType = 0,

                              });



            _context.Ratings.Add(new Rating { Id = 1, Rating_value = 4.6F, MediaId = 1 });
            _context.Ratings.Add(new Rating { Id = 2, Rating_value = 4.5F, MediaId = 1 });
            _context.Ratings.Add(new Rating { Id = 3, Rating_value = 4.0F, MediaId = 1 });
            _context.Ratings.Add(new Rating { Id = 4, Rating_value = 4.2F, MediaId = 1 });

             _context.Screenings.Add(new Screening { Id = 1, Date = System.DateTime.Now.AddDays(100).AddHours(100).AddMinutes(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "10:00" });
            _context.Screenings.Add(new Screening { Id = 2, Date = System.DateTime.Now.AddDays(10), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "11:00" });
            _context.Screenings.Add(new Screening { Id = 3, Date = System.DateTime.Now.AddDays(8), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "08:00" });
            _context.Screenings.Add(new Screening { Id = 4, Date = System.DateTime.Now.AddDays(100), MediaId = 1, Number_of_seats = 100, Number_of_tickets = 100, Place = "Sarajevo", Time = "09:00" });

            AuthService.CreatePasswordHash("user123", out byte[] passHash, out byte[] passSalt);
            _context.Users.Add(new User { Id = 1, Username = "user", Admin = false, Salt = passSalt, Hash = passHash });


            await _context.SaveChangesAsync();
            screeningsService = new ScreeningsService(_context,_mapper);
            
        }


        [Test, Order(1)]
        public async Task Buy_Ticket_Valid_Test()
        {
            var request = new AddPurchasedTicketDto
            {
                UserID = 1,
                ScreeningID = 4,
                NumberOfTickets = 4,

            };

            var result = await screeningsService.BuyTickets(request);

            Console.WriteLine(result);

            Assert.AreEqual(4, result);
        }
        [Test, Order(2)]
        public async Task Buy_More_Than_Ten_Tickets_Test()
        {


            Assert.That(BuyMoreThan10Tickets, Throws.Exception);
        }



        public async Task<int> BuyMoreThan10Tickets()
        {
            var request = new AddPurchasedTicketDto
            {
                UserID = 1,
                ScreeningID = 1,
                NumberOfTickets = 11,

            };

            var result = await screeningsService.BuyTickets(request);
            return result;
        }


        [Test, Order(3)]
        public async Task Buy_Tickets_With_Data_After_Screening_Test()
        {


            Assert.That(BuyTicketsAfterScreeningDate, Throws.Exception);
        }



        public async Task<int> BuyTicketsAfterScreeningDate()
        {
            var request = new AddPurchasedTicketDto
            {
                UserID = 1,
                ScreeningID = 2,
                NumberOfTickets = 7,
                DateOfBuying = System.DateTime.Now.AddDays(1)
            };

            var result = await screeningsService.BuyTickets(request);
            return result;
        }
    }
}