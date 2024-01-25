using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Repository;
using TruckDriver.Infra.ADO.Extensions;
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
                
                var map = entity.GetMap().Insert();

                string campos = "";
                string values = "";
                int i = 1;

                foreach (var prop in entity.GetType().GetProperties())
                {
                    if (!map.ContainsKey(prop.Name))
                        continue;
                    campos += map[prop.Name] + ", ";
                    values += $"@valor{i}, ";
                    i++;
                }

                campos = campos.Substring(0, campos.Length - 2);
                values = values.Substring(0, values.Length - 2);



                string sql = $"INSERT INTO [{map["TABLE"]}] ({campos}) VALUES ({values}); SELECT last_insert_rowid();";
                SqliteCommand command = new SqliteCommand(sql, connection);

                i = 1;
                foreach (var prop in entity.GetType().GetProperties())
                {
                    if(!map.ContainsKey(prop.Name))
                        continue;
                    command.Parameters.AddWithValue($"valor{i}", prop.GetValue(entity) ?? DBNull.Value);
                    i++;
                }


                long idInserido = (long)command.ExecuteScalar();

                connection.Close();

                return (int)idInserido;

            }
        }

    }
}
