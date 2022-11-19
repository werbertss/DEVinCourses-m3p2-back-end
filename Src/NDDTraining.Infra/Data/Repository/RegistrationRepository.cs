using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NDDTraining.Domain.Models;
using NDDTraining.Infra.Data.Context;
using NDDTraining.Domain.Interfaces.Repositories;
using NDDTraining.Domain.DTOS;

namespace NDDTraining.Infra.Data.Repository
{
    public class RegistrationRepository : BaseRepository<Registration, int>, IRegistrationRepository

    {
        public List<RegistrationDTO> SuspendedList = new List<RegistrationDTO>();
        public List<RegistrationDTO> FinishedList = new List<RegistrationDTO>();
        public List<RegistrationDTO> ProgressList = new List<RegistrationDTO>();
        public List<RegistrationDTO> AvailableList = new List<RegistrationDTO>();


        private readonly NDDTrainingDbContext _context;
        public RegistrationRepository(NDDTrainingDbContext context) : base(context)
        {
            _context = context;
        }

        public IList<Registration> GetAll()
        {
            return _context.Registrations.ToList();
        }


        public void Insert(Registration registration)
        {
            _context.Registrations.Add(registration);
            _context.SaveChanges();
        }



        public void InsertListProgress(RegistrationDTO register)
        {
            ProgressList.Add(register);

        }
        public void InsertListSuspended(RegistrationDTO register)
        {
            SuspendedList.Add(register);

        }
        public void InsertListAvailable(RegistrationDTO register)
        {
            AvailableList.Add(register);
        }
        public void InsertListFinished(RegistrationDTO register)
        {
            FinishedList.Add(register);
        }

        public bool RegistrationDuplicate(int id)
        {
            return _context.Registrations.Any(x => x.Id == id);
        }

        public void Delete(int userId)
        {

            var user = _context.Registrations.Find(userId);

            _context.Registrations.Remove(user);
            _context.SaveChanges();
        }

        public bool DeleteNoRegistration(int userId)
        {
            var user = _context.Registrations.Find(userId);
            if (user == null) return true;
            else return false;

        }
    }
}