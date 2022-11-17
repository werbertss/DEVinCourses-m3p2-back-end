using Microsoft.AspNetCore.Mvc;
using NDDTraining.Domain.Interfaces.Services;

namespace NDDTraining.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class RegistrationsController : Controller
    {
        private readonly IRegistrationService _registrationService;

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_registrationService.GetAll());
            }
            catch
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
