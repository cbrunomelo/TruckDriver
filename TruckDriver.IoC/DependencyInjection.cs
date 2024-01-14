using Microsoft.Extensions.DependencyInjection;
using TruckDriver.Domain.Handlers;
using TruckDriver.Domain.Handlers.Contracts;
using TruckDriver.Domain.Queries;
using TruckDriver.Domain.Repository;
using TruckDriver.Domain.Services;
using TruckDriver.Infra.ADO;
using TruckDriver.Infra.DAO;
using TruckDriver.Services.CepService;

namespace TruckDriver.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastrutura(this IServiceCollection services)
        {
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IUserQuery, UserRepository>();
            services.AddScoped<IUserHandle, UserHandler>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IMotoristaHandle, MotoristaHandler>();
            services.AddTransient<ICepService, CepService>();
            services.AddScoped<IMotoristaRepository, MotoristaRepository>();
            services.AddScoped<IEnderecoHandle, EnderecoHandler>();
            services.AddScoped<IEnderecoQuery, EnderecoRepository>();
            services.AddScoped<IPedidoQuery, PedidoRepository>();
            services.AddScoped<IMotoristaQuery, MotoristaRepository>();

            services.AddScoped<IPedidoQuery, PedidoRepository>(provider =>
            {
                // Resolução das dependências do construtor
                var enderecoQuery = provider.GetRequiredService<IEnderecoQuery>();
                var motoristaQuery = provider.GetRequiredService<IMotoristaQuery>();

                // Criação e retorno da instância com as dependências
                return new PedidoRepository(enderecoQuery, motoristaQuery);
            });


            return services;
        }
    }
}
