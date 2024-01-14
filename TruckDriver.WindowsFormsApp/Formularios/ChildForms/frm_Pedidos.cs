﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using TruckDriver.Domain.Queries;
using TruckDriver.Infra.ADO;
using TruckDriver.WindowsFormsApp.Services;
using WindowsFormsApp1.Formularios.Cadastros;

namespace TruckDriver.WindowsFormsApp.Formularios.ChildForms
{
    public partial class frm_Pedidos : ChildBase
    {
        private int _PaginaAtual = 1;
        private int _UltimaPagina;
        private const int _NumeroDeRegistroPorPagina = 23;
        private string _FiltroNomeAtual = string.Empty;
        private string _FiltroStatusAtual = string.Empty;


        private IPedidoQuery _query;
        
        public frm_Pedidos()
        {
            InitializeComponent();
            _query = AppContainer.ServiceProvider.GetService<IPedidoQuery>();
            UpdateControls();
            UpdateGrid();
            AdjustColumnSize();

        }

        private void btn_Adcionar_Click(object sender, EventArgs e)
        {
            var Form = new frm_CadastroMotorista();
            Form.ShowDialog();
        }

        private void UpdateControls()
        {
            cmb_MotoristaStatus.Items.Clear();
            string[] Items = { string.Empty, "Em Viagem", "Férias", "Aguardando", "Em Retorno" };
            cmb_MotoristaStatus.Items.AddRange(Items);

            txt_Ir.NotAllowLetters();
            txt_Ir.NotAllowWhiteSpace();

            txt_BuscarPorNome.NotAllowNumbers();

            _UltimaPagina = (_query.QuantidadeDePedidos() / _NumeroDeRegistroPorPagina) + 1;



        }

        private void UpdateGrid(int skip = 0, string filtroNome = "", string filtroStatus = "")
        {
            dgv_Motoristas.DataSource = _query.Get(skip, _NumeroDeRegistroPorPagina, filtroNome, filtroStatus);
            dgv_Motoristas.Columns[0].HeaderText = "Pedido";
            dgv_Motoristas.Columns[1].HeaderText = "Distancia/KM";
            dgv_Motoristas.Columns[2].HeaderText = "Preço";
            dgv_Motoristas.Columns[3].HeaderText = "Data de Criação";
            dgv_Motoristas.Columns[4].HeaderText = "Data de Previsão";
            dgv_Motoristas.Columns[5].HeaderText = "Última Atualização";
            dgv_Motoristas.Columns[6].HeaderText = "Status";

            lbl_NumeroDePaginas.Text = $"{_PaginaAtual} de {_UltimaPagina} Páginas";
        }


        private void AdjustColumnSize()
        {
            int numberOfColumns = dgv_Motoristas.Columns.Count;
            int rowHeadersWidth = dgv_Motoristas.RowHeadersWidth;
            int columnWidth = (this.Width - rowHeadersWidth) / numberOfColumns;

            foreach (DataGridViewColumn column in dgv_Motoristas.Columns)
            {
                column.Width = columnWidth;
            }
        }

        private void dgv_Motoristas_SizeChanged(object sender, EventArgs e)
        {
            AdjustColumnSize();
        }

        private void btn_Ir_Click(object sender, EventArgs e)
        {
            IrParaPagina(Convert.ToInt32(txt_Ir.Text));

        }


        private void bnt_filtrar_Click(object sender, EventArgs e)
        {
            string filtroNome = txt_BuscarPorNome.Text;
            string filtroStatus = string.Empty;

            txt_Ir.Text = string.Empty;
            _PaginaAtual = 1;
            _FiltroNomeAtual = filtroNome;

            _UltimaPagina = (_query.QuantidadeDePedidos(filtroNome, filtroStatus) / _NumeroDeRegistroPorPagina) + 1;

            UpdateGrid(0, filtroNome, _FiltroStatusAtual);

        }

        private void btn_LimparFiltro_Click(object sender, EventArgs e)
        {
            _FiltroNomeAtual = string.Empty;
            txt_BuscarPorNome.Text = string.Empty;
            txt_Ir.Text = string.Empty;
            _PaginaAtual = 1;
            _UltimaPagina = (_query.QuantidadeDePedidos() / _NumeroDeRegistroPorPagina) + 1;
            UpdateGrid();
        }

        private void btn_Proximo_Click(object sender, EventArgs e)
        {
            IrParaPagina(_PaginaAtual + 1);
        }

        private void btn_Anterior_Click(object sender, EventArgs e)
        {
            IrParaPagina(_PaginaAtual - 1);
        }

        private void IrParaPagina(int IrParaPagina)
        {
            if (IrParaPagina > _UltimaPagina || IrParaPagina < 1)
                return;
            int skip = (IrParaPagina - 1) * _NumeroDeRegistroPorPagina;
            _PaginaAtual = IrParaPagina;
            UpdateGrid(skip, _FiltroNomeAtual, _FiltroStatusAtual);
        }

    }
}
