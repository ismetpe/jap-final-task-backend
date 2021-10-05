using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class VideosController : ControllerBase
    {

        private readonly IMediaService _mediaService;

        public VideosController(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        [HttpGet("get_media")]
        public async Task<ActionResult<List<GetMediaDto>>> GetAllMovies([FromQuery] GetMediaRequestDto req)
        {
            return Ok(await _mediaService.GetMedia(req));
        }
    }
}