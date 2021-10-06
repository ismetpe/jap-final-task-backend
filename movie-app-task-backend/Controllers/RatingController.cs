using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Interfaces;
using Core.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace movie_app_task_backend.Controllers
{
    
    [ApiController]
    [Route("api/rating")]
    public class RatingController : ControllerBase
    {        private readonly IRatingsService _ratingService;

        public RatingController(IRatingsService ratingService) 
        {

            _ratingService = ratingService;

        }

        [HttpPost("add")]
        public async Task<IActionResult> AddRating(AddRatingDto addRating)
        {
            var response = await _ratingService.AddRating(addRating.Rating_value, addRating.MediaId);
            
            return Ok(response);
        }
    }
}