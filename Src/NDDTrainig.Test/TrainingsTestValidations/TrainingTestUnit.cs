using FluentAssertions;
using NDDTraining.Domain.DTOS;
using NDDTraining.Domain.Validations;
using NUnit.Framework;
using System;
using System.Collections.Generic;
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

        [TestCase(456)]
        public void Validate_CampoPreenchido()
        {
            var result = new TrainingDTO { Id = 50 };
            Assert.IsTrue(result != null);
        }
    }

}
