using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys;
using TruckDriver.Infra.ADO.Extensions.Wrappers;

namespace TruckDriver.Infra.ADO.Extensions
{
    internal static class DatabaseMappingExtensions
    {

        private static Dictionary<Type, Func<Wrapper>> wrapperMap = new Dictionary<Type, Func<Wrapper>>
            {
                  { typeof(Motorista), () => new MotoristaWrapper() },
                  { typeof(Pedido), () => new PedidoWrapper() },
                  { typeof(Endereco), () => new EnderecoWrapper() }
              };

        internal static Wrapper GetMap(this Entity entity)
        {
            if (wrapperMap.ContainsKey(entity.GetType()))
            {
                return wrapperMap[entity.GetType()]();
            }
            else
            {
                throw new NotImplementedException();
            }
        }   



       

    }
}
