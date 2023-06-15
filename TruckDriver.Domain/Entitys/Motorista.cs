using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Domain.Entitys
{
    public class Motorista
    {
        public Motorista(int id, string name, string sobrenome, string cpf, int cnh, int telefone)
        {
            Id = id;
            Name = name;
            Sobrenome = sobrenome;
            this.cpf = cpf;
            this.cnh = cnh;
            this.telefone = telefone;
        }

        public Motorista()
        {
            
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Sobrenome { get; set; }

        public string cpf { get; set; }

        public int cnh { get; set; }

        public int telefone { get; set; }
    }
}
