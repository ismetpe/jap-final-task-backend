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
    [Route("[controller]")]
    public class AuthController : Controller
    {
   

            private readonly IAuthService _authService;
            public AuthController(IAuthService authRepo)
            {
            _authService = authRepo;

            }

            [HttpPost("Register")]
            public async Task<ActionResult<ServiceResponse<int>>> Register(UserRegistrationDto request)
            {
                var response = await _authService.Register(
                    new User { Username = request.Username }, request.Password
                );

                if (!response.Success)
                {
                    return BadRequest(response);
                }

                return Ok(response);
            }

            [HttpPost("Login")]
            public async Task<ActionResult<ServiceResponse<string>>> Login(UserLoginDto request)
            {
                var response = await _authService.Login(
                    request.Username, request.Password
                );

                if (!response.Success)
                {
                    return BadRequest(response);
                }

                return Ok(response);
            }
        }
    }

