using Microsoft.Data.Sqlite;
using System;
using System.Data;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Queries;
using TruckDriver.Domain.Repository;
using TruckDriver.Infra.DAO;


namespace TruckDriver.Infra.ADO
{
    public class MotoristaRepository : IMotoristaRepository, IMotoristaQuery
    {
        private readonly RepositoryBase<Motorista> _repository;        
        public MotoristaRepository()
        {
            _repository = new RepositoryBase<Motorista>();
        }

        public int Creat(Motorista motorista)
        {
            return _repository.Creat(motorista);
        }

        public DataTable GetMotoristas(int skip, int take)
        {            
            string query = "SELECT Nome, Sobrenome, Cpf, Cnh, Telefone FROM Motorista LIMIT @Take OFFSET @Skip";

            DataTable dataTable = new DataTable();

            using (SqliteConnection connection = new SqliteConnection(_repository.connectionString))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@Skip", skip);
                command.Parameters.AddWithValue("@Take", take);


                SqliteDataReader reader = command.ExecuteReader();

                dataTable.Load(reader);

                reader.Close();
            }

            return dataTable;
        }

        public int QuantidadeDeMotoristas()
        {
            string query = "SELECT COUNT(*) FROM Motorista";

            int quantidadeRegistros = 0;

            using (SqliteConnection connection = new SqliteConnection(_repository.connectionString))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(query, connection);

                quantidadeRegistros = Convert.ToInt32(command.ExecuteScalar());
            }

            return quantidadeRegistros;
        }
    }
}
