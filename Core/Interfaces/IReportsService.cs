
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Core.Interfaces
{
    public interface IReportsService
    {
        Task<List<MostRatedMoviesReport>> MostRatedMoviesReport();
        Task<List<MostScreenedMoviesReport>> MostScreenedMoviesReport(DateTime start,DateTime end);
        Task<List<MovieWithMostSoldTicketsReport>> MoviesWithMostSoldTicketsReport();
    }
}
