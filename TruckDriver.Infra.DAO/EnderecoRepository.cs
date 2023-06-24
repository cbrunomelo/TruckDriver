using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Infra.ADO
{
    public class EnderecoRepository : IEnderecoRepository
    {
        private RepositoryBase<Endereco> _repositoryBase;
        public EnderecoRepository()
        {
            _repositoryBase = new RepositoryBase<Endereco>();
        }
        public void Creat(Endereco endereco)
        {
            _repositoryBase.Creat(endereco);
        }
    }
}
