using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Domain.Commands.EnderecoCommands
{
    public class CreateEnderecoCommand
    {
        public CreateEnderecoCommand() { }


        public string Cep;

        public string logradouro;

        public string complemento;

        public string bairro;

        public string cidade;

        public string estado;
    }
}
