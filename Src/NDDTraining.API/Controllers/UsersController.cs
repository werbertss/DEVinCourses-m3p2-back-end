
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Interfaces.Services;


namespace NDDTraining.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IEmailService _emailService;
        public UsersController(IUserService userService, IEmailService emailService)
        {
            _userService = userService;
            _emailService = emailService;
                
        }

        [HttpPost]
        [Route("registration")]
        public IActionResult Post(
            [FromBody] UserDTO newUser
        )
        {
            _userService.InsertUser(newUser);

            return Created("registration", newUser.Id);
        }
        [HttpPost]
        [Route("login")]
        public IActionResult VerifyLogin(
            [FromBody] LoginDTO loginDTO
        )
        {
            string token = _userService.VerifyLogin(loginDTO);

            return Ok(token);
        }

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public IActionResult Authenticated([FromRoute] string token)

        { 
            return Ok(_userService.GetByEmail(token));
        }


        [HttpPost]
        [Route("reset")]
        public IActionResult Reset([FromBody] string emailReset)
        {
            var reset = _userService.Reset(emailReset);

            return Ok();
        }
    }
}