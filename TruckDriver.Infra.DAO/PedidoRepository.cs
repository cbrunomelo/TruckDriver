using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Infra.ADO
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly RepositoryBase<Pedido> _repositoryBase;
        public PedidoRepository(RepositoryBase<Pedido> repositoryBase)
        {
            _repositoryBase = repositoryBase;
            
        }
        public int Creat(Pedido entity)
        {
            return _repositoryBase.Creat(entity);
        }
    }
}
