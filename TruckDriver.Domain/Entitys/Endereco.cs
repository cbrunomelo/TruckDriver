using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Domain.Entitys
{
    public class Endereco : Entity
    {
        public override string TABLE_NAME { get => "Endereco"; set => base.TABLE_NAME = value; }


        public int Id { get; set; }

        public string Cep { get; set; }

        public string logradouro { get; set; }

        public string complemento { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public Endereco(string cep, string logradouro, string complemento, string bairro, string cidade, string estado)
        {            
            Cep = cep;
            this.logradouro = logradouro;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
        }
    }
}
