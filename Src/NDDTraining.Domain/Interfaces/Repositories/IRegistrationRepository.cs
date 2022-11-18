using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Models;

namespace NDDTraining.Domain.Interfaces.Repositories
{

    public interface IRegistrationRepository : IBaseRepository<Registration, int>
    {
        IList<Registration>GetAll();
        void InsertListProgress(RegistrationDTO register );
        public void Delete(int id);
        void InsertListAvailable(RegistrationDTO register );
        void InsertListFinished(RegistrationDTO register );
        void InsertListSuspended(RegistrationDTO register );
        bool RegistrationDuplicate(int id);
        public bool DeleteNoRegistration(int id);
    

    }

}