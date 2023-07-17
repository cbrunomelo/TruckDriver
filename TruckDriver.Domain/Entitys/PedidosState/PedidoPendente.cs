using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Domain.Entitys.PedidosState
{
    public class PedidoPendente : IPedidoStatus
    {
        public IPedidoStatus AvancarStatus()
        {
            return new PedidoEmTransito();
        }

        public IPedidoStatus VoltarStatus()
        {
            return new PedidoPendente();
        }

        public EStatus GetStatus()
        {
            return EStatus.Pendente;
        }
    
        

    }
}
