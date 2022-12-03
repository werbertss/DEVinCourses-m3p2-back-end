using FluentValidation;
using NDDTraining.Domain.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NDDTraining.Domain.Validations
{
    public class RegistrationsValidation : AbstractValidator<RegistrationDTO>
    {
        public RegistrationsValidation() 
        {
            RuleFor(x => x.Id)
               .NotNull()
               .NotEmpty()
               .WithMessage("Campo deve estar preenchido com o Id");

            RuleFor(x => x.UserId)
               .NotNull()
               .NotEmpty()
               .WithMessage("Campo deve estar preenchido com o UserId");

            RuleFor(x => x.TrainingId)
               .NotNull()
               .NotEmpty()
               .WithMessage("Campo deve estar preenchido com o TrainingId");

            RuleFor(x => x.Status)
               .NotNull()
               .NotEmpty()
               .WithMessage("Campo deve estar preenchido com o TrainingId");
        }

    }
}
