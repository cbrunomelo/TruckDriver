using TruckDriver.Domain.Commands.UserCommands;

namespace TruckDriver.Domain.Handlers.Contracts
{
    public interface IUserHandle : IHandle<CreateUserCommand>, IHandle<UpdateUserCommand>, IHandle<DeleteUserCommand>
    {

    }
}
