using Microsoft.AspNetCore.Mvc;
using NDDTraining.Domain.Interfaces.Services;
using NDDTraining.Domain.Models;

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
        [FromQuery] string category,
        int skip = 0,
        int take = 20
    )
    {
        var paging = new Paging(take, skip);
        return Ok(_trainingService.GetAll(category, paging));
    } 

    [HttpGet("{id}")]
    public IActionResult GetById(
        [FromRoute] int id
    )
    {
        return Ok(_trainingService.GetById(id));
    }
    
    // Rota de suspensão de treinamento, espera o nome ou o id de um treinamento
    [HttpPut("suspend/{nameOrId}")]
    public IActionResult Suspend(
        [FromRoute] string nameOrId
    )
    {
        // Chama a função de suspensão feita no service de treinamentos
        _trainingService.Suspend(nameOrId);

        // Retorna um código 204(No Content), para o usuario reconhecer o sucesso da requisição
        return NoContent();
    }
}
