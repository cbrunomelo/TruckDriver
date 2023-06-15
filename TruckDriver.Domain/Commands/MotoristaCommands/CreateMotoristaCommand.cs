using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Domain.Commands.MotoristaCommands
{
    public class CreateMotoristaCommand
    {
        public CreateMotoristaCommand()
        {
            
        }

        public CreateMotoristaCommand(string name, string sobrenome, string cpf, int cnh, int telefone)
        {
            Name = name;
            Sobrenome = sobrenome;
            this.cpf = cpf;
            this.cnh = cnh;
            this.telefone = telefone;
        }

        public string Name { get; set; }

        public string Sobrenome { get; set; }

        public string cpf { get; set; }

        public int cnh { get; set; }

        public int telefone { get; set; }
    }
}
