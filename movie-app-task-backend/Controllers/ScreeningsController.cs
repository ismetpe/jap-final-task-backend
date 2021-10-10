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
    [Route("api/screenings")]
    public class ScreeningsController : ControllerBase
    {
        private readonly IScreeningsService _screeningsService;

        public ScreeningsController(IScreeningsService screeningsService)
        {
            _screeningsService = screeningsService;
        }
        [HttpPost("buy_ticket")]
        public async Task<ActionResult<int>> BuyTicket([FromBody] AddPurchasedTicketDto req)
        {
            return Ok(await _screeningsService.BuyTickets(req));
        }
        [HttpGet("screenings_by_movie")]
        public async Task<ActionResult<List<GetScreeningDto>>> GetScreeningsbyMovie(int id)
        {
            return Ok(await _screeningsService.GetScreeningsByMovie(id));
        }
    }
}
