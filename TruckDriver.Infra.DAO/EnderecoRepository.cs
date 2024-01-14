using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Queries;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Infra.ADO
{
    public class EnderecoRepository : IEnderecoRepository, IEnderecoQuery
    {
        private RepositoryBase<Endereco> _repositoryBase;
        public EnderecoRepository()
        {
            _repositoryBase = new RepositoryBase<Endereco>();
        }
        public int Creat(Endereco endereco) => _repositoryBase.Creat(endereco);

        public Endereco Get(int id)
        {
            string query = "SELECT id, cep, logradouro, complemento, bairro, " +
                "cidade, estado " +
                "FROM Endereco " +
                "WHERE Id = @Id";

            using (SqliteConnection connection = new SqliteConnection(_repositoryBase.connectionString))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return new Endereco(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6)
                                            );
                    }
                    else
                        return null;
                }
            }
        }
    }
}
