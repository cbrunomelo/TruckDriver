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

                string campos = MontarCampos(entity, map);
                string values = MontarValues(entity, map);
                

                string sql = $"INSERT INTO [{map["TABLE"]}] ({campos}) VALUES ({values}); SELECT last_insert_rowid();";
                SqliteCommand command = new SqliteCommand(sql, connection);

                AdicionarParametros(entity, map, command);


                long idInserido = (long)command.ExecuteScalar();

                connection.Close();

                return (int)idInserido;

            }
        }

        private void AdicionarParametros(TEntity entity, IDictionary<string, string> map, SqliteCommand command)
        {
            int i = 1;
            foreach (var prop in entity.GetType().GetProperties())
            {
                if (map.ContainsKey(prop.Name))
                {
                    command.Parameters.AddWithValue($"@valor{i}", prop.GetValue(entity) ?? DBNull.Value);
                    i++;
                }
            }
        }

        private string MontarValues(TEntity entity, IDictionary<string, string> map)
        {
            StringBuilder valoresBuilder = new StringBuilder();
            int i = 1;
            foreach (var prop in entity.GetType().GetProperties())
            {
                if (map.ContainsKey(prop.Name))
                {
                    valoresBuilder.Append($"@valor{i}, ");
                    i++;
                }
            }
            return valoresBuilder.ToString().TrimEnd(' ', ',');
        }

        private string MontarCampos(TEntity entity, IDictionary<string, string> map)
        {
            StringBuilder campos = new StringBuilder();

            foreach (var prop in entity.GetType().GetProperties())
            {
                if (map.ContainsKey(prop.Name))
                    campos.Append(map[prop.Name] + ", ");
            }
            return campos.ToString().TrimEnd(',', ' ');

        }
    }
}
