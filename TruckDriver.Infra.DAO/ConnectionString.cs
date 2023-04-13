using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace TruckDriver.Infra.DAO
{
    internal class ConnectionString
    {
        private const string Db_NAME = "app.db";

        private const string DIRETORIO_DB_LOCALIZADO = "\\TruckDriver\\";
        public static string Get()
        {
            string diretorioAtual = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            int index = diretorioAtual.IndexOf(DIRETORIO_DB_LOCALIZADO);

            string connectionString = diretorioAtual.Substring(0, index + DIRETORIO_DB_LOCALIZADO.Length);


            return "Data Source = " + connectionString + Db_NAME;
        }
    }
}
