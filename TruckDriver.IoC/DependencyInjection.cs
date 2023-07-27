using Microsoft.Extensions.DependencyInjection;
using TruckDriver.Domain.Handlers;
using TruckDriver.Domain.Handlers.Contracts;
using TruckDriver.Domain.Queries;
using TruckDriver.Domain.Repository;
using TruckDriver.Infra.ADO;
using TruckDriver.Infra.DAO;

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

            return services;
        }
    }
}
