using System;
using System.Windows.Forms;
using TruckDriver.Domain.Queries;
using TruckDriver.Infra.ADO;
using WindowsFormsApp1.Formularios.Cadastros;

namespace TruckDriver.WindowsFormsApp.Formularios.ChildForms
{
    public partial class frm_Motoristas : ChildBase
    {
        private IMotoristaQuery _query;
        public frm_Motoristas()
        {
            InitializeComponent();
            UpdateControls();
            _query = new MotoristaRepository();
            UpdateGrid(0, 23);
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
            string[] Items = { string.Empty, "Em Viagem", "Férias", "Aguardando"};
            cmb_MotoristaStatus.Items.AddRange(Items);

        }

        private void UpdateGrid(int skip, int take)
        {
            dgv_Motoristas.DataSource = _query.GetMotoristas(skip, take);
            dgv_Motoristas.Columns[0].HeaderText = "Nome";
            dgv_Motoristas.Columns[1].HeaderText = "Sobrenome";
            dgv_Motoristas.Columns[2].HeaderText = "Cpf";
            dgv_Motoristas.Columns[3].HeaderText = "Cnh";
            dgv_Motoristas.Columns[4].HeaderText = "Telefone";
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
    }
}
