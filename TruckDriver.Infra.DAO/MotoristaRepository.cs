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

        public DataTable GetMotoristas(int skip, int take, string filtroNome, string filtroStatus)
        {
            string query = "SELECT Nome, Sobrenome, Cpf, Cnh, Telefone, Status FROM Motorista ";
            if (filtroNome != "")
                query += "Where LOWER(nome) = LOWER(@filtroNome) ";

            query += "LIMIT @Take OFFSET @Skip";

            DataTable dataTable = new DataTable();

            using (SqliteConnection connection = new SqliteConnection(_repository.connectionString))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@Skip", skip);
                command.Parameters.AddWithValue("@Take", take);
                if (filtroNome != "")
                    command.Parameters.AddWithValue("@filtroNome", filtroNome);


                SqliteDataReader reader = command.ExecuteReader();

                dataTable.Load(reader);

                reader.Close();
            }

            return dataTable;
        }

        public DataTable GetMotoristas(int skip, int take) => GetMotoristas(skip, take, string.Empty, string.Empty);

        public DataTable GetMotoristas(string filtroNome, string filtroStatus) => GetMotoristas(0, Int32.MaxValue, filtroNome, filtroStatus);

        public DataTable GetMotoristas() => GetMotoristas(string.Empty, string.Empty);

        public int QuantidadeDeMotoristas() => QuantidadeDeMotoristas(string.Empty, string.Empty);

        public int QuantidadeDeMotoristas(string filtroNome, string filtroStatus)
        {
            string query = "SELECT COUNT(*) FROM Motorista ";

            if (!string.IsNullOrEmpty(filtroNome))
                query += "Where LOWER(nome) = LOWER(@filtroNome)";



            int quantidadeRegistros = 0;

            using (SqliteConnection connection = new SqliteConnection(_repository.connectionString))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(query, connection);

                if (!string.IsNullOrEmpty(filtroNome))
                    command.Parameters.AddWithValue("@filtroNome", filtroNome);

                quantidadeRegistros = Convert.ToInt32(command.ExecuteScalar());
            }

            return quantidadeRegistros;
        }
    }
}
