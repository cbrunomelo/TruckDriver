using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.PedidosCommands;

namespace TruckDriver.Domain.Handlers.Contracts
{
    public interface IPedidoHandle : IHandle<CreatePedidoCommand>, IHandle<UpdatePedidoCommand>, IHandle<DeletePedidoCommand>
    {        
        
    }
}
