using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Models;

namespace NDDTraining.Domain.Interfaces.Repositories
{
    public interface IRegistrationRepository : IBaseRepository<Registration, int>
    {
        IList<Registration>GetAll();
        bool RegistrationDuplicate(int id);
        public void InsertProgress(RegistrationDTO registration);
        public void InsertSuspended(RegistrationDTO registration);  
        public void InsertFinished(RegistrationDTO registration);  
        public void InsertAvailable(RegistrationDTO registration);


        // Registration GetById(int id);
        // void Change (Registration registration);
        // void Delete (Registration registration);
    }
}