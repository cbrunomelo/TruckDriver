using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Domain.Entitys.PedidosState
{
    public interface IPedidoStatus
    {
        IPedidoStatus AvancarStatus();
        IPedidoStatus VoltarStatus();
        EStatus GetStatus();

    }
}
