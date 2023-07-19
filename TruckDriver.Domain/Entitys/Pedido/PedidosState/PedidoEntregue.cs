using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Domain.Entitys.PedidosState
{
    public class PedidoEntregue : IPedidoStatus
    {
        public IPedidoStatus AvancarStatus()
        {
            return new PedidoEntregue();
        }

        public IPedidoStatus VoltarStatus()
        {
            return new PedidoEmTransito();
        }

        public EStatus GetStatus()
        {
            return EStatus.Entregue;
        }
    }
}
