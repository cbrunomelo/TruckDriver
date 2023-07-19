using System;
using System.IO;
using System.Reflection;
using Microsoft.Data.Sqlite;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Queries;
using TruckDriver.Domain.Repository;
using TruckDriver.Infra.ADO;

namespace TruckDriver.Infra.DAO
{
    public class UserRepository : IUserRepository, IUserQuery
    {
        private RepositoryBase<User> repositoryBase;
        public UserRepository(RepositoryBase<User> repositoryBase)
        {
            this.repositoryBase = repositoryBase;
        }

        public int Creat(User user) =>  repositoryBase.Creat(user); 

    
        
        public  User GetByName(string name)
        {
            string sql = "SELECT id, name, password FROM user WHERE name = @name";

            using (var connection = new SqliteConnection(repositoryBase.connectionString))
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
