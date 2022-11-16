using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Interfaces.Services;

namespace NDDTraining.Domain.Services
{
    public class TrainingService : ITrainingService
    {
        public void DeleteTraining()
        {
            throw new NotImplementedException();
        }

        public void FinishTrainig()
        {
            throw new NotImplementedException();
        }

        public IList<TrainingDTO> GetAll(string category)
        {
            throw new NotImplementedException();
        }

        public TrainingDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TrainingDTO GetTrainingFinish()
        {
            throw new NotImplementedException();
        }

        public TrainingDTO GetTrainingProgress()
        {
            throw new NotImplementedException();
        }
    }
}