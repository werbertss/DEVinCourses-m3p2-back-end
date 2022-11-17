using Microsoft.AspNetCore.Mvc;

namespace NDDTraining.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class RegistrationsController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
