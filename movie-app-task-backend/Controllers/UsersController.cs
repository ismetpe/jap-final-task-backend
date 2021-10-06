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
    [Route("api/user")]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _usersService;
        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }


        [HttpGet("bought_tickets")]
        public async Task<ActionResult<IEnumerable<GetPurchasedTicketsDto>>> GetUserTickets(int id)
        {
            return Ok(await _usersService.GetUserTicketsAsync(id));
        }
    }
}
