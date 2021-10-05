using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;
using Core.Entities;
using Core.Models.Models;

namespace movie_app_task_backend.Controllers
{
    [ApiController]
    [Route("api/reports")]
    public class ReportController : ControllerBase
    {

        private readonly IReportsService _reportsService;

        public ReportController(IReportsService reportsService)
        {
            _reportsService = reportsService;
        }

        [HttpGet("most_rated_movies")]
        public async Task<ActionResult<List<MostRatedMoviesReport>>> GetMostRatedMoviesReport()
        {
            return Ok(await _reportsService.MostRatedMoviesReport());
        }

        [HttpPost("movies_with_most_screenings")]
        public async Task<ActionResult<List<MostScreenedMoviesReport>>> MoviesWithMostScreeningsReport([FromBody] ScreeningDateDTO interval )
        {
            return Ok(await _reportsService.MostScreenedMoviesReport(interval.startDate, interval.endDate));
        }

        [HttpGet("movies_with_most_sold_tickets")]
        public async Task<ActionResult<List<MovieWithMostSoldTicketsReport>>> MoviesWithMostSoldTicketsReport()
        {
            return Ok(await _reportsService.MoviesWithMostSoldTicketsReport());
        }
    }
}
