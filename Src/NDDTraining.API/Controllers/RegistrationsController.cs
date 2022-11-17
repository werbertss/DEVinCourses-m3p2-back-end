using Microsoft.AspNetCore.Mvc;
using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Interfaces.Services;
using NDDTraining.Domain.Models;


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

        [HttpPost]

        public IActionResult Insert(RegistrationDTO registration)
        {
            try
            {
                if(registration.Status.ToUpper()== "PROGRESS")
                {
                    _registrationService.InsertProgress(registration);
                }
                if (registration.Status.ToUpper() == "AVAILABLE")
                {
                    _registrationService.InsertAvailable(registration);
                } 
                
                if (registration.Status.ToUpper() == "SUSPENDED")
                {
                    _registrationService.InsertSuspended(registration);
                }
                if (registration.Status.ToUpper() == "FINISHED")
                {
                    _registrationService.InsertFinished(registration);
                }

                _registrationService.Insert(registration);
                return StatusCode(StatusCodes.Status201Created);

            }
            catch (Exception)
            {

                throw new Exception(StatusCodes.Status500InternalServerError.ToString()) ;
            }
            

        }
    }
}
