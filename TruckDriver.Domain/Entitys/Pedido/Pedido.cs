using System;
using System.Collections.Generic;
using TruckDriver.Domain.Entitys.PedidosState;
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
        public Pedido(Endereco coleta, Endereco Destino, ICepService cepService)
        {
            Coleta_Endereco = coleta;
            Destino_Endereco = Destino;
            _cepService = cepService;
            _statusManager = new PedidoPendente();
            _status = _statusManager.GetStatus();
            PreencherValores();


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

        public int Fk_Coleta_EnderecoId
        {
            get
            {
                return Coleta_Endereco.Id;
            }
            private set { }
        }

        public int Fk_Destino_EnderecoId
        {
            get
            {
                return Destino_Endereco.Id;
            }
            private set { }
        }

        public Endereco Coleta_Endereco { get; private set; }

        public Endereco Destino_Endereco { get; private set; }

        public int? Fk_MotoristaId
        {
            get { return Motorista?.Id; }
            private set {  }
        }

        private Motorista Motorista { get; set; }


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

        public void SetMotorista(Motorista motorista)
        {
            Motorista = motorista;
            AvancarStatus();
        }

    }
}
