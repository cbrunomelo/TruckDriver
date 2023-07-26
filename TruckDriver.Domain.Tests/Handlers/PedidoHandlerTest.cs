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
using TruckDriver.Domain.Handlers.Contracts;
using TruckDriver.Domain.MessageConstants;
using TruckDriver.Domain.Repository;
using TruckDriver.Domain.Services;
using TruckDriver.Domain.Tests.Handlers.MemberData;

namespace TruckDriver.Domain.Tests.Handlers
{
    public class PedidoHandlerTest
    {
        private readonly Mock<IPedidoRepository> _PedidorepositoryMock = new();
        private readonly Mock<IEnderecoHandle> _enderecoHandlerMock =new();
        private readonly Mock<ICepService> _cepServiceMock = new();
        private PedidoHandler GetHandler() => new PedidoHandler(_PedidorepositoryMock.Object, _cepServiceMock.Object, _enderecoHandlerMock.Object);
        


        [Theory]

        [MemberData(nameof(ValidCreatePedidoCommand.MemberData), MemberType = typeof(ValidCreatePedidoCommand))]
        public void CreatePedidoCommand_WithValidData_ReturnsSucess(CreatePedidoCommand pedidoCommand, string expectedMessage)
        {


            //arrange
            CreateEnderecoCommand validEnderecoColata = pedidoCommand.Endereco_coleta;
            CreateEnderecoCommand validEnderecoEntrega = pedidoCommand.Endereco_entrega;

            Endereco enderecoColeta = new Endereco(0, validEnderecoColata.Cep, validEnderecoColata.Logradouro, validEnderecoColata.Complemento,validEnderecoColata.Bairro, validEnderecoColata.Cidade, validEnderecoColata.Estado);
            Endereco enderecoEntrega = new Endereco(1, validEnderecoEntrega.Cep, validEnderecoEntrega.Logradouro, validEnderecoEntrega.Complemento, validEnderecoEntrega.Bairro, validEnderecoEntrega.Cidade, validEnderecoEntrega.Estado);

            
            _enderecoHandlerMock.SetupSequence(x => x.Handle(It.IsAny<CreateEnderecoCommand>()))
                .Returns(new GenericCommandResult(true, MessageConstant.CREATED_SUCCESSFULLY, enderecoColeta))
                .Returns(new GenericCommandResult(true, MessageConstant.CREATED_SUCCESSFULLY, enderecoEntrega));





            _cepServiceMock.SetupSequence(x => x.CalcularDistancia(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(101);

            _PedidorepositoryMock.Setup(x => x.Creat(It.IsAny<Pedido>()))
                .Returns(2);

            CreatePedidoCommand validCommand = new CreatePedidoCommand()
            { 
                Endereco_coleta = validEnderecoColata,
                Endereco_entrega = validEnderecoEntrega,
            };

            var handler = GetHandler();


            //act

            var result = (GenericCommandResult)handler.Handle(validCommand);

            //assert
            Assert.True(result.Success);
            Assert.Equal(expectedMessage, result.Message);

        }

    }
}
