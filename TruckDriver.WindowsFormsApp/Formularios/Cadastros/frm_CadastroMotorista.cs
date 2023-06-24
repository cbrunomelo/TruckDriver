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
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.EnderecoCommands;
using TruckDriver.Domain.Commands.MotoristaCommands;
using TruckDriver.Domain.Handlers;
using TruckDriver.Infra.ADO;

namespace WindowsFormsApp1.Formularios.Cadastros
{
    public partial class frm_CadastroMotorista : Form
    {
        private readonly MotoristaHandler _handler;
        private readonly EnderecoHandler _enderecoHandler;
        
        public frm_CadastroMotorista()
        {
            InitializeComponent();
            AtualizarControles();
            _handler = new MotoristaHandler(new MotoristaRepository());
            _enderecoHandler = new EnderecoHandler(new EnderecoRepository());

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

            command.Name = txt_NomeMotorista.Text;
            command.Sobrenome = txt_Sobrenome.Text;
            command.cnh = txt_NumeroCNH.Text;
            command.telefone = mtxt_Celular.Text;
            command.cpf = mtxt_CPF.Text;


            GenericCommandResult result = (GenericCommandResult)_handler.Handle(command);


            if (!result.Success) 
            {
                string erros = "";
                foreach(var erro in (List<ValidationFailure>)result.Data)
                {
                    erros+=erro.ErrorMessage+"\n";
                }
                MessageBox.Show($"Nao foi possivel criar um novo motorista:\n{erros}", "Erro");
                return;
            }
            else
            {
                CreateEnderecoCommand createEnderecoCommand = new CreateEnderecoCommand();

                createEnderecoCommand.bairro = txt_Bairro.Text;
                createEnderecoCommand.Cep = mtxt_CEP.Text;
                createEnderecoCommand.logradouro = txt_Logradouro.Text;
                createEnderecoCommand.complemento = txt_Complemento.Text;
                createEnderecoCommand.cidade = txt_Cidade.Text;
                //createEnderecoCommand.estado = cmbEstado.SelectedItem.ToString();
                createEnderecoCommand.estado = "teste";
                createEnderecoCommand.Fk_motorista_id = (int)result.Data;

                GenericCommandResult enderecoCommandresult = (GenericCommandResult)_enderecoHandler.Handle(createEnderecoCommand);



                MessageBox.Show("Motorista Criado com sucesso", "Sucesso");
            }

        }
    }
}
