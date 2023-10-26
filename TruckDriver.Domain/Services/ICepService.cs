using System.Collections.Generic;
using System.Threading.Tasks;
using TruckDriver.Domain.Entitys;

namespace TruckDriver.Domain.Services
{
    public interface ICepService
    {

        Task<double> CalcularDistancia(Endereco EnderecoColeta, Endereco EnderecoDestino);

        Task<Endereco> BuscaEnderecoPorCep(string CEP);

    }
}