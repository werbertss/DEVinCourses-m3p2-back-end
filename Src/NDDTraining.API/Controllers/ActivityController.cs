using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NDDTraining.Domain.Interfaces.Services;
using NDDTraining.Domain.DTOS;

namespace NDDTraining.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        [HttpPost]

        public IActionResult Insert(ActivityDTO activity) 
        {
            _activityService.Insert(activity);

            return  Ok(activity);
        }

    }
}
