using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.MotoristaCommands;
using TruckDriver.Domain.Handlers;
using TruckDriver.Infra.ADO;

namespace WindowsFormsApp1.Formularios.Cadastros
{
    public partial class frm_CadastroMotorista : Form
    {
        private readonly MotoristaHandler _handler;
        
        public frm_CadastroMotorista()
        {
            InitializeComponent();
            AtualizarControles();
            _handler = new MotoristaHandler(new MotoristaRepository());

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
   
        public void AtualizarControles()
        {
            txt_NomeMotorista.NotAllowNumbers();
            txt_Sobrenome.NotAllowNumbers();
            txt_Cidade.NotAllowNumbers();
            txt_Bairro.NotAllowNumbers();
            txt_NumeroCNH.NotAllowLetters();
            txt_NumeroCNH.NotAllowWhiteSpace();
            txt_NumeroCNH.MaxLength = 11;
            
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            CreateMotoristaCommand command = new CreateMotoristaCommand();
            //command.Name = txt_NomeMotorista.Text;
            //command.Sobrenome = txt_Sobrenome.Text;
            //command.cnh = Convert.ToInt32(txt_NumeroCNH.Text);
            //command.telefone = 1234;


            command.Name = "teste";
            command.Sobrenome = "teste";
            command.cnh = 12345;
            command.telefone = 1234;
            command.cpf = "28556272063";

            ICommandResult result = _handler.Handle(command);


            

        }
    }
}
