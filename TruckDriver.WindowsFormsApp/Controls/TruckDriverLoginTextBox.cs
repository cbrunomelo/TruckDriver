using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckDriver.WindowsFormsApp.Formularios.Login;

namespace TruckDriver.WindowsFormsApp.Controls
{
    public class TruckDriverLoginTextBox : TextBox
    {              
        private TruckDriverPanelLogin _panel;
        private string DefaultPlaceHolder;

        public TruckDriverLoginTextBox SetPanel(TruckDriverPanelLogin panel)
        {
            DefaultPlaceHolder = Text;
            this._panel = panel;
            return this;

        }

 


        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if(Text == DefaultPlaceHolder) 
                this.Clear();
            
            _panel.Onclick();


        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (Text.Length == 0)
            {
                Text = DefaultPlaceHolder;
            }
            _panel.OnLeave();

        
        }

    }
}
