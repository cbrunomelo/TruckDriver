using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Infra.ADO
{
    public class MotoristaRepository : IMotoristaRepository
    {
        private readonly RepositoryBase<Motorista> _repository;
        public MotoristaRepository()
        {
            _repository = new RepositoryBase<Motorista>();
        }

        public int Creat(Motorista motorista)
        {
            return _repository.Creat(motorista);
        }
    }
}
