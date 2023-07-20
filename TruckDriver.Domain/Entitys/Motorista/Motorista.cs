using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys.MotoristaState;

namespace TruckDriver.Domain.Entitys
{
    public class Motorista : Entity
    {
        public override string TABLE_NAME { get => "Motorista"; set => base.TABLE_NAME = value; }

        public Motorista(string name, string sobrenome, string cpf, string cnh, string telefone, int Fk_enderecoId)
        {            
            Nome = name;
            Sobrenome = sobrenome;
            this.cpf = cpf;
            this.cnh = cnh;
            this.telefone = telefone;
            this.Fk_enderecoId = Fk_enderecoId;
            _status = EStatus.DISPONIVEL;
        }

        public int Id { get; private set; } = 0;

        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public string cpf { get; private set; }

        public string cnh { get; private set; }

        public string telefone { get; private set; }

        public int Fk_enderecoId { get; private set; }

        private EStatus _status { get; set; }

        public string Status { get => _status.ToString(); }
    }
}
