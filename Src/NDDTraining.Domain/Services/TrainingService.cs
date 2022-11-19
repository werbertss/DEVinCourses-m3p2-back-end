using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Interfaces.Repositories;
using NDDTraining.Domain.Interfaces.Services;
using NDDTraining.Domain.Models;
using NDDTraining.Domain.Exceptions;

namespace NDDTraining.Domain.Services
{
    public class TrainingService : ITrainingService
    {
        private readonly ITrainingRepository _trainingRepository;
        private readonly IUserRepository _userRepository;
        private readonly IRegistrationRepository _registrationRepository;

        public TrainingService(ITrainingRepository trainingRepository, IUserRepository userRepository,
            IRegistrationRepository registrationRepository)
        {
            _trainingRepository = trainingRepository;
            _userRepository = userRepository;
            _registrationRepository = registrationRepository;
        }

        public void DeleteTraining()
        {
            throw new NotImplementedException();
        }

        public void FinishTrainig()
        {
            throw new NotImplementedException();
        }

        public IList<TrainingDTO> GetAll(string category, Paging paging)
        {
            var query = _trainingRepository.GetAll(paging).AsQueryable();

            if (!String.IsNullOrEmpty(category))
                query = query.Where(t => t.Category.ToUpper() == category.ToUpper());

            if (!query.ToList().Any())
                throw new Exception("Register not found!");

            return query.Select(t => new TrainingDTO(t)).ToList();
        }

        public TrainingDTO GetById(int id)
        {
            var training = _trainingRepository.GetById(id);
        
            return new TrainingDTO(training);

        }

        public TrainingDTO GetTrainingFinish()
        {
            throw new NotImplementedException();
        }

        public TrainingDTO GetTrainingProgress()
        {
            throw new NotImplementedException();
        }

        // Função de suspensão de treinamento
        public void Suspend(string nameOrId)
        {
            
            // Obtem o treinamento pelo nome ou id
            Training training = GetByNameOrId(nameOrId);

            // Verifica se algum aluno está matriculado no treinamento
            if (_registrationRepository.GetAll().AsQueryable().Any(t => t.TrainingId == training.Id))
            {
                // O treinamento não pode ser suspenso se um aluno estiver matriculado nele, então é enviado um erro de bad request para o tratamento
                throw new BadRequestException("O treinamento não pode ser suspenso pois possui ao menos um aluno matriculado");
            }

            // Realizando a suspensão do treinamento que é equivalente a mudança de status do mesmo para false
            training.Active = false;
            _trainingRepository.Update(training);
        }
        public int Insert(TrainingDTO training)
        {
            if (_trainingRepository.VerifyExistingName(training.Title))
            {
                throw new AlreadyExistsException($"Já existe um treinamento com o nome: {training.Title}");
            }
            
            _trainingRepository.Insert(new Training(training));
            var newTraining = _trainingRepository.GetByName(training.Title);
            return newTraining.Id;
        }

        public IList<TrainingDTO> GetTrainingsByUser(int userId)
        {
            var trainingWithRegisters = _registrationRepository.GetRegistrationsByUser(userId);
            var trainingsByUser = trainingWithRegisters.Select(r => new TrainingDTO(r.Training)).ToList();

            return trainingsByUser;
        }

        // Função que procura treinamento pelo nome ou id inserido
        public Training GetByNameOrId(string nameOrId)
        {

            // Obtem o primeiro treinamento com o nome entregue na rota
            Training training = _trainingRepository.GetByName(nameOrId);

            // Verifica se o treinamento foi encontrado com o nome
            if (training == null)
            {

                // Tenta converter a variavel que contia o nome para um inteiro
                int id;
                if (Int32.TryParse(nameOrId, out id))
                {

                    // Se a conversão for possivel, obtem o primeiro treinamento com o id inserido na rota
                    training = _trainingRepository.GetById(id);

                    // Verifica se o treinamento foi encontrado com o id
                    if (training == null)
                    {
                        // Envia uma exceção pois o treinamento não foi encontrado
                        throw new BadRequestException("Treinamento não encontrado.");
                    }
                }
                else
                {
                    // Se a conversão para id não foi possível, retorna uma exceção que o treinamento não foi encontrado.
                    throw new BadRequestException("Treinamento não encontrado.");
                }
            }

            return training;
        }
    }
}