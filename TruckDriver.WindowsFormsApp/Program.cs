using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckDriver.Domain.Queries;
using TruckDriver.IoC;
using TruckDriver.WindowsFormsApp.Formularios;
using TruckDriver.WindowsFormsApp.Formularios.Login;
using TruckDriver.WindowsFormsApp.Services;

namespace TruckDriver.WindowsFormsApp
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContainer.ConfigureContainer();

            Application.Run(new frm_Login());

        }
    }
}
