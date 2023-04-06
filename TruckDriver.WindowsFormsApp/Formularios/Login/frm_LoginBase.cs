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
    public partial class frm_LoginBase : Form
    {
        public frm_LoginBase()
        {
            InitializeComponent();
            
        }

        
        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void btnBlue_Click(object sender, EventArgs e)
        {

        }

        protected virtual void btnNone_Click(object sender, EventArgs e)
        {

        }

        protected void ButtonsNames(string btnBlue, string btnNone)
        {
            this.btnBlue.Text = btnBlue;
            this.btnNone.Text = btnNone;  
        }
    }
}