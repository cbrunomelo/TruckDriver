using System;
using System.Collections.Generic;
using System.Text;

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
        }

        public Motorista()
        {
            
        }

        public int Id { get; set; } = 0;

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public string cpf { get; set; }

        public string cnh { get; set; }

        public string telefone { get; set; }

        public int Fk_enderecoId { get; set; }
    }
}
