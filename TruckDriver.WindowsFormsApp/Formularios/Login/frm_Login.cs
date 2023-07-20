using System;
using System.Threading;
using System.Windows.Forms;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Queries;
using TruckDriver.Infra.ADO;
using TruckDriver.Infra.DAO;

namespace TruckDriver.WindowsFormsApp.Formularios.Login
{
    public partial class frm_Login : frm_LoginBase
    {
        Thread t1;

        private readonly IUserQuery _userQuery;
        public frm_Login()
        {
            InitializeComponent();
            pnlSenha
                .LoadConfControls()
                .SetIDefaultmage("padlock.png")
                .SetImageOnClick("padlock2.png")
                .SetTextBoxAsPasswordChar();

            pnlUsuario
                .SetIDefaultmage("user-login.png")
                .SetImageOnClick("user-login2.png")
                .LoadConfControls();

            ButtonsNames("Entrar", "Registrar");

            _userQuery = new UserRepository();

        }


        protected override void btnBlue_Click(object sender, EventArgs e)
        {
            base.btnBlue_Click(sender, e);

            string nome = txtUsuario.Text == txtUsuario.DefaultPlaceHolder ? string.Empty : txtUsuario.Text;
            string senha = txtSenha.Text == txtSenha.DefaultPlaceHolder ? string.Empty : txtSenha.Text;

            User user = _userQuery.GetByName(nome);

            if (user != null && user.VerifyPassword(senha))
            {

                this.Close();
                t1 = new Thread(OpenFrmPrincipal);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }


            lblErroMessage.Text = "Usuario Ou senha invalida";
            lblErroMessage.Visible = true;
            picLogo.Visible = false;
            ClearControls();
            return;


        }

        protected override void btnNone_Click(object sender, EventArgs e)
        {
            frm_Registrar frm = new frm_Registrar();

            frm.ShowDialog();

            lblMessage.Text = frm.ReturnMessage;
            lblMessage.Visible = true;
        }


        private void OpenFrmPrincipal(object obj)
        {
            Application.Run(new frm_Principal());
        }

        private void ClearControls()
        {
            txtUsuario.resetTextBox();
            txtSenha.resetTextBox();
        }
    }
}
