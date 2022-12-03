using FluentValidation;
using NDDTraining.Domain.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDDTraining.Domain.Validations
{
    public class TrainingActivityValidation : AbstractValidator<TrainingActivityDTO>
    {
        public TrainingActivityValidation() 
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("Campo deve estar preenchido com Id");

            RuleFor(x => x.Title)
               .NotNull()
               .Length(5, 100).WithMessage("O titulo deve ter no minimo 5 caracters e no maximo 100!");

            RuleFor(x => x.Description)
               .NotNull()
               .Length(5, 200).WithMessage("A descrição deve ter no minimo 5 caracters e no maximo 200!");
        }
    }
}
