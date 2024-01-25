using System;
using System.Collections.Generic;
using TruckDriver.Domain.Entitys.PedidosState;
using TruckDriver.Domain.Queries;
using TruckDriver.Domain.Services;

namespace TruckDriver.Domain.Entitys
{
    public sealed class Pedido : Entity
    {
        public override string TABLE_NAME { get => "Pedido"; set => base.TABLE_NAME = value; }
        public const int DISTANCIA_MINIMA_KM = 100;
        private const float VALOR_KM = 2.5f;
        private IPedidoStatus _statusManager;
        private ICepService _cepService;
        private IMotoristaQuery _motoristaquery;
        private IEnderecoQuery _enderecoQuery;
        public Pedido(Endereco coleta, Endereco Destino, ICepService cepService,
            IMotoristaQuery motoristaquery, IEnderecoQuery enderecoQuery )
        {
            _enderecoQuery = enderecoQuery;
            _motoristaquery = motoristaquery;
            Coleta_Endereco = coleta;
            Destino_Endereco = Destino;
            _cepService = cepService;
            _statusManager = new PedidoPendente();
            _status = _statusManager.GetStatus();
            PreencherValores();


        }

        private Pedido(int id, double distanciaKM, double preco, DateTime criadoEm, DateTime previsao,
                       DateTime ultimaAtualizacao, EStatus status, int fk_Coleta_EnderecoId, int fk_Destino_EnderecoId,
                       int fk_MotoristaId, IEnderecoQuery enderecoQuery, IMotoristaQuery motoristaquery)
        {
            Id = id;
            DistanciaKM = distanciaKM;
            Preco = preco;
            CriadoEm = criadoEm;
            Previsao = previsao;
            UltimaAtualizacao = ultimaAtualizacao;
            _status = status;
            Fk_Coleta_EnderecoId = fk_Coleta_EnderecoId;
            Fk_Destino_EnderecoId = fk_Destino_EnderecoId;
            Fk_MotoristaId = fk_MotoristaId;
            _enderecoQuery = enderecoQuery;
            _motoristaquery = motoristaquery;
        }

        public static Pedido CarregarDoBanco(int id, double distanciaKM, double preco, DateTime criadoEm, DateTime previsao,
            DateTime ultimaAtualizacao, EStatus status, int fk_Coleta_EnderecoId, int fk_Destino_EnderecoId, int fk_MotoristaId,
            IEnderecoQuery enderecoquery, IMotoristaQuery motoristaQuery)
        {            
            Pedido pedido = new Pedido(id, distanciaKM, preco, criadoEm, previsao, ultimaAtualizacao, status, fk_Coleta_EnderecoId,
                fk_Destino_EnderecoId, fk_MotoristaId, enderecoquery, motoristaQuery);
            return pedido;
        }

        public void AvancarStatus()
        {
            _statusManager = _statusManager.AvancarStatus();
            _status = _statusManager.GetStatus();
            UltimaAtualizacao = DateTime.Now;
        }

        public void VoltarStatus()
        {
            _statusManager = _statusManager.VoltarStatus();
            _status = _statusManager.GetStatus();
            UltimaAtualizacao = DateTime.Now;

        }


        public double DistanciaKM { get; private set; }

        public double Preco { get; private set; }
        
        public int Fk_Coleta_EnderecoId { get; internal set; }

        private Endereco _coleta_Endereco;
        public Endereco Coleta_Endereco
                        { get
                            {
                             if (_coleta_Endereco is null & Fk_Coleta_EnderecoId != 0)
                                _coleta_Endereco = LoadEndereco(Fk_Coleta_EnderecoId);
                              return _coleta_Endereco;
                            }
                            private set => _coleta_Endereco = value;
                           }


        public int Fk_Destino_EnderecoId { get; internal set; }

        private Endereco _destino_Endereco;
        public Endereco Destino_Endereco 
                        { 
                        get 
                            {
                               if (_destino_Endereco is null & Fk_Destino_EnderecoId != 0)
                                   _destino_Endereco = LoadEndereco(Fk_Destino_EnderecoId);                
                                      
                                return _destino_Endereco;
                            }
                        private set => _destino_Endereco = value;
                        }


        public int Fk_MotoristaId { get; internal set; }

        private Motorista _motorista;
        public Motorista Motorista 
                        {
                            get
                            {
                             if (_motorista is null & Fk_MotoristaId != 0) 
                                _motorista = LoadMotorista();
                             return _motorista;
                            }
                        }


        private EStatus _status { get; set; }

        public string Status { get => _status.ToString(); }

        public int Id { get; set; }

        public DateTime CriadoEm { get; private set; }

        public DateTime UltimaAtualizacao { get; private set; }

        public DateTime Previsao { get; private set; }


        private DateTime CalcularPrevisao()
        {
            int dias = (int)DistanciaKM / 100;
            Previsao = CriadoEm.AddDays(dias);
            return Previsao;
        }

        private double CalcularPreco()
        {
            return DistanciaKM * VALOR_KM;
        }

        private async void PreencherValores()
        {
            DistanciaKM =await _cepService.CalcularDistancia(Coleta_Endereco, Destino_Endereco);
            CriadoEm = UltimaAtualizacao = DateTime.Now;
            Previsao = CalcularPrevisao();
            Preco = CalcularPreco();
        }


        private Motorista LoadMotorista()
        {
            return _motoristaquery.GetById(Fk_MotoristaId);
        }


        private Endereco LoadEndereco(int endereco_id)
        {
            return _enderecoQuery.Get(endereco_id);
        }

    }

}
