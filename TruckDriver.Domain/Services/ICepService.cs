namespace TruckDriver.Domain.Services
{
    public interface ICepService
    {

        float CalcularDistancia(string cepOrigem, string cepDestino);

    }
}