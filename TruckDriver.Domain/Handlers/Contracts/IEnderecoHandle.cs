using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands.EnderecoCommands;

namespace TruckDriver.Domain.Handlers.Contracts
{
    public interface IEnderecoHandle : IHandle<CreateEnderecoCommand>, IHandle<UpdateEnderecoCommand>, IHandle<DeleteEnderecoCommand>
    {
    }
}
