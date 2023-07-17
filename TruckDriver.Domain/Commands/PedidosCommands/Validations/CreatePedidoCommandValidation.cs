using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Domain.Commands.PedidosCommands.Validations
{
    public class CreatePedidoCommandValidation : AbstractValidator<CreatePedidoCommand>
    {
        public CreatePedidoCommandValidation()
        {
            
        }
    }
}
