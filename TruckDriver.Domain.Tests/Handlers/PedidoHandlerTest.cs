using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.EnderecoCommands;
using TruckDriver.Domain.Commands.PedidosCommands;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Handlers;
using TruckDriver.Domain.MessageConstants;
using TruckDriver.Domain.Repository;
using TruckDriver.Domain.Services;

namespace TruckDriver.Domain.Tests.Handlers
{
    public class PedidoHandlerTest
    {
        private readonly Mock<IPedidoRepository> _PedidorepositoryMock = new();
        private readonly Mock<EnderecoHandler> _enderecoHandlerMock =new();
        private readonly Mock<ICepService> _cepServiceMock = new();
        private PedidoHandler GetHandler() => new PedidoHandler(_PedidorepositoryMock.Object, _cepServiceMock.Object, _enderecoHandlerMock.Object);
        


        [Fact]
        public void CreatePedidoCommand_WithValidData_ReturnsSucess()
        {


            //arrange
            _enderecoHandlerMock.Setup(x => x.Handle(It.IsAny<CreateEnderecoCommand>()))
                .Returns(new GenericCommandResult(true, MessageConstant.CREATED_SUCCESSFULLY, 0));

            _cepServiceMock.Setup(x => x.CalcularDistancia(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(100);

            _PedidorepositoryMock.Setup(x => x.Creat(It.IsAny<Pedido>()))
                .Returns(2);

            CreatePedidoCommand validCommand = new CreatePedidoCommand()
            {
                Endereco_coleta = new CreateEnderecoCommand()
                {
                    Cep = "59622-140",
                    Cidade = "São Paulo",
                    Complemento = "Casa",
                    Estado = "SP",
                    Logradouro = "Rua 1",
                },
                Endereco_entrega = new CreateEnderecoCommand()
                {
                    Cep = "69093-189",
                    Cidade = "São Paulo",
                    Complemento = "Casa",
                    Estado = "SP",
                    Logradouro = "Rua 1",

                }
            };

            var handler = GetHandler();


            //act

            var result = (GenericCommandResult)handler.Handle(validCommand);

            //assert
            Assert.True(result.Success);

        }

    }
}
