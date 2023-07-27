using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.UserCommands;
using TruckDriver.Domain.Handlers;
using TruckDriver.Domain.Handlers.Contracts;
using TruckDriver.WindowsFormsApp.Services;

namespace TruckDriver.WindowsFormsApp.Formularios.Login
{
    public partial class frm_Registrar : frm_LoginBase
    {
        public const string SUCESS_MESSAGE = "Usuario registrado com sucesso";
        public string ReturnMessage;

        private IUserHandle _handler;
        public frm_Registrar()
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

            pnlRepeteSenha
                .LoadConfControls()
                .SetIDefaultmage("padlock.png")
                .SetImageOnClick("padlock2.png")
                .SetTextBoxAsPasswordChar();

            ButtonsNames("Registrar", "Voltar");

            _handler = AppContainer.ServiceProvider.GetService<IUserHandle>();


        }


        protected override async void btnBlue_Click(object sender, EventArgs e)
        {
            base.btnBlue_Click(sender, e);

            CreateUserCommand user = BindCommand();

            ICommandResult result = await _handler.Handle(user);

            if (!result.Success)
            {

                AtualizaControlles(result.Erros);
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

        private void AtualizaControlles(IEnumerable<String> erros)
        {
            label1.Visible = true;
            picLogo.Visible = false;
            label1.Text = string.Empty;

            foreach (var erro in erros)
            {
                label1.Text += erro;
                label1.Text += "\n";
            }
        }

    }
}
