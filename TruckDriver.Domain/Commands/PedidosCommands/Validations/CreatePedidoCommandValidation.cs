using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.MessageConstants;

namespace TruckDriver.Domain.Commands.PedidosCommands.Validations
{
    public class CreatePedidoCommandValidation : AbstractValidator<CreatePedidoCommand>
    {                
        public CreatePedidoCommandValidation()
        {
            RuleFor(c => c.Endereco_coleta)
                .NotNull()
                .WithMessage(MessageConstant.DELIVERY_ADDRESS_CANNOT_BE_EMPTY);

            RuleFor(c => c.Endereco_entrega)
                .NotNull()
                .WithMessage(MessageConstant.PICKUP_ADDRESS_CANNOT_BE_EMPTY);
        }
    }
}
