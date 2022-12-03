using NUnit.Framework;

using FluentAssertions;
using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Validations;
using FluentValidation.TestHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDTrainig.Test.TrainingsTestValidations
{
    [TestFixture]
    public class TrainingTestUnit
    {
        private TrainingValidation validador;
        [SetUp]
        public void Setup()
        {
            validador = new TrainingValidation();
        }

        //Teste Inserindo Id (É para dar certo)
        [TestCase(1)]
        public void Validate_ID_in_TrainingDto_Acept(int id)
        {
            var Training = new TrainingDTO { Id = id};
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Id);
        }

        //Teste sem inserir Id (É para dar errado)
        [TestCase()]
        public void Validate_Error_ID_in_TrainingDto_Not_Acept(int id)
        {
            var Training = new TrainingDTO { Id = id };
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Id);
        }

        //Teste Inserindo Descrição (É para dar certo)
        [TestCase("Inserindo algo")]
        public void Validate_Description_in_TrainingDto_Acept(string description)
        {
            var Training = new TrainingDTO { Description = description };
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Description);
        }

        //Teste Não Inserindo Descrição (É para dar errado)
        [TestCase("")]
        public void Validate_Description_in_TrainingDto_Not_Acept(string description)
        {
            var Training = new TrainingDTO { Description = description };
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Description);
        }

        //Teste Inserindo Url (É para dar certo)
        [TestCase("urlteste")]
        public void Validate_Url_in_TrainingDto_Acept(string url)
        {
            var Training = new TrainingDTO { Url = url};
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Url);
        }

        //Teste Não Inserindo Url (É para dar errado)
        [TestCase("")]
        public void Validate_Url_in_TrainingDto_Not_Acept(string url)
        {
            var Training = new TrainingDTO { Url = url };
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Url);
        }

        //Teste Inserindo Title (É para dar certo)
        [TestCase("Meu titulo")]
        public void Validate_Title_in_TrainingDto_Acept(string title)
        {
            var Training = new TrainingDTO { Title = title };
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Title);
        }

        //Teste Não Inserindo Title (É para dar errado)
        [TestCase("")]
        public void Validate_Title_in_TrainingDto_Not_Acept(string title)
        {
            var Training = new TrainingDTO { Title = title };
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Title);
        }

        //Teste Inserindo Teacher (É para dar certo)
        [TestCase("Gabriel")]
        public void Validate_Teacher_in_TrainingDto_Acept(string teacher)
        {
            var Training = new TrainingDTO { Teacher = teacher };
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Teacher);
        }

        //Teste Não Inserindo Teacher (É para dar errado)
        [TestCase("")]
        public void Validate_Teacher_in_TrainingDto_Not_Acept(string teacher)
        {
            var Training = new TrainingDTO { Teacher = teacher };
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Teacher);
        }

        //Teste verificando propriedade Active, aceita apenas true ou false (É para dar certo)
        [TestCase("true")]
        public void Validate_ActiveTrue_in_TrainingDto_FalseOrTrue(bool active)
        {
            var Training = new TrainingDTO { Active = active };
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Active);
        }

        //Teste verificando propriedade Active, aceita apenas true ou false (É para dar certo)
        [TestCase("false")]
        public void Validate_ActiveFalse_in_TrainingDto_FalseOrTrue(bool active)
        {
            var Training = new TrainingDTO { Active = active };
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Active);
        }

        //Teste verificando propriedade Active, inserindo outras palavras, aceita apenas true ou false (É para dar errado)
        [TestCase("qualquer")]
        public void Validate_ActiveInserindoQualquer_in_TrainingDto_FalseOrTrue(bool active)
        {
            var Training = new TrainingDTO { Active = active };
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Active);
        }

        //Teste verificando propriedade Active, inserindo nada(null), aceita apenas true ou false (É para dar errado)
        [TestCase("")]
        public void Validate_ActiveNull_in_TrainingDto_FalseOrTrue(bool active)
        {
            var Training = new TrainingDTO { Active = active };
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Active);
        }

        //Teste Inserindo Category (É para dar certo)
        [TestCase("Marketing")]
        public void Validate_Category_in_TrainingDto_Acept(string category)
        {
            var Training = new TrainingDTO { Category = category };
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Category);
        }

        //Teste Não Inserindo Category (É para dar errado)
        [TestCase("")]
        public void Validate_Category_in_TrainingDto_Not_Acept(string category)
        {
            var Training = new TrainingDTO { Category = category };
            var result = validador.TestValidate(Training);
            result.ShouldNotHaveValidationErrorFor(training => training.Category);
        }


    }

}
