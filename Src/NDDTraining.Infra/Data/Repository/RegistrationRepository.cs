using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NDDTraining.Domain.Models;
using NDDTraining.Infra.Data.Context;
using NDDTraining.Domain.Interfaces.Repositories;
using NDDTraining.Domain.DTOS;

namespace NDDTraining.Infra.Database.Repositories
{
  public class RegistrationRepository : BaseRepository<Registration, int>, IRegistrationRepository

  {
        private readonly NDDTrainingDbContext _context;
        public RegistrationRepository(NDDTrainingDbContext context) : base(context) { }

        public IList<Registration> GetAll()
        {
            return _context.Registrations.ToList();
        }
    }
}