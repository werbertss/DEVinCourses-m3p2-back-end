using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NDDTraining.Domain.Models;
using NDDTraining.Infra.Data.Context;
using NDDTraining.Domain.Interfaces.Repositories;

namespace NDDTraining.Infra.Database.Repositories
{
  public class TrainingRepository : BaseRepository<Training, int>, ITrainingRepository
  {
    public TrainingRepository(NDDTrainingDbContext context) : base(context) { }


  }
}