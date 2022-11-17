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
        public IActionResult SendMail([FromQuery]  string from,[FromQuery] string recepient,[FromQuery] string subject,[FromQuery] string body){

            _emailService.SendEmail(from, recepient, subject, body);


            return Ok();
        }
        
    }
}