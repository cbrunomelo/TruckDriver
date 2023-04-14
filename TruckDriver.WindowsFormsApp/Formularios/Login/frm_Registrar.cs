using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckDriver.Domain.Commands.UserCommands;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Handlers;
using TruckDriver.Infra.DAO;

namespace TruckDriver.WindowsFormsApp.Formularios.Login
{
    public partial class frm_Registrar : frm_LoginBase
    {
        public const string SUCESS_MESSAGE = "Usuario registrado com sucesso";
        public string ReturnMessage;

        private UserHandler _handler;
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

            _handler = new UserHandler(new RepositoryADO());


        }


        protected override void btnBlue_Click(object sender, EventArgs e)
        {
            base.btnBlue_Click(sender, e);

            CreateUserCommand user = BindCommand();

            GenericCommandResult result = (GenericCommandResult)_handler.Handle(user);

            if (!result.Success)
            {

                AtualizaControlles((List<ValidationFailure>)result.Data);
                return;
            }

            else
            {
                ReturnMessage = SUCESS_MESSAGE;
                this.Close();
            }
        }


        protected override void btnNone_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private CreateUserCommand BindCommand()
        {
            string nome = txtUsuario.Text == txtUsuario.DefaultPlaceHolder ? string.Empty : txtUsuario.Text;
            string senha = txtSenha.Text == txtSenha.DefaultPlaceHolder ? string.Empty : txtSenha.Text;
            string Repetesenha = txtRepeteSenha.Text == txtRepeteSenha.DefaultPlaceHolder ? string.Empty : txtRepeteSenha.Text;
            return new CreateUserCommand(nome, senha, Repetesenha);
        }

        private void AtualizaControlles(List<ValidationFailure> erros)
        {            
            label1.Visible = true;
            picLogo.Visible= false;
            label1.Text = string.Empty;
            
            foreach(var erro in erros)
            {
                label1.Text += erro.ErrorMessage;
                label1.Text += "\n";
            }
        }

    }
}
