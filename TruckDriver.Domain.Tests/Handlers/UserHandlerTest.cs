using Moq;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.UserCommands;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Handlers;
using TruckDriver.Domain.Repository;
using TruckDriver.Domain.Tests.Handlers.MemberData;

namespace TruckDriver.Domain.Tests.Handlers
{
    public class UserHandlerTest
    {
        private readonly Mock<IUserRepository> _UserRepositoryMock = new();

        private UserHandler GetHandler() => new UserHandler(_UserRepositoryMock.Object, null);    

        [Fact]
        public async void CreateUserCommand_WithValidData_ReturnsSucess()
        {
            //arrange

            CreateUserCommand validCommand = new CreateUserCommand();
            
            validCommand.Name = "Teste";
            validCommand.Password = "123456";
            validCommand.RepeatPassword = "123456";

            _UserRepositoryMock.Setup(x => x.Creat(It.IsAny<User>()))
                .Returns(2);

            var _handler = GetHandler();

            //act
            ICommandResult result = await _handler.Handle(validCommand);


            //assert

            Assert.True(result.Success);
            _UserRepositoryMock.Verify(x => x.Creat(It.IsAny<User>()), Times.Once);
            
        }

        [Theory]
        [MemberData(nameof(InvalidCreateUserCommand.MemberData), MemberType = typeof(InvalidCreateUserCommand))]
        
        public async void CreateUserCommand_WithInvalidData_ReturnsError(CreateUserCommand command, string expectedMessage, IEnumerable<String> expectedError)
        {
            //arrange

            _UserRepositoryMock.Setup(x => x.Creat(It.IsAny<User>()))
                .Returns(2);

            var _handler = GetHandler();

            //act
            ICommandResult result = await _handler.Handle(command);

            //assert
            
            Assert.Equal(expectedMessage, result.Message);
            Assert.Equal(expectedError, result.Erros);








        }

    }
}
