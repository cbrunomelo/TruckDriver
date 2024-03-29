﻿using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys.MotoristaState;

namespace TruckDriver.Domain.Entitys
{
    public sealed class Motorista : Entity
    {
        public override string TABLE_NAME { get => "Motorista"; set => base.TABLE_NAME = value; }

        public Motorista(string name, string sobrenome, string cpf, string cnh, string telefone, int Fk_enderecoId)
        {
            Nome = name;
            Sobrenome = sobrenome;
            this.Cpf = cpf;
            this.Cnh = cnh;
            this.Telefone = telefone;
            this.Fk_enderecoId = Fk_enderecoId;
            _status = EStatus.DISPONIVEL;
        }

        public Motorista(int id, string name, string sobrenome, string cpf, string cnh, string telefone,
            string status,int Fk_enderecoId)
        {
            Id = id;
            Nome = name;
            Sobrenome = sobrenome;
            this.Cpf = cpf;
            this.Cnh = cnh;
            this.Telefone = telefone;
            this.Fk_enderecoId = Fk_enderecoId;
            _status = (EStatus)Enum.Parse(typeof(EStatus), status);
        }

        public int Id { get; private set; } = 0;

        public string Nome { get; private set; }

        public string Sobrenome { get; private set; }

        public string Cpf { get; private set; }

        public string Cnh { get; private set; }

        public string Telefone { get; private set; }

        public int Fk_enderecoId { get; private set; }

        private IEnumerable<Pedido> _pedidos { get; set; }

        private EStatus _status { get; set; }

        public string Status { get => _status.ToString(); }


        public override string ToString()
        {
            return Nome.ToString();
        }

    }
}
