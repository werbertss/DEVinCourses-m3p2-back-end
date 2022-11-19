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
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPut("update/{id}")]
        public IActionResult Put(
            [FromBody] UserDTO changedUser,
            [FromRoute] int id
        )
        {
            _userService.Update(changedUser, id);

            return NoContent();
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
    }
}