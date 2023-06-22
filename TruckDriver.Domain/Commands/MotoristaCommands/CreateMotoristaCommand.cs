using System.Linq;

namespace TruckDriver.Domain.Commands.MotoristaCommands
{
    public class CreateMotoristaCommand
    {
        public CreateMotoristaCommand()
        {
            
        }

        public CreateMotoristaCommand(string name, string sobrenome, string cpf, string cnh, string telefone)
        {
            Name = name;
            Sobrenome = sobrenome;
            this.cpf = LimparMascara(cpf);
            this.cnh = LimparMascara(cnh);
            this.telefone = LimparMascara(telefone);
        }

        public string Name { get; set; }

        public string Sobrenome { get; set; }

        private string _cpf;
        public string cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = LimparMascara(value);
            }
        }

        private string _cnh;

        public string cnh
        {
            get
            {
                return _cnh;
            }
            set
            {
                _cnh = LimparMascara(value);
            }
        }


        private string _telefone;
        public string telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                _telefone = LimparMascara(value);
            }
        }



        private string LimparMascara(string str)
        {
            str = new string(str.Where(char.IsDigit).ToArray());

            return str;
        }
    }


}
