using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Repository;
using TruckDriver.Infra.DAO;

namespace TruckDriver.Infra.ADO
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        public readonly string connectionString = ConnectionString.Get();


        public int Creat(TEntity entity)
        {
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                string propNames = "";
                string values = "";
                int i = 1;

                foreach (var prop in entity.GetType().GetProperties())
                {
                    if (PropriedadeDeClassesASeremIgnoradas(prop.Name))
                        continue;
                    propNames += prop.Name + ",";
                    values += $"@valor{i}, ";
                    i++;
                }

                propNames = propNames.Substring(0, propNames.Length - 1);
                values = values.Substring(0, values.Length - 2);



                string sql = $"INSERT INTO [{entity.TABLE_NAME}] ({propNames}) VALUES ({values}); SELECT last_insert_rowid();";
                SqliteCommand command = new SqliteCommand(sql, connection);

                i = 1;
                foreach (var prop in entity.GetType().GetProperties())
                {
                    if (PropriedadeDeClassesASeremIgnoradas(prop.Name))
                        continue;
                    command.Parameters.AddWithValue($"valor{i}", prop.GetValue(entity) ?? DBNull.Value);
                    i++;
                }


                long idInserido = (long)command.ExecuteScalar();

                connection.Close();

                return (int)idInserido;

            }
        }

        private bool PropriedadeDeClassesASeremIgnoradas(string str)
        {
            if (str == "TABLE_NAME")
                return true;

            if (str.EndsWith("id", StringComparison.OrdinalIgnoreCase) && !str.StartsWith("fk", StringComparison.OrdinalIgnoreCase))
                return true;

            if (str == "Coleta_Endereco" || str == "Destino_Endereco" || str == "Motorista")
                return true;

            return false;
        }
    }
}
