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
        public string DefaultPlaceHolder { get; private set; }

        private char _none = '\0';

        private char _passwordChar = '\0';

        public TruckDriverLoginTextBox SetPanel(TruckDriverPanelLogin panel)
        {
            this.PasswordChar = _none;
            DefaultPlaceHolder = Text;
            this._panel = panel;
            return this;

        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            if (Text == DefaultPlaceHolder)
            {
                this.PasswordChar = _none;
                this.Clear();

            }
            this.PasswordChar = _passwordChar;
            _panel.Onclick();


        }

        protected override void OnLeave(EventArgs e)
        {
            base.OnLeave(e);
            if (Text.Length == 0)
            {
                Text = DefaultPlaceHolder;
                this.PasswordChar = _none;
            }
            _panel.OnLeave();

        
        }


        public void SetThisAsPasswordTextBox()
        {
            _passwordChar = '*';
        }

        public void resetTextBox() 
        {
            this.PasswordChar = _none;
            Text = DefaultPlaceHolder;

        }
    }
}
