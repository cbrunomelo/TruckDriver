using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys;

namespace TruckDriver.Infra.ADO.Extensions.Wrappers
{
    internal class EnderecoWrapper : Wrapper
    {
        private IDictionary<string, string> _map;

        public EnderecoWrapper()
        {
            _map = new Dictionary<string, string>();
        }

        public override IDictionary<string, string> Delete()
        {
            throw new NotImplementedException();
        }

        public override IDictionary<string, string>  Insert()
        {
            _map.Add(TABLE, "Endereco");
            _map.Add(nameof(Endereco.Cep), "Cep");
            _map.Add(nameof(Endereco.Logradouro), "Logradouro");
            _map.Add(nameof(Endereco.Bairro), "Bairro");
            _map.Add(nameof(Endereco.Cidade), "Cidade");
            _map.Add(nameof(Endereco.Estado), "Estado");

            return _map;

        }

        public override IDictionary<string, string> Select()
        {
            throw new NotImplementedException();
        }

        public override IDictionary<string, string> Update()
        {
            throw new NotImplementedException();
        }
    }
}
