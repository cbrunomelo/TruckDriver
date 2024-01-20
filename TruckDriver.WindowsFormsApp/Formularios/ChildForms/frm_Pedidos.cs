using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Windows.Forms;
using TruckDriver.Domain.Entitys.PedidosState;
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
            var listaStatus = Enum.GetValues(typeof(EStatus))
                                                        .Cast<EStatus>()
                                                        .Select(valor => new
                                                        {
                                                            Valor = (int)valor,
                                                            Display = GetDisplayName(valor)
                                                        })
                                                        .ToList();

            listaStatus.Insert(0, new { Valor = -1, Display = string.Empty });

            cmb_PedidoStatus.DataSource = listaStatus;

            cmb_PedidoStatus.DisplayMember = "Display";
            cmb_PedidoStatus.ValueMember = "Valor";

            txt_Ir.NotAllowLetters();
            txt_Ir.NotAllowWhiteSpace();

            txt_BuscarPorNome.NotAllowNumbers();

            _UltimaPagina = (_query.QuantidadeDePedidos() / _NumeroDeRegistroPorPagina) + 1;



        }

        private void UpdateGrid(int skip = 0, string filtroNome = "", string filtroStatus = "")
        {
                                   
            dgv_pedidos.DataSource = _query.Get(skip, _NumeroDeRegistroPorPagina, filtroNome, filtroStatus);

            ConfigurarGrid();

            lbl_NumeroDePaginas.Text = $"{_PaginaAtual} de {_UltimaPagina} Páginas";
        }


        private void AdjustColumnSize()
        {
            int numberOfColumns = dgv_pedidos.Columns.Count;
            int rowHeadersWidth = dgv_pedidos.RowHeadersWidth;
            int columnWidth = (this.Width - rowHeadersWidth) / numberOfColumns;

            foreach (DataGridViewColumn column in dgv_pedidos.Columns)
            {
                column.Width = columnWidth;
            }
        }

        private void dgv_pedidos_SizeChanged(object sender, EventArgs e)
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


        private void ConfigurarGrid()
        {
            dgv_pedidos.AutoGenerateColumns = false;
            dgv_pedidos.Columns.Clear();

            DataGridViewTextBoxColumn pedido = new DataGridViewTextBoxColumn();
            pedido.HeaderText = "Pedido";
            pedido.DataPropertyName = "Id";
            pedido.Name = "Id";
            dgv_pedidos.Columns.Add(pedido);


            DataGridViewTextBoxColumn enderecoColeta = new DataGridViewTextBoxColumn();
            enderecoColeta.HeaderText = "Endereço Coleta";
            enderecoColeta.DataPropertyName = "Coleta_Endereco";
            enderecoColeta.Name = "EnderecoColeta";
            dgv_pedidos.Columns.Add(enderecoColeta);

            DataGridViewTextBoxColumn enderecoEntrega = new DataGridViewTextBoxColumn();
            enderecoEntrega.HeaderText = "Endereço Destino";
            enderecoEntrega.DataPropertyName = "Destino_Endereco";
            enderecoEntrega.Name = "EnderecoEntrega";
            dgv_pedidos.Columns.Add(enderecoEntrega);
            
            DataGridViewTextBoxColumn distanciaKM = new DataGridViewTextBoxColumn();
            distanciaKM.HeaderText = "Distancia/KM";
            distanciaKM.DataPropertyName = "DistanciaKM";
            distanciaKM.Name = "DistanciaKM";
            dgv_pedidos.Columns.Add(distanciaKM);

            DataGridViewTextBoxColumn preco = new DataGridViewTextBoxColumn();
            preco.HeaderText = "Preço";
            preco.DataPropertyName = "Preco";
            preco.Name = "Preco";
            dgv_pedidos.Columns.Add(preco);

            DataGridViewTextBoxColumn previsao = new DataGridViewTextBoxColumn();
            previsao.HeaderText = "Data de Previsão";
            previsao.DataPropertyName = "Previsao";
            previsao.Name = "Previsao";
            dgv_pedidos.Columns.Add(previsao);

            DataGridViewTextBoxColumn motorista = new DataGridViewTextBoxColumn();
            motorista.HeaderText = "Motorista";
            motorista.DataPropertyName = "Motorista";
            motorista.Name = "Motorista";
            dgv_pedidos.Columns.Add(motorista);
            
            DataGridViewTextBoxColumn status = new DataGridViewTextBoxColumn();
            status.HeaderText = "Status";
            status.DataPropertyName = "Status";
            status.Name = "Status";
            dgv_pedidos.Columns.Add(status);

        }

        private void dgv_pedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Teste");
        }


        private string GetDisplayName(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (EnumDisplayNameAttribute)Attribute.GetCustomAttribute(field, typeof(EnumDisplayNameAttribute));
            return attribute?.DisplayName ?? value.ToString();
        }

        private void cmb_PedidoStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
