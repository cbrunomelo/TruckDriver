using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.EnderecoCommands;
using TruckDriver.Domain.Entitys;

namespace TruckDriver.Domain.Commands.PedidosCommands
{
    public class CreatePedidoCommand : ICommand
    {
        public CreatePedidoCommand() { }


        public CreateEnderecoCommand Endereco_coleta { get; set; }

        public CreateEnderecoCommand Endereco_entrega { get; set; }

    }
}
