using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using TruckDriver.WindowsFormsApp.Controls;
using TruckDriver.WindowsFormsApp.Formularios.ChildForms;
using TruckDriver.WindowsFormsApp.Formularios.Login;

namespace TruckDriver.WindowsFormsApp.Formularios
{

    public partial class frm_Principal : Form
    {
        Thread t1;
        public Button currentButton;
        public Form activeForm;

        public frm_Principal()
        {
            InitializeComponent();
            UpdateControls();
            ButtonSettings();

        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaxMinSizeApp_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void btnCloseChildren_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButtons();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 77);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildren.Visible = false;
        }


        public void OnActivateButton(TruckDriverPanelButton btnSender, ChildBase childForm)
        {

            if (currentButton != (TruckDriverPanelButton)btnSender)
            {
                DisableButtons();
                currentButton = (TruckDriverPanelButton)btnSender;
                Color color = btnSender._color;
                btnSender.ActivateThisButton();
                panelTitleBar.BackColor = color;
                panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                ThemeColor.PrimaryColor = color;
                ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                btnCloseChildren.Visible = true;

                if (activeForm != null)
                    activeForm.Close();
                activeForm = childForm;
                PanelChildren.Controls.Add(childForm);
                PanelChildren.Tag = childForm;
                lblTitle.Text = childForm.Text;
                childForm.BringToFront();
                childForm.Show();

            }

        }

        public void DisableButtons()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(TruckDriverPanelButton))
                    ((TruckDriverPanelButton)previousBtn).DisableThisButton();
            }
        }

        private void UpdateControls()
        {
            btnCloseChildren.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ButtonSettings()
        {
            btnMotorista
                .SetChildForm(new frm_Motoristas())
                .Setfrm_Principal(this)
                .SelectThemeColor(9);

            btnPedidos
                .SetChildForm(new frm_Pedidos())
                .Setfrm_Principal(this)
                .SelectThemeColor(9);

            btnConfiguracao
                .SetChildForm(new frm_Configuracao())
                .Setfrm_Principal(this)
                .SelectThemeColor(9);

            btnCaminhao
                .SetChildForm(new frm_caminhao())
                .Setfrm_Principal(this)
                .SelectThemeColor(9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(() => Application.Run(new frm_Login()));
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
