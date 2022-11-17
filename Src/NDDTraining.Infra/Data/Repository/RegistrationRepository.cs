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
        private readonly NDDTrainingDbContext _context;
        public RegistrationRepository(NDDTrainingDbContext context) : base(context) { 
        _context = context;
        }



        
        public IList<Registration> GetAll()
        {
            return _context.Registrations.ToList();
        }

        public void InsertProgress(RegistrationDTO registration)
        {
            Registration addRegistration = new Registration();
              addRegistration.TrainingsProgress.Add(registration);
        }
        public void InsertAvailable(RegistrationDTO registration)
        {
            Registration addRegistration = new Registration();
            addRegistration.TrainingsAvailable.Add(registration);
        }
        public void InsertFinished(RegistrationDTO registration)
        {
            Registration addRegistration = new Registration();
            addRegistration.TrainingsFinished.Add(registration);
        } 
        public void InsertSuspended(RegistrationDTO registration)
        {
            Registration addRegistration = new Registration();
            addRegistration.TrainingsSuspended.Add(registration);
        }  
        public void Insert(Registration registration)
        {
            _context.Registrations.Add(registration);
            _context.SaveChanges();
        }
        
        public bool RegistrationDuplicate(int id)
        {

            return _context.Registrations.Any(x => x.Id == id);

             
        }
    }
}