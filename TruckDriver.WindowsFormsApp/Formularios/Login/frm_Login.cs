﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using TruckDriver.Domain.Commands.UserCommands;
using TruckDriver.Domain.Handlers;
using System.Runtime.InteropServices;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands;
using FluentValidation.Results;

namespace TruckDriver.WindowsFormsApp.Formularios.Login
{
    public partial class frm_Login : frm_LoginBase
    {
        Thread t1;

        private UserHandler _handler;
        public frm_Login()
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

            ButtonsNames("Entrar", "Registrar");

            //_handler = new UserHandler();

        }


        protected override void btnBlue_Click(object sender, EventArgs e)
        {
            base.btnBlue_Click(sender, e);

            this.Close();
            t1 = new Thread(OpenFrmPrincipal);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        protected override void btnNone_Click(object sender, EventArgs e)
        {
            frm_Registrar frm = new frm_Registrar();
            
            frm.ShowDialog();

            lblMessage.Text = frm.ReturnMessage;            
            lblMessage.Visible=true;
        }


        private void OpenFrmPrincipal(object obj)
        {
            Application.Run(new frm_Principal());
        }
    }
}
