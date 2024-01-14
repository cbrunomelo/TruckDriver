using System.Data;
using TruckDriver.Domain.Entitys;

namespace TruckDriver.Domain.Queries
{
    public interface IMotoristaQuery
    {
        DataTable GetMotoristas();

        DataTable GetMotoristas(int skip, int take);

        DataTable GetMotoristas(string filtroNome, string filtroStatus);

        DataTable GetMotoristas(int skip, int take, string filtroNome, string filtroStatus);

        int QuantidadeDeMotoristas();

        int QuantidadeDeMotoristas(string filtroNome, string filtroStatus);

        Motorista GetById(int id);
    }
}
