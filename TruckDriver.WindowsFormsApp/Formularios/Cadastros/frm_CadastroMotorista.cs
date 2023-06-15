using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1.Formularios.Cadastros
{
    public partial class frm_CadastroMotorista : Form
    {
        public frm_CadastroMotorista()
        {
            InitializeComponent();

            AtualizarControles();


        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
   
        public void AtualizarControles()
        {
            txt_NomeMotorista.NotAllowNumbers();
            txt_Sobrenome.NotAllowNumbers();
            txt_Cidade.NotAllowNumbers();
            txt_Bairro.NotAllowNumbers();
            txt_NumeroCNH.NotAllowLetters();
            txt_NumeroCNH.NotAllowWhiteSpace();
            txt_NumeroCNH.MaxLength = 11;
            
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
