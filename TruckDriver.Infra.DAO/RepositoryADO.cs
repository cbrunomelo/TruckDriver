using System;
using System.IO;
using System.Reflection;
using Microsoft.Data.Sqlite;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Infra.DAO
{
    public class RepositoryADO : IUserRepository
    {
        public  void CreateUser(User user)
        {

            string connectionString = ConnectionString.Get();

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



                string valor1 = user.Name;
                string valor2 = user.Password;

                
                string sql = "INSERT INTO [user] (name,password) VALUES (@valor1, @valor2)";
                SqliteCommand command = new SqliteCommand(sql, connection);
                command.Parameters.AddWithValue("@valor1", valor1);
                command.Parameters.AddWithValue("@valor2", valor2);

                int rowsAffected = command.ExecuteNonQuery();

                connection.Close();


            }
        }
    }
}
