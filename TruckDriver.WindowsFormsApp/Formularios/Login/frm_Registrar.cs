using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckDriver.WindowsFormsApp.Formularios.Login
{
    public partial class frm_Registrar : frm_LoginBase
    {
        public frm_Registrar()
        {
            InitializeComponent();
            pnlSenha
                .SetIDefaultmage("padlock.png")
                .SetImageOnClick("padlock2.png")
                .LoadConfControls();
            pnlUsuario
                .SetIDefaultmage("user-login.png")
                .SetImageOnClick("user-login2.png")
                .LoadConfControls();

            pnlRepeteSenha
                .SetIDefaultmage("padlock.png")
                .SetImageOnClick("padlock2.png")
                .LoadConfControls();

            ButtonsNames("Registrar", "Voltar");

     
        }


        protected override void btnNone_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
