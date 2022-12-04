using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NDDTraining.Domain.Validations;
using FluentValidation.TestHelper;
using NDDTraining.Domain.DTOS;

namespace NDDTrainig.Test.RegistrationsTestUnit
{
    [TestFixture]
    public class RegistrationsTestUnit
    {

        private RegistrationsValidation validator;
        [SetUp]
        public void Setup()
        {
            validator = new RegistrationsValidation();
        }

        //Teste Inserindo Id (É para dar certo)
        [TestCase(1)]
        public void Validate_ID_in_TrainingDto_Acept(int id)
        {
            var Registration = new RegistrationDTO { Id = id };
            var result = validator.TestValidate(Registration);
            result.ShouldNotHaveValidationErrorFor(registration => registration.Id);
        }

        //Teste Não Inserindo Id (É para dar errado)
        [TestCase()]
        public void Validate_ID_in_TrainingDto_Not_Acept(int id)
        {
            var Registration = new RegistrationDTO { Id = id };
            var result = validator.TestValidate(Registration);
            result.ShouldNotHaveValidationErrorFor(registration => registration.Id);
        }

        //Teste Inserindo UserId (É para dar certo)
        [TestCase(1)]
        public void Validate_UserID_in_TrainingDto_Acept(int userid)
        {
            var Registration = new RegistrationDTO { UserId = userid };
            var result = validator.TestValidate(Registration);
            result.ShouldNotHaveValidationErrorFor(registration => registration.UserId);
        }

        //Teste Não Inserindo UserId (É para dar errado)
        [TestCase()]
        public void Validate_UserID_in_TrainingDto_Not_Acept(int userId)
        {
            var Registration = new RegistrationDTO { UserId = userId };
            var result = validator.TestValidate(Registration);
            result.ShouldNotHaveValidationErrorFor(registration => registration.UserId);
        }

        //Teste Inserindo TrainingId (É para dar certo)
        [TestCase(1)]
        public void Validate_TrainingID_in_TrainingDto_Acept(int trainingId)
        {
            var Registration = new RegistrationDTO { TrainingId = trainingId };
            var result = validator.TestValidate(Registration);
            result.ShouldNotHaveValidationErrorFor(registration => registration.TrainingId);
        }

        //Teste Não Inserindo TrainingId (É para dar errado)
        [TestCase()]
        public void Validate_TrainingID_in_TrainingDto_Not_Acept(int trainingId)
        {
            var Registration = new RegistrationDTO { TrainingId = trainingId };
            var result = validator.TestValidate(Registration);
            result.ShouldNotHaveValidationErrorFor(registration => registration.TrainingId);
        }

    }
}
