using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Core.Models.Models;
using Core.Models.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace movie_app_task_backend.Controllers
{
   [ApiController]
    [Route("api/media")]
    public class MediaController : ControllerBase
    {

        private readonly IMediaService _mediaService;

        public MediaController(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        [HttpGet("get_media")]
        public async Task<ActionResult<List<GetMediaDto>>> GetAllMovies([FromQuery] GetMediaRequestDto req)
        {
            return Ok(await _mediaService.GetMediaAsync(req));
        }

        [HttpPost("add_movie")]
        public async Task<ActionResult<IEnumerable<Media>>> AddMovie(AddMovieDto request)
        {
            return Ok(await _mediaService.AddMovieAsync(request));
        }

        [HttpPost("edit_movie")]
        public async Task<ActionResult<IEnumerable<Media>>> EditMovie(EditMovieDto request, int id)
        {
            return Ok(await _mediaService.EditMovieAsync(request, id));
        }

    }