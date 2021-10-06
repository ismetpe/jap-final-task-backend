using Core.Entities;
using Core.Interfaces;
using Core.Models.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Controllers
{
    [ApiController]
    [Route("api/admin")]
    public class AdminsController : ControllerBase
    {
        private readonly IAdminsService _adminsService;
        public AdminsController(IAdminsService adminsService)
        {
            _adminsService = adminsService;
        }
        [HttpPost("add_movie")]
        public async Task<ActionResult<IEnumerable<Media>>> AddMovie(AddMovieDto request)
        {
            return Ok(await _adminsService.AddMovieAsync(request));
        }
        [HttpPost("add_screening")]
        public async Task<ActionResult<IEnumerable<Media>>> AddScreening(AddScreeningDto request)
        {
            return Ok(await _adminsService.AddScreeningsAsync(request));
        }

        [HttpPost("edit_movie")]
        public async Task<ActionResult<IEnumerable<Media>>> EditMovie(EditMovieDto request,int id)
        {
            return Ok(await _adminsService.EditMovieAsync(request,id));
        }
    }
}
