using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys.PedidosState;

namespace TruckDriver.Domain.Entitys.PedidosState
{
    internal class PedidoAguardandoColeta : IPedidoStatus
    {
        public IPedidoStatus AvancarStatus()
        {
            return new PedidoEmTransito();
        }

        public EStatus GetStatus()
        {
            return EStatus.AguardandoColeta;
        }

        public IPedidoStatus VoltarStatus()
        {
            return new PedidoPendente();
        }
    }
}
