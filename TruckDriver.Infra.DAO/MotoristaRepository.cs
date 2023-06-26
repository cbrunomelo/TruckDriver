using Microsoft.Data.Sqlite;
using System.Data;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Queries;
using TruckDriver.Domain.Repository;


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
            string connectionString = _repository.connectionString;
            string query = "SELECT Nome, Sobrenome, Cpf, Cnh, Telefone FROM Motorista LIMIT @Take OFFSET @Skip";

            DataTable dataTable = new DataTable();

            using (SqliteConnection connection = new SqliteConnection(connectionString))
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
    }
}
