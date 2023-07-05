using System.Data;

namespace TruckDriver.Domain.Queries
{
    public interface IMotoristaQuery
    {
        DataTable GetMotoristas(int skip, int take);

        int QuantidadeDeMotoristas();
    }
}
