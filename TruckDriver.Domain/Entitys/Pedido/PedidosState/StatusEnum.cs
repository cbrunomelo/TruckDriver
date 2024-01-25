using System;
using System.Collections.Generic;
using System.Text;


namespace TruckDriver.Domain.Entitys.PedidosState
{

    public enum EStatus
    {
        [Entitys.PedidosState.EnumDisplayName("Pendente")]
        Pendente,

        [Entitys.PedidosState.EnumDisplayName("Aguardando Coleta")]
        AguardandoColeta,

        [Entitys.PedidosState.EnumDisplayName("Em Transito")]
        EmTransito,

        [Entitys.PedidosState.EnumDisplayName("Entregue")]
        Entregue
    }

}
