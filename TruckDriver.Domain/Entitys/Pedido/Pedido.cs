using System;
using System.Collections.Generic;
using TruckDriver.Domain.Entitys.PedidosState;
using TruckDriver.Domain.Services;

namespace TruckDriver.Domain.Entitys
{
    public class Pedido : Entity
    {
        public override string TABLE_NAME { get => "Pedido"; set => base.TABLE_NAME = value; }
        public const int DISTANCIA_MINIMA_KM = 100;
        private const float VALOR_KM = 2.5f;
        private IPedidoStatus _status;
        private ICepService _distancecalculator;
        public Pedido(Endereco coleta, Endereco Destino, ICepService distancecalculator)
        {
            Coleta_Endereco = coleta;
            Destino_Endereco = Destino;
            _distancecalculator = distancecalculator;
            _status = new PedidoPendente();
            Status = _status.GetStatus();
            PreencherValores();


        }

        public void AvancarStatus()
        {
            _status = _status.AvancarStatus();
            Status = _status.GetStatus();
            UltimaAtualizacao = DateTime.Now;
        }

        public void VoltarStatus()
        {
            _status = _status.VoltarStatus();
            Status = _status.GetStatus();
            UltimaAtualizacao = DateTime.Now;

        }


        public float DistanciaKM { get; private set; }

        public float Preco { get; private set; }

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

        public EStatus Status { get; private set; }

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

        private float CalcularPreco()
        {
            return DistanciaKM * VALOR_KM;
        }

        private void PreencherValores()
        {
            DistanciaKM = _distancecalculator.CalcularDistancia(Coleta_Endereco.Cep, Destino_Endereco.Cep);
            CriadoEm = UltimaAtualizacao = DateTime.Now;
            Previsao = CalcularPrevisao();
            Preco = CalcularPreco();
        }

    }
}
