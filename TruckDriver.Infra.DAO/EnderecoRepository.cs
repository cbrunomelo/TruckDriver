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
                        string cep = reader.IsDBNull(1) ? null : reader.GetString(1);
                        string logradouro = reader.IsDBNull(2) ? null : reader.GetString(2);
                        string complemento = reader.IsDBNull(3) ? null : reader.GetString(3);
                        string bairro = reader.IsDBNull(4) ? null : reader.GetString(4);
                        string cidade = reader.IsDBNull(5) ? null : reader.GetString(5);
                        string estado = reader.IsDBNull(6) ? null : reader.GetString(6);

                        return new Endereco(id, cep, logradouro, complemento, bairro, cidade, estado);
                    }
                    else
                        return null;
                }
            }
        }
    }
}
