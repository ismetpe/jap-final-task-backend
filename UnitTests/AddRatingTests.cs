using AutoMapper;
using Microsoft.EntityFrameworkCore;
using movie_app_task_backend.AutoMapper;
using movie_app_task_backend.Data;
using movie_app_task_backend.Models;
using movie_app_task_backend.Services.MediaService;
using movie_app_task_backend.Services.RatingService;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestFixture]
    public class AddRatingTest
    {
        DataContext _context;
        MediaService _mediaService;
        RatingsService _ratingService;
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

        

            _context.Ratings.Add(new Rating { Id = 9, Rating_value = 3.0F, MediaId = 3 });
            await _context.SaveChangesAsync();
            _mediaService = new MediaService(_mapper, _context);
            _ratingService = new RatingsService(_context);
        }

        [TearDown]
        public async Task TearDownAsync()
        {
            await _context.Database.EnsureDeletedAsync();
        }


        [Test]
        public async Task Add_Rating1()
        {
            var data = await _mediaService.GetAllMovies(false);
            var movie = data.Find(x => x.Id == 3);
            var result = await _ratingService.AddRating(4.0F, movie.Id);

            Assert.AreEqual(10,result);
        }



        [Test]
        public async Task Add_Rating2()
        {
       
            await _ratingService.AddRating(4.0F, 4);
            await _ratingService.AddRating(5.0F, 4);
            await _ratingService.AddRating(3.0F, 4);
            await _ratingService.AddRating(2.0F, 4);
         var data = await _mediaService.GetAllMovies(false);
         var movie = data.Find(x => x.Id == 4);

            Assert.AreEqual(3.5F, movie.Ratings.Select(x => x.Rating_value).Average(),0.1);
        }
    }
}
