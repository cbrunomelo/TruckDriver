using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.EnderecoCommands;
using TruckDriver.Domain.Commands.MotoristaCommands;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Handlers;
using TruckDriver.Domain.Handlers.Contracts;
using TruckDriver.Domain.Services;
using TruckDriver.WindowsFormsApp.Services;

namespace WindowsFormsApp1.Formularios.Cadastros
{
    public partial class frm_CadastroMotorista : Form
    {
        private readonly IMotoristaHandle _motoristaHandler;
        private readonly ICepService _cepService;

        public frm_CadastroMotorista()
        {
            InitializeComponent();
            AtualizarControles();

            _motoristaHandler = AppContainer.ServiceProvider.GetService<IMotoristaHandle>();
            _cepService = AppContainer.ServiceProvider.GetService<ICepService>();
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

        private async void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            CreateMotoristaCommand command = new CreateMotoristaCommand();

            command.Name = txt_NomeMotorista.Text;
            command.Sobrenome = txt_Sobrenome.Text;
            command.cnh = txt_NumeroCNH.Text;
            command.telefone = mtxt_Celular.Text;
            command.cpf = mtxt_CPF.Text;

            command.enderecoCommand = new CreateEnderecoCommand()
            {
                Bairro = txt_Bairro.Text,
                Cep = mtxt_CEP.Text,
                Logradouro = txt_Logradouro.Text,
                Complemento = txt_Complemento.Text,
                Cidade = txt_Cidade.Text,
                Estado = txt_estado.Text
            };


            ICommandResult result = await _motoristaHandler.Handle(command);


            if (!result.Success)
            {
                string erros = "";
                foreach (var erro in (List<ValidationFailure>)result.Data)
                {
                    erros += erro.ErrorMessage + "\n";
                }
                MessageBox.Show($"Nao foi possivel criar um novo motorista:\n{erros}", "Erro");
                return;
            }

            MessageBox.Show("Motorista Criado com sucesso", "Sucesso");


        }

        private async void mtxt_CEP_Leave(object sender, EventArgs e)
        {
            Endereco endereco = await _cepService.BuscaCep(mtxt_CEP.Text);

            txt_Logradouro.Text = endereco.Logradouro;
            txt_Bairro.Text = endereco.Bairro ;
            txt_Cidade.Text = endereco.Cidade;
            txt_estado.Text = endereco.Estado;



        }
    }
}
