using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys;

namespace TruckDriver.Infra.ADO.Extensions.Wrappers
{
    internal class MotoristaWrapper : Wrapper
    {
        private IDictionary<string, string> _map;

        public MotoristaWrapper()
        {
            _map = new Dictionary<string, string>();
        }

        public override IDictionary<string, string> Delete()
        {
            throw new NotImplementedException();
        }

        public override IDictionary<string, string> Insert()
        {
            _map.Add(TABLE, "Motorista");
            _map.Add(nameof(Motorista.Nome), "Nome");
            _map.Add(nameof(Motorista.Cpf), "Cpf");
            _map.Add(nameof(Motorista.Cnh), "Cnh");
            _map.Add(nameof(Motorista.Status), "Status");

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
