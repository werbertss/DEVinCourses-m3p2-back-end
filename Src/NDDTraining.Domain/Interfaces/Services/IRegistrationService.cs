
using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDTraining.Domain.Interfaces.Services
{

    public interface IRegistrationService
    {
        public IList<RegistrationDTO> GetAll();
        public IList<RegistrationDTO> GetRegistrationsByUser(int userId, string status);
        public void ValidateRegistration(RegistrationDTO registration);
        public void Insert(RegistrationDTO registration);
        public void Delete(int id);
       
  }
}
