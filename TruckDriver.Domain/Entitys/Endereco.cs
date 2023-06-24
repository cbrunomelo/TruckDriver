using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Domain.Entitys
{
    public class Endereco : Entity
    {
        public override string TABLE_NAME { get => "Endereco"; set => base.TABLE_NAME = value; }


        public int Fk_motorista_id { get; set; }

        public string Cep { get; set; }

        public string logradouro { get; set; }

        public string complemento { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }

        public Endereco(int fk_motorista_id, string cep, string logradouro, string complemento, string bairro, string cidade, string estado)
        {
            Fk_motorista_id = fk_motorista_id;
            Cep = cep;
            this.logradouro = logradouro;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
        }
    }
}
