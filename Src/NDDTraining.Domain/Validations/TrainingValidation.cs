using FluentValidation;
using NDDTraining.Domain.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDTraining.Domain.Validations
{
    public class TrainingValidation : AbstractValidator<TrainingDTO>
    {
        public TrainingValidation() 
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("Campo deve estar preenchido");
        }


    }
}
