using Microsoft.AspNetCore.Mvc;
using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Interfaces.Services;

namespace NDDTraining.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompletedModulesController : ControllerBase
    {
        private readonly ICompletedModuleService _completedmoduleService;

        public CompletedModulesController(ICompletedModuleService completedmoduleService)
        {
            _completedmoduleService = completedmoduleService;
        }

       
    }
}
