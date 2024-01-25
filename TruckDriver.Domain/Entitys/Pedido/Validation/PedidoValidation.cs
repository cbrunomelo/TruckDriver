using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Domain.Entitys.Validation
{
    public class PedidoValidation : AbstractValidator<Pedido>
    {        
                
        public PedidoValidation()
        {
            RuleFor(c => c.DistanciaKM)
                .LessThan(Pedido.DISTANCIA_MINIMA_KM)
                .WithMessage($"A distância mínima para um pedido é de {Pedido.DISTANCIA_MINIMA_KM} km");
        }
    }
}
