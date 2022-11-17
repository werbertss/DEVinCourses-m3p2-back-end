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
    public class TrainingService : ITrainingService
    {
        private readonly ITrainingRepository _trainingRepository;

        public TrainingService(ITrainingRepository trainingRepository)
        {
            _trainingRepository = trainingRepository;
        }

        public void DeleteTraining()
        {
            throw new NotImplementedException();
        }

        public void FinishTrainig()
        {
            throw new NotImplementedException();
        }

        public IList<TrainingDTO> GetAll(string? category, Paging paging)
        {
            var query = _trainingRepository.GetAll(paging).AsQueryable();
            
            if(!String.IsNullOrEmpty(category))
                query = query.Where(t => t.Category.ToUpper() == category.ToUpper());

            if(!query.ToList().Any())
                throw new Exception("Register not found!");

            return query.Select(t => new TrainingDTO(t)).ToList();
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