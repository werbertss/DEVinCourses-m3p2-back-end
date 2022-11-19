using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using NDDTraining.Domain.DTOS;

namespace NDDTraining.Domain.Validations
{
    public class UserValidation : AbstractValidator<UserDTO>
    {
        public UserValidation()
        {
            RuleFor(x => x.Age)
                .NotEmpty()
                .WithMessage("Campo não pode ser vazio")
                .GreaterThan(18)
                .WithMessage("idade não pode ser menor que 18");
                
        }
    }
}
