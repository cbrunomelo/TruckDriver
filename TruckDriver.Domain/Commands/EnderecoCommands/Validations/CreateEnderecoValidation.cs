using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands.MotoristaCommands;

namespace TruckDriver.Domain.Commands.EnderecoCommands.Validations
{
    internal class CreateEnderecoValidation : AbstractValidator<CreateEnderecoCommand>
    {
        public CreateEnderecoValidation() 
        { 

        }
    }
}
