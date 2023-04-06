using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckDriver.WindowsFormsApp.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace TruckDriver.WindowsFormsApp.Formularios.Login
{
    public partial class beckup : Form
    {
        private Color COR_PADRAO_PANEL = Color.FromArgb(255, 255, 255);

        public beckup()
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

        }

        
        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
