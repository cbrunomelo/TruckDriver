using TruckDriver.Domain.Commands.MotoristaCommands;

namespace TruckDriver.Domain.Handlers.Contracts
{
    public interface IMotoristaHandle : IHandle<CreateMotoristaCommand>, IHandle<UpdateMotoristaCommand>, IHandle<DeleteMotoristaCommand>
    {
    }
}
