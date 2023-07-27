using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckDriver.IoC;

namespace TruckDriver.WindowsFormsApp.Services
{
    internal static class AppContainer
    {
        public static IServiceProvider ServiceProvider { get; private set; }

        public static void ConfigureContainer()
        {
            ServiceProvider = new ServiceCollection()
                .AddInfrastrutura()
                .BuildServiceProvider();
        }
    }
}
