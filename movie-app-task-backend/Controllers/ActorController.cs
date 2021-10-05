using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace movie_app_task_backend.Controllers
{   
    [ApiController]
    [Route("api/[controller]")]
    public class ActorController : ControllerBase
    {
        private readonly IActorsService _actorsService;
        public ActorController(IActorsService actorsService)
        {
            _actorsService = actorsService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actor>>> GetActors(){
               return Ok(await _actorsService.GetActors());
        }

    }
}