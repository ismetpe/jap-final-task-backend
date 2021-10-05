using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Services
{
    public class RatingsService : IRatingsService
    {

        private readonly DataContext _context;
        private IHttpContextAccessor _httpContextAccessor;


        public RatingsService(DataContext context)
        {
            _context = context;
        }
        public async Task<int> AddRating(float rating, int MediaId)
        {
            var addRating = new Rating
            {
                Rating_value = rating,
                MediaId = MediaId,

            };

            await _context.Ratings.AddAsync(addRating);
            await _context.SaveChangesAsync();

            int result = _context.Ratings.Max(x => x.Id);

            return result;
        }
    }
}
