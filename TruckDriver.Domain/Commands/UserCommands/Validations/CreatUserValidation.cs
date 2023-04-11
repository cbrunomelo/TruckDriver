﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys;

namespace TruckDriver.Domain.Commands.UserCommands.Validations
{
    public class CreatUserValidation : AbstractValidator<CreateUserCommand>
    {
        public CreatUserValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Nome nao pode ser vazio");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Senha nao pode ser vazia");
        }
    }
}
