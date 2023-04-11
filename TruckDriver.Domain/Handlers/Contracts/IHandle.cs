using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands.Contracts;

namespace TruckDriver.Domain.Handlers.Contracts
{
    internal interface IHandle<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
