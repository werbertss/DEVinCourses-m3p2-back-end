using NUnit.Framework;

using FluentAssertions;
using FluentValidation.TestHelper;
using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDTrainig.Test.TrainingActivityTestUnit
{
    [TestFixture]
    public class TrainingActivityTestUnit
    {
        private TrainingActivityValidation validator;
        [SetUp]
        public void Setup()
        {
            validator = new TrainingActivityValidation();
        }

        //Teste Inserindo Id (É para dar certo)
        [TestCase(1)]
        public void Validate_Id_in_TrainingActivityDto_Acept(int id)
        {
            var TrainingActivity = new TrainingActivityDTO { Id = id };
            var result = validator.TestValidate(TrainingActivity);
            result.ShouldNotHaveValidationErrorFor(TrainingActivity => TrainingActivity.Id);
        }

        //Teste Não Inserindo Id (É para dar errado)
        [TestCase()]
        public void Validate_Id_in_TrainingActivityDto_Not_Acept(int id)
        {
            var TrainingActivity = new TrainingActivityDTO { Id = id };
            var result = validator.TestValidate(TrainingActivity);
            result.ShouldNotHaveValidationErrorFor(trainingActivity => trainingActivity.Id);
        }

        //Teste Inserindo 5 ou mais caracters. O mesmo so aceita de 5 à 100 caracters (É para dar certo)
        [TestCase("asdfg")]
        public void Validate_Title_in_TrainingActivityDto_Acept(string title)
        {
            var TrainingActivity = new TrainingActivityDTO { Title = title };
            var result = validator.TestValidate(TrainingActivity);
            result.ShouldNotHaveValidationErrorFor(trainingActivity => trainingActivity.Title);
        }

        //Teste Inserindo menos de 5 caracters. O mesmo so aceita de 5 à 100 caracters (É para dar errado)
        [TestCase("asdf")]
        public void Validate_Title_in_TrainingActivityDto_Not_Acept(string title)
        {
            var TrainingActivity = new TrainingActivityDTO { Title = title };
            var result = validator.TestValidate(TrainingActivity);
            result.ShouldNotHaveValidationErrorFor(trainingActivity => trainingActivity.Title);
        }

        //Teste Inserindo 5 ou mais caracters. O mesmo so aceita de 5 à 200 caracters (É para dar certo)
        [TestCase("asdfg")]
        public void Validate_Description_in_TrainingActivityDto_Not_Acept(string description)
        {
            var TrainingActivity = new TrainingActivityDTO { Description = description };
            var result = validator.TestValidate(TrainingActivity);
            result.ShouldNotHaveValidationErrorFor(trainingActivity => trainingActivity.Description);
        }

        //Teste Inserindo menos de 5 caracters. O mesmo so aceita de 5 à 200 caracters (É para dar errado)
        [TestCase("asdf")]
        public void Validate_Description_in_TrainingActivityDto_Acept(string description)
        {
            var TrainingActivity = new TrainingActivityDTO { Description = description };
            var result = validator.TestValidate(TrainingActivity);
            result.ShouldNotHaveValidationErrorFor(trainingActivity => trainingActivity.Description);
        }

    }
}
