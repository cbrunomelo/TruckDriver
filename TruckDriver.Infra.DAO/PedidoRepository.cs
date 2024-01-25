using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Entitys.PedidosState;
using TruckDriver.Domain.Queries;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Infra.ADO
{
    public class PedidoRepository : IPedidoRepository, IPedidoQuery
    {
        private readonly RepositoryBase<Pedido> _repository;
        private IEnderecoQuery _enderecoQuery;
        private IMotoristaQuery _motoristaQuery;
        public PedidoRepository(IEnderecoQuery enderecoquery, IMotoristaQuery motoristaQuery)
        {
            _motoristaQuery = motoristaQuery;
            _enderecoQuery = enderecoquery;
            _repository = new RepositoryBase<Pedido>();
            
        }
        public int Creat(Pedido entity)
        {
            return _repository.Creat(entity);
        }

        public IEnumerable<Pedido> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> Get(int skip, int take)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> Get(string filtroNome, string filtroStatus)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> Get(int skip, int take, string filtroPedido, string filtroStatus)
        {
            List<Pedido> pedidos = new List<Pedido>();

            string query = "select id, distanciaKM, preco, criadoEm, previsao, UltimaAtualizacao, " +
                "status,FK_coleta_EnderecoId, Fk_Destino_EnderecoId, FK_MotoristaId from pedido ";
            
            if (!string.IsNullOrEmpty(filtroPedido))
            {
                query += "Where id = @filtroPedido ";
                if (!string.IsNullOrEmpty(filtroStatus))
                    query += "And LOWER(Status) = LOWER(@filtroStatus) ";
            }
            else if (!string.IsNullOrEmpty(filtroStatus))
                query += "Where LOWER(Status) = LOWER(@filtroStatus) ";

            query += "LIMIT @Take OFFSET @Skip";


            using (SqliteConnection connection = new SqliteConnection(_repository.connectionString))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@Skip", skip);
                command.Parameters.AddWithValue("@Take", take);

                if (!string.IsNullOrEmpty(filtroPedido))
                    command.Parameters.AddWithValue("@filtroPedido", filtroPedido);
                if (!string.IsNullOrEmpty(filtroStatus))
                    command.Parameters.AddWithValue("@filtroStatus", filtroStatus);

                using (SqliteDataReader reader = command.ExecuteReader())
                {


                    while (reader.Read())
                    {

                        var id = reader[0].GetType().Name;
                       var distanciaKM = reader[1].GetType().Name;
                        var preco = reader[2].GetType().Name;
                       var criadoEm = reader[3].GetType().Name;
                       var previsao = reader[4].GetType().Name; 
                       var ultimaAtualizacao = reader[5].GetType().Name;    
                       var status = reader[6].GetType().Name;
                       var fk_Coleta_EnderecoId = reader[7].GetType().Name;
                       var fk_Destino_EnderecoId = reader[8].GetType().Name;
                       var fk_MotoristaId = reader[9].GetType().Name;

                        Pedido pedido = Pedido.CarregarDoBanco
                            (
                            id: Convert.ToInt32(reader[0]),
                            distanciaKM: Convert.ToDouble(reader[1]),
                            preco: Convert.ToDouble(reader[2]),
                            criadoEm: Convert.ToDateTime(reader[3]),
                            previsao: Convert.ToDateTime(reader[4]),
                            ultimaAtualizacao: Convert.ToDateTime(reader[5]),
                            status: (EStatus)Enum.Parse(typeof(EStatus), reader[6].ToString()),
                            fk_Coleta_EnderecoId: DBNull.Value == reader[7] ? 0 : Convert.ToInt32(reader[7]),
                            fk_Destino_EnderecoId: DBNull.Value == reader[8] ? 0 : Convert.ToInt32(reader[8]),
                            fk_MotoristaId: reader[9] == DBNull.Value ? 0 : Convert.ToInt32(reader[9]),
                            _enderecoQuery, _motoristaQuery
                            ); ;
                        pedidos.Add(pedido);
                    }                        
                                                     
                    }
                }

            return pedidos;
           }

        public int QuantidadeDePedidos()
        {
            string query = "SELECT COUNT(*) FROM Pedido ";
            using(SqliteConnection connection = new SqliteConnection(_repository.connectionString))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(query, connection);

                return Convert.ToInt32(command.ExecuteScalar());
            }
            
        }

        public int QuantidadeDePedidos(string filtroPedido, string filtroStatus)
        {
            string query = "SELECT COUNT(*) FROM Pedido ";
            if (!string.IsNullOrEmpty(filtroPedido))
            {
                query += "Where id = @filtroPedido ";
                if (!string.IsNullOrEmpty(filtroStatus))
                    query += "And LOWER(Status) = LOWER(@filtroStatus) ";
            }
            else if (!string.IsNullOrEmpty(filtroStatus))
                query += "Where LOWER(Status) = LOWER(@filtroStatus) ";
            

            using(SqliteConnection connection = new SqliteConnection(_repository.connectionString))
            {
                connection.Open();

                SqliteCommand command = new SqliteCommand(query, connection);
                if (!string.IsNullOrEmpty(filtroPedido))
                    command.Parameters.AddWithValue("@filtroPedido", filtroPedido);
                if (!string.IsNullOrEmpty(filtroStatus))
                    command.Parameters.AddWithValue("@filtroStatus", filtroStatus);

                return Convert.ToInt32(command.ExecuteScalar());
            }
        }


    }


    }

