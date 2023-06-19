using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.Cadastros;
using WindowsFormsApp1;
using TruckDriver.WindowsFormsApp.Controls;
using TruckDriver.Domain.Handlers;
using TruckDriver.Infra.ADO;
using TruckDriver.Domain.Entitys;

namespace TruckDriver.WindowsFormsApp.Formularios.ChildForms
{
    public partial class frm_Motoristas : ChildBase
    {
        public frm_Motoristas()
        {
            InitializeComponent();
            
        }

        private void btn_Adcionar_Click(object sender, EventArgs e)
        {
            var Form = new frm_CadastroMotorista();

            Form.ShowDialog();
        }

    }
}
