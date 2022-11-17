using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Interfaces.Repositories;
using NDDTraining.Domain.Interfaces.Services;
using NDDTraining.Domain.Models;

namespace NDDTraining.Domain.Services
{
  public class RegistrationService : IRegistrationService
  {
        private readonly IRegistrationRepository _registrationRepository;


        public RegistrationService(IRegistrationRepository registrationRepository)
        {
            _registrationRepository = registrationRepository;
        }

        public IList<RegistrationDTO> GetAll()
        {
            return _registrationRepository.GetAll()
                  .Select(x => new RegistrationDTO(x)).ToList();

          
        }

        public void SendEMail()
    {
      throw new NotImplementedException();
    }

    public void ValidateRegistration()
    {
      throw new NotImplementedException();
    }
  }
}