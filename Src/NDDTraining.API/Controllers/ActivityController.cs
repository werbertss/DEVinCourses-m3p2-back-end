using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NDDTraining.Domain.Interfaces.Services;
using NDDTraining.Domain.DTOS;

namespace NDDTraining.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingActivityController : ControllerBase
    {
        private readonly ITrainingActivityService _activityService;

        public TrainingActivityController(ITrainingActivityService activityService)
        {
            _activityService = activityService;
        }

        [HttpPost]

        public IActionResult Insert(TrainingActivityDTO activity) 
        {
            _activityService.Insert(activity);

            return  Ok(activity);
        }

    }
}
