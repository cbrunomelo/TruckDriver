using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys;

namespace TruckDriver.Infra.ADO.Extensions.Wrappers
{
    internal class PedidoWrapper : Wrapper
    {
        private IDictionary<string, string> _map;

        public PedidoWrapper()
        {
            _map = new Dictionary<string, string>();
        }
        public override IDictionary<string, string> Delete()
        {
            throw new NotImplementedException();
        }

        public override IDictionary<string, string> Insert()
        {
            _map.Add(TABLE, "Pedido");
            _map.Add(nameof(Pedido.DistanciaKM), "DistanciaKM");;
            _map.Add(nameof(Pedido.Preco), "Preco");
            _map.Add(nameof(Pedido.CriadoEm), "CriadoEm");
            _map.Add(nameof(Pedido.Previsao), "Previsao");
            _map.Add(nameof(Pedido.UltimaAtualizacao), "UltimaAtualizacao");
            _map.Add(nameof(Pedido.Status), "Status");
            _map.Add(nameof(Pedido.Fk_Coleta_EnderecoId), "FK_coleta_EnderecoId");
            _map.Add(nameof(Pedido.Fk_Destino_EnderecoId), "Fk_Destino_EnderecoId");
            _map.Add(nameof(Pedido.Fk_MotoristaId), "Fk_MotoristaId");

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
