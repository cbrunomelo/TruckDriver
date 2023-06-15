using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands.MotoristaCommands.Validations.CustomValidation;

namespace TruckDriver.Domain.Commands.MotoristaCommands.Validations
{
    public class CreateMotoristaValidation : AbstractValidator<CreateMotoristaCommand>
    {
        public CreateMotoristaValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Nome nao pode ser vazio");
            RuleFor(x => x.cpf).Custom((cpf, context) =>
            {
                if (!CpfValidation.Validar(cpf))
                {
                    context.AddFailure("Cpf inválido");
                }
            });
        }
    }
}
