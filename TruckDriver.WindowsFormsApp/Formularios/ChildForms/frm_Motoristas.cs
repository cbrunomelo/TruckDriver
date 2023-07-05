using System;
using System.Drawing.Text;
using System.Windows.Forms;
using TruckDriver.Domain.Queries;
using TruckDriver.Infra.ADO;
using WindowsFormsApp1.Formularios.Cadastros;

namespace TruckDriver.WindowsFormsApp.Formularios.ChildForms
{
    public partial class frm_Motoristas : ChildBase
    {
        private int PaginaAtual = 1;
        private int _UltimaPagina;
        private const int _NumeroDeRegistroPorPagina = 23;


        private IMotoristaQuery _query;
        public frm_Motoristas()
        {
            InitializeComponent();
            _query = new MotoristaRepository();
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
            string[] Items = { string.Empty, "Em Viagem", "Férias", "Aguardando", "Em Retorno"};
            cmb_MotoristaStatus.Items.AddRange(Items);

            txt_Ir.NotAllowLetters();
            txt_Ir.NotAllowWhiteSpace();

            txt_BuscarPorNome.NotAllowNumbers();

            _UltimaPagina = (_query.QuantidadeDeMotoristas()/ _NumeroDeRegistroPorPagina) + 1;

            

        }

        private void UpdateGrid(int skip = 0)
        {
            dgv_Motoristas.DataSource = _query.GetMotoristas(skip, _NumeroDeRegistroPorPagina);
            dgv_Motoristas.Columns[0].HeaderText = "Nome";
            dgv_Motoristas.Columns[1].HeaderText = "Sobrenome";
            dgv_Motoristas.Columns[2].HeaderText = "Cpf";
            dgv_Motoristas.Columns[3].HeaderText = "Cnh";
            dgv_Motoristas.Columns[4].HeaderText = "Telefone";

            lbl_NumeroDePaginas.Text = $"{PaginaAtual} de {_UltimaPagina} Páginas";
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
            int IrParaPagina = Convert.ToInt32(txt_Ir.Text);
            int skip = (IrParaPagina - 1) * _NumeroDeRegistroPorPagina;
            PaginaAtual = IrParaPagina;
            UpdateGrid(skip);




            // com o filtro acima
        }

        private void bnt_filtrar_Click(object sender, EventArgs e)
        {
            // filtrar de acordo
        }
    }
}
