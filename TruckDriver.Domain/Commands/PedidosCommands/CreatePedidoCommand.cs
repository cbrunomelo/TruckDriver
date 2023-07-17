using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands.EnderecoCommands;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Entitys.PedidosState;

namespace TruckDriver.Domain.Commands.PedidosCommands
{
    public class CreatePedidoCommand
    {
        public CreatePedidoCommand() { }


        public CreateEnderecoCommand Endereco_coleta { get; set; }

        public CreateEnderecoCommand Endereco_entrega { get; set; }

    }
}
