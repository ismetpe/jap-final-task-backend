using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Services
{
    public class ReportsService : IReportsService
    {
        private readonly DataContext _context;

        public ReportsService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<MostRatedMoviesReport>> MostRatedMoviesReport()
        {

            var result = await _context.MostRatedMoviesReports.FromSqlRaw("EXEC [dbo].[GetTopTenMoviesWithMostRating];").ToListAsync();

            return result;

        }

        public async Task<List<MostScreenedMoviesReport>> MostScreenedMoviesReport(DateTime start, DateTime end)
        {
            var result = await _context.MoviesWithMostScreeningsReports.FromSqlRaw("EXEC [dbo].[GetTopTenMoviesWithMostScreening] {0}, {1};", start, end).ToListAsync();

            return result;
        }

        public async Task<List<MovieWithMostSoldTicketsReport>> MoviesWithMostSoldTicketsReport()
        {
            var result = await _context.MoviesWithMostSoldTicketsReports.FromSqlRaw("EXEC [dbo].[GetMoviesWithMostSoldTicketsWithoutRating]").ToListAsync();

            return result;
        }


    }
}
