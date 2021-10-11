using Core.Entities;
using Core.Interfaces;
using Core.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Services
{
    public class AdminsService : IAdminsService
    {

        private readonly DataContext _context;
     


        public AdminsService(DataContext context)
        {
            _context = context;
        }

        public async Task<int> AddMovieAsync(AddMovieDto movie)
        {
            var addMovie = new Media
            {
              Title = movie.Title,
              Description = movie.Description,
              ReleaseYear = movie.Release_year,
              ImgUrl = movie.img_url,
              MediaType = movie.MediaType

            };

            await _context.Medias.AddAsync(addMovie);
            await _context.SaveChangesAsync();

            return _context.Medias.Max(x => x.Id); 
        }

        public async Task<int> AddScreeningsAsync(AddScreeningDto screening)
        {
            var addScreening = new Screening
            {
                Date = screening.Date,
                Place = screening.Place,
                Number_of_seats = screening.Number_of_seats,
                Number_of_tickets = screening.Number_of_tickets,
                Tickets = screening.Tickets,
                Time = screening.Time,
                MediaId = screening.MediaId
            };

            await _context.Screenings.AddAsync(addScreening);
            await _context.SaveChangesAsync();

            return _context.Screenings.Max(x => x.Id);
        }

        public async Task<int> EditMovieAsync(EditMovieDto movie, int Id)
        {
            Media m = _context.Medias.Find(Id);

            if(movie.Description != null && movie.Description != "")
            {
                m.Description = movie.Description;
            }
            if (movie.Title != null && movie.Title != "")
            {
                m.Title = movie.Title;
            }
            if (movie.img_url != null && movie.img_url != "")
            {
                m.ImgUrl = movie.img_url;
            }
            if (movie.Release_year != null && movie.Release_year != "")
            {
                m.ReleaseYear = movie.Release_year;
            }


            await _context.SaveChangesAsync();

            return _context.Screenings.Max(x => x.Id);
        }
    }
}
