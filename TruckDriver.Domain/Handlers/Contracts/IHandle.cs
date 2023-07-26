using TruckDriver.Domain.Commands.Contracts;

namespace TruckDriver.Domain.Handlers.Contracts
{
    public interface IHandle<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}
