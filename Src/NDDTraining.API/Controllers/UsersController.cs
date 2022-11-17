using Microsoft.AspNetCore.Mvc;
using NDDTraining.Domain.Interfaces.Services;
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
        
            
    }


}