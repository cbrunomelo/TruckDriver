using System.Linq;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.EnderecoCommands;

namespace TruckDriver.Domain.Commands.MotoristaCommands
{
    public class CreateMotoristaCommand : ICommand
    {
        public CreateMotoristaCommand()
        {
            
        }

        public CreateMotoristaCommand(string name, string sobrenome, string cpf, string cnh, string telefone)
        {
            Name = name;
            Sobrenome = sobrenome;
            this.cpf = cpf;
            this.cnh = cnh;
            this.telefone = telefone;
        }

        public string Name { get; set; }

        public CreateEnderecoCommand enderecoCommand { get; set; }

        public string Sobrenome { get; set; }

        private string _cpf;
        public string cpf
        {
            get => _cpf;
            
            set => _cpf = LimparMascara(value);
            
        }

        private string _cnh;

        public string cnh
        {
            get => _cnh;
            
            set => _cnh = LimparMascara(value);
            
        }


        private string _telefone;
        public string telefone
        {
            get => _telefone; 
            set => _telefone = LimparMascara(value);
        }



        private string LimparMascara(string str) => new string(str.Where(char.IsDigit).ToArray());

            
        
    }


}
