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
                .NotNull()
                .NotEmpty()
                .WithMessage("Campo deve estar preenchido com Id");

            RuleFor(x => x.Description)
               .NotNull()
               .NotEmpty()
               .WithMessage("Campo deve estar preenchido com descrição");

            RuleFor(x => x.Url)
               .NotNull()
               .NotEmpty()
               .WithMessage("Campo deve estar preenchido com a Url");

            RuleFor(x => x.Title)
               .NotNull()
               .NotEmpty()
               .WithMessage("Campo deve estar preenchido com o titulo");

            RuleFor(x => x.Teacher)
               .NotNull()
               .NotEmpty()
               .WithMessage("Campo deve estar preenchido o professor");

            RuleFor(x => x.Active)
               .NotNull()
               .GetType();

            RuleFor(x => x.Category)
               .NotNull()
               .NotEmpty()
               .WithMessage("Campo deve estar preenchido o categoria");

        }

    }
}
