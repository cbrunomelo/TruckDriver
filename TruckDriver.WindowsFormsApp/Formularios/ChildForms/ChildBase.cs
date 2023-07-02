using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckDriver.WindowsFormsApp.Controls;

namespace TruckDriver.WindowsFormsApp.Formularios.ChildForms
{
    public partial class ChildBase : Form
    {
        public ChildBase()
        {
            InitializeComponent();
            TopLevel = false;
            FormBorderStyle = FormBorderStyle.None;
            Dock = DockStyle.Fill;
        }




        private void ChildBase_Load(object sender, EventArgs e)
        {
            BuscarBotao(this);

            
        }


        private void BuscarBotao(Control controls)
        {
            foreach (Control Control in controls.Controls)
            {
                if (Control.GetType() == typeof(Button))
                {
                    Button btn = (Button)Control;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

                }

                if (Control.GetType() == typeof(GroupBox))
                {
                    BuscarBotao(Control);
                }


            }
        }
    }


}
