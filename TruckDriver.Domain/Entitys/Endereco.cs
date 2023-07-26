using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Domain.Entitys
{
    public sealed class Endereco : Entity
    {
        public override string TABLE_NAME { get => "Endereco"; set => base.TABLE_NAME = value; }


        public int Id { get; internal set; }

        public string Cep { get; private set; }

        public string Logradouro { get; private set; }

        public string Complemento { get; private set; }

        public string Bairro { get; private set; }

        public string Cidade { get; private set; }

        public string Estado { get; private set; }

        public Endereco(string cep, string logradouro, string complemento, string bairro, string cidade, string estado)
        {            
            Cep = cep;
            this.Logradouro = logradouro;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
        }

        public Endereco(int id, string cep, string logradouro, string complemento, string bairro, string cidade, string estado)
        {
            this.Id = id;
            this.Cep = cep;
            this.Logradouro = logradouro;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
        }
    }
}
