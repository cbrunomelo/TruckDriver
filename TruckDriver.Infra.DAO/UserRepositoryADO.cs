using System;
using System.IO;
using System.Reflection;
using Microsoft.Data.Sqlite;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Queries;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Infra.DAO
{
    public class UserRepositoryADO : IUserRepository, IUserQuery
    {
        private  readonly string connectionString = ConnectionString.Get();
        public void CreateUser(User user)
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

        public  User GetUserByName(string name)
        {
            string sql = "SELECT id, name, password FROM user WHERE name = @name";

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqliteCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nome = reader.GetString(1);
                            string password = reader.GetString(2);

                            User user = new User();
                            user.Name = nome;
                            user.Password = password;

                            return user;
                        }
                    }
                }
            }
            return null;
        }
    }
}