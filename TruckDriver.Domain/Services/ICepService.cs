using System.Collections.Generic;
using System.Threading.Tasks;
using TruckDriver.Domain.Entitys;

namespace TruckDriver.Domain.Services
{
    public interface ICepService
    {

        float CalcularDistancia(string cepOrigem, string cepDestino);

        Task<Endereco> BuscaCep(string CEP);

    }
}