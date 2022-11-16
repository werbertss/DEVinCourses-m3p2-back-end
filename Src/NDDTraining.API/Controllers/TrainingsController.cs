using Microsoft.AspNetCore.Mvc;
using NDDTraining.Domain.Interfaces.Services;

namespace NDDTraining.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TrainingsController : ControllerBase
{
    private readonly ITrainingService _trainingService;
    private readonly IModuleService _moduleService;

    public TrainingsController(ITrainingService trainingService, IModuleService moduleService)
    {
        _trainingService = trainingService;
        _moduleService = moduleService;
    }

    [HttpGet] 
    public IActionResult GetAll(
        [FromQuery] string category
    )
    {
        return Ok(_trainingService.GetAll(category));
    } 
}
