using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckDriver.Domain.Commands.EnderecoCommands;
using TruckDriver.Domain.Commands.PedidosCommands;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.MessageConstants;

namespace TruckDriver.Domain.Tests.Handlers.MemberData
{
    internal class ValidCreatePedidoCommand
    {
        public static IEnumerable<Object[]> MemberData = new[]
        {
            new object[]
            {
                new CreatePedidoCommand
                {
                    Endereco_coleta = new CreateEnderecoCommand(){
                                                    Cep = "59622-140",
                                                    Cidade = "São Paulo",
                                                    Complemento = "Casa",
                                                    Estado = "SP",
                                                    Logradouro = "Rua 1",
                                                    Bairro = "Mossoró"},
                    Endereco_entrega = new CreateEnderecoCommand(){
                                                    Cep = "69093-189",
                                                    Cidade = "São Paulo",
                                                    Complemento = "Casa",
                                                    Estado = "SP",
                                                    Logradouro = "Rua 1",
                                                    Bairro = "Mossoró"}
                },
                MessageConstant.CREATED_SUCCESSFULLY
            }
        };
    }
}
