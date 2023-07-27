using System.Threading.Tasks;
using TruckDriver.Domain.Commands.Contracts;

namespace TruckDriver.Domain.Handlers.Contracts
{
    public interface IHandle<T> where T : ICommand
    {
        Task<ICommandResult> Handle(T command);
    }
}
