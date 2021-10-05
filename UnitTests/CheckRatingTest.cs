using AutoMapper;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.AutoMapper;
using movie_app_task_backend.Data;
using movie_app_task_backend.Models;
using movie_app_task_backend.Services.MediaService;
using movie_app_task_backend.Services.RatingService;
using NUnit.Framework;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        DataContext _context;
        MediaService _mediaService;
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
                mc.AddProfile(new AutoMapperProfile());
            });
            _mapper = mappingConfig.CreateMapper();



            _context.Medias.Add(
                        new Media
                        {
                            Id = 1,
                            Title = "Star Wars: Return of the Jedi",
                            Release_year = "1983-05-25",
                            Description = "Luke Skywalker attempts to bring his father back to the light side of the Force. At the same time, the rebels hatch a plan to destroy the second Death Star.",
                            img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZZCMJ4/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                            isSeries = false,

                        });
            _context.Medias.Add(
                              new Media
                              {
                                  Id = 2,
                                  Title = "Star Wars: A New Hope",
                                  Release_year = "1977-05-17",
                                  Description = "After Princess Leia, the leader of the Rebel Alliance, is held hostage by Darth Vader, Luke and Han Solo must free her and destroy the powerful weapon created by the Galactic Empire.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZXZDZ3/image?locale=en-us&mode=crop&purposes=BoxArt&q=90&h=225&w=150&",
                                  isSeries = false,

                              });
            _context.Medias.Add(
                              new Media
                              {
                                  Id = 3,
                                  Title = "Lord Of The Rings: The Two Towers",
                                  Release_year = "2002-12-18",
                                  Description = "Frodo and Sam arrive in Mordor with the help of Gollum. A number of new allies join their former companions to defend Isengard as Saruman launches an assault from his domain",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL60J7/image?locale=en-gb&purposes=BoxArt&mode=scale&q=90&w=162",
                                  isSeries = false,

                              });

            _context.Medias.Add(
                              new Media
                              {
                                  Id = 4,
                                  Title = "The Hobbit: An Unexpected Journey",
                                  Release_year = "2012-12-13",
                                  Description = "Bilbo Baggins, a hobbit, is persuaded into accompanying a wizard and a group of dwarves on a journey to reclaim the city of Erebor and all its riches from the dragon Smaug.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.movie.8D6KGWZL59HB/image?locale=en-au&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              });
           _context.Medias.Add(
                             new Media
                              {
                                  Id = 5,
                                  Title = "Brooklyn Nine-Nine",
                                  Release_year = "2013-09-17",
                                  Description = "Ray Holt, an eccentric commanding officer, and his diverse and quirky team of odd detectives solve crimes in Brooklyn, New York City.",
                                  img_url = "https://musicimage.xboxlive.com/catalog/video.tvseason.8D6KGWXN91QP/image?locale=de-de&mode=crop&purposes=BoxArt&q=90&h=225&w=150&format=jpg",
                                  isSeries = false,

                              });



            _context.Ratings.Add(new Rating { Id = 1, Rating_value = 4.6F, MediaId = 1 });
            _context.Ratings.Add(new Rating { Id = 2, Rating_value = 4.5F, MediaId = 1 });
            _context.Ratings.Add(new Rating { Id = 3, Rating_value = 4.0F, MediaId = 1 });
            _context.Ratings.Add(new Rating { Id = 4, Rating_value = 4.2F, MediaId = 1 });

            _context.Ratings.Add(new Rating { Id = 5, Rating_value = 4.6F, MediaId = 2 });
            _context.Ratings.Add(new Rating { Id = 6, Rating_value = 4.5F, MediaId = 2 });
            _context.Ratings.Add(new Rating { Id = 7, Rating_value = 4.0F, MediaId = 2 });
            _context.Ratings.Add(new Rating { Id = 8, Rating_value = 4.2F, MediaId = 2 });

            _context.Ratings.Add(new Rating { Id = 9, Rating_value = 3.0F, MediaId = 3 });
            await _context.SaveChangesAsync();
            _mediaService = new MediaService(_mapper,_context);
        }

        [TearDown]
        public async Task TearDownAsync()
        {
            await _context.Database.EnsureDeletedAsync();
        }
        [Test]
        public async Task Movie_Valid_Rating_Test()
        {
            var data = await _mediaService.GetAllMovies(false);
            var movie = data.Find(x => x.Id == 1);
            Assert.AreEqual(4.3F, movie.Ratings.Select(x => x.Rating_value).Average(), 0.1); 
        }
        [Test]
        public async Task Movie_Zero_Rating_Test()
        {
            var data = await _mediaService.GetAllMovies(false);
            var movie = data.Find(x => x.Id == 4);
            float rating = 0;
            if (movie.Ratings.Select(x => x.Rating_value).Any())
            {
                rating = movie.Ratings.Select(x => x.Rating_value).Average();
            }
            Assert.AreEqual(0, rating);
        }
        [Test]
        public async Task Movie_Valid_Rating_Test2()
        {
            var data = await _mediaService.GetAllMovies(false);
            var movie = data.Find(x => x.Id == 3);
            Assert.IsTrue(movie.Ratings.Select(x => x.Rating_value).Average() >= 0 && movie.Ratings.Select(x => x.Rating_value).Average() <= 5);
        }
    }
}