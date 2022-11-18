using Microsoft.AspNetCore.Mvc;
using NDDTraining.Domain.Interfaces.Services;

namespace NDDTraining.API.Controllers
{
    [ApiController]
    [Route("API/Email")]

    public class EmailsController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailsController(IEmailService emailService)
        {
            _emailService = emailService;
        }



        [HttpPost]
        public IActionResult SendMail()
        {

            _emailService.BuildAndSendMail(new Domain.Models.Email()
            {
                To = "raulzito737@gmail.com",
                Subject = "Testando a API",
                Parameters = new Dictionary<string, string>() { { "Name", "Raul" }, { "Sobrenome", "teste" } }





            });


            return Ok();
        }

    }
}