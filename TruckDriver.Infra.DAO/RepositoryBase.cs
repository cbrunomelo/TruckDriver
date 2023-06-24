using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Repository;
using TruckDriver.Infra.DAO;

namespace TruckDriver.Infra.ADO
{
    public class RepositoryBase<TEntity> : IRepository where TEntity : Entity
    {
        public readonly string connectionString = ConnectionString.Get();


        public int Creat(TEntity entity)
        {
            using (var connection = new SqliteConnection(connectionString))
            {

                try
                {
                    connection.Open();

                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        Console.WriteLine("Conexão com o banco de dados estabelecida com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível conectar ao banco de dados.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao conectar ao banco de dados: " + ex.Message);
                }


                string propNames = "";
                string values = "";
                int i = 1;

                foreach (var prop in entity.GetType().GetProperties())
                {
                    if (prop.Name == "TABLE_NAME" || (prop.Name.ToLower().EndsWith("id") && !prop.Name.ToLower().Contains("fk")))
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
                    if (prop.Name == "TABLE_NAME" || (prop.Name.ToLower().EndsWith("id") && !prop.Name.ToLower().Contains("fk")))
                        continue;
                    command.Parameters.AddWithValue($"valor{i}", prop.GetValue(entity));
                    i++;
                }


                long idInserido = (long)command.ExecuteScalar();

                connection.Close();

                return (int)idInserido;

            }
        }
    }
}
