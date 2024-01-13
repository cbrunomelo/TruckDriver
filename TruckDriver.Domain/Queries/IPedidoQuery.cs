using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TruckDriver.Domain.Entitys;

namespace TruckDriver.Domain.Queries
{
    public interface IPedidoQuery
    {
        IEnumerable<Pedido> Get();

        IEnumerable<Pedido> Get(int skip, int take);

        IEnumerable<Pedido> Get(string filtroNome, string filtroStatus);

        IEnumerable<Pedido> Get(int skip, int take, string filtroNome, string filtroStatus);

        int QuantidadeDePedidos();

        int QuantidadeDePedidos(string filtroNome, string filtroStatus);
    }
}
