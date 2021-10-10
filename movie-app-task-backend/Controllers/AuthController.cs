using Core.Entities;
using Core.Interfaces;

using Microsoft.AspNetCore.Mvc;
using Core.Models.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movie_app_task_backend.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("register")]
        public async Task<ActionResult<ServiceResponse<int>>> Register(RegisterRequest request)
        {
            var user = new User
            {
                Username = request.Username,

            };

            var response = await _authService.Register(user, request.Password);

            return (response.Success) ? Ok(response) : BadRequest(response);
        }

        [HttpPost("login")]
        public async Task<ActionResult<ServiceResponse<string>>> Login(LoginRequest request)
        {
            var response = await _authService.Login(request.Username, request.Password);

            return (response.Success) ? Ok(response) : BadRequest(response);
        }

    }
}

