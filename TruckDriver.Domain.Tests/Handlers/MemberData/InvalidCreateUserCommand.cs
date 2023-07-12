using TruckDriver.Domain.Commands.UserCommands;
using TruckDriver.Domain.MessageConstants;
using Xunit.Sdk;

namespace TruckDriver.Domain.Tests.Handlers.MemberData
{
    internal class InvalidCreateUserCommand
    {
        public static IEnumerable<object[]> MemberData = new[]
        {
            new object[]
            {
                new CreateUserCommand
                {
                    Name = "Teste",
                    Password = "123456",
                    RepeatPassword = "1234567"
                },
                MessageConstant.UNABLE_TO_CREATE,
                new[] { MessageConstant.PASSWORDS_DO_NOT_MATCH }
            },
            new object[] 
            {
                new CreateUserCommand
                {
                    Name = string.Empty,
                    Password = "123456",
                    RepeatPassword = "123456"
                },
                MessageConstant.UNABLE_TO_CREATE,
                new[] { MessageConstant.NAME_CANNOT_BE_EMPTY }                
            }

        };




    }
}
