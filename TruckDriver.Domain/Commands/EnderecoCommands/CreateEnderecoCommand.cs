using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands.Contracts;

namespace TruckDriver.Domain.Commands.EnderecoCommands
{
    public class CreateEnderecoCommand : ICommand
    {
        public CreateEnderecoCommand() { }


        public string Cep;

        public string Logradouro;

        public string Complemento;

        public string Bairro;

        public string Cidade;

        public string Estado;
    }
}
