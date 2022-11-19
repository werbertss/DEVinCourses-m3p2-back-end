using Microsoft.AspNetCore.Mvc;
using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Interfaces.Services;
using NDDTraining.Domain.Models;
using NDDTraining.Domain.Services;

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
        public IActionResult Post(
            [FromBody] UserDTO newUser
        )
        {  
            _userService.InsertUser(newUser);

            return Created("api/users", newUser.Id);
        }
        [HttpPost]
        [Route("api/users/login")]
        public IActionResult VerifyLogin(
            [FromBody] LoginDTO loginDTO
        )
        {
            string token = _userService.VerifyLogin(loginDTO);

            return Ok(token);
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