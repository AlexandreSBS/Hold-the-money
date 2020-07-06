using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoldTheMoney.Domain.Entities;
using HoldTheMoney.Domain.Interfaces.Services;
using HoldTheMoney.Domain.ValueObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace HoldTheMoney.Api.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;
        private readonly IAuthService _authService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>   
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPost]
        public CreatedResult Create(User user)
        {
            user = _userService.Create(user);

            return Created("/", user);
        }

        [HttpPost("login")]
        public IActionResult Login(AuthInfo authInfo)
        {
            _authService.Authenticate(authInfo);

            return Ok(new { });
        }

    }
}
