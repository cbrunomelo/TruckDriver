using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckDriver.WindowsFormsApp.Formularios;
using TruckDriver.WindowsFormsApp.Formularios.ChildForms;
using WindowsFormsApp1;
using WindowsFormsApp1.Formularios;

namespace TruckDriver.WindowsFormsApp.Controls
{
    public class TruckDriverPanelButton : Button
    {

        private ChildBase _ChildForm;

        public Color _color { get; private set; }

        private frm_Principal frm_Principal;

        public TruckDriverPanelButton SetChildForm(ChildBase childForm)
        {
            this._ChildForm = childForm;
            return this;
        }
        public TruckDriverPanelButton Setfrm_Principal(frm_Principal form)
        {
            this.frm_Principal = form;
            return this;
        }
        public TruckDriverPanelButton SelectThemeColor(int ColorTheme)
        {
            string color = ThemeColor.ColorList[ColorTheme];
            _color = ColorTranslator.FromHtml(color);
            return this;
        }

        public void DisableThisButton()
        {
            BackColor = frm_Principal.panelMenu.BackColor;
            ForeColor = Color.Gainsboro;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        public void ActivateThisButton()
        {
            BackColor = _color;
            ForeColor = Color.White;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            SendChildFormToBeOpen();

        }

        private void SendChildFormToBeOpen()
        {
            Type type = _ChildForm.GetType();
            _ChildForm = ChildFormFactory.GetChildForm(type);
            frm_Principal.OnActivateButton(this, _ChildForm);
        }






    }
}
