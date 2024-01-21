using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.EnderecoCommands;
using TruckDriver.Domain.Commands.MotoristaCommands;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Handlers.Contracts;
using TruckDriver.Domain.Services;
using TruckDriver.WindowsFormsApp.Services;

namespace TruckDriver.WindowsFormsApp.Formularios.Cadastros
{
    public partial class frm_CadastroPedido : Form
    {
        private readonly IPedidoHandle _pedidoHandler;
        private readonly ICepService _cepService;

        public frm_CadastroPedido()
        {
            InitializeComponent();
            AtualizarControles();

            _pedidoHandler = AppContainer.ServiceProvider.GetService<IPedidoHandle>();
            _cepService = AppContainer.ServiceProvider.GetService<ICepService>();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void AtualizarControles()
        {
            txt_CidadeEntrega.NotAllowNumbers();
            txt_BairroEntrega.NotAllowNumbers();
            txt_CidadeColeta.NotAllowNumbers();
            txt_BairroColeta.NotAllowNumbers();

        }

        private async void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            //CreateMotoristaCommand command = new CreateMotoristaCommand();


            //command.enderecoCommand = new CreateEnderecoCommand()
            //{
            //    Bairro = txt_BairroEntrega.Text,
            //    Cep = mtxt_CepEntrega.Text,
            //    Logradouro = txt_LogradouroEntrega.Text,
            //    Complemento = txt_ComplementoEntrega.Text,
            //    Cidade = txt_CidadeEntrega.Text,
            //    Estado = txt_estadoEntrega.Text
            //};


            //ICommandResult result = await _motoristaHandler.Handle(command);


            //if (!result.Success)
            //{
            //    string erros = "";
            //    foreach (var erro in (List<ValidationFailure>)result.Data)
            //    {
            //        erros += erro.ErrorMessage + "\n";
            //    }
            //    MessageBox.Show($"Nao foi possivel criar um novo motorista:\n{erros}", "Erro");
            //    return;
            //}

            MessageBox.Show("Motorista Criado com sucesso", "Sucesso");


        }

        private async void mtxt_CEP_Leave(object sender, EventArgs e)
        {
            if (mtxt_CepEntrega.Text.Replace("-", "").Trim() == string.Empty)
                return;

            Endereco endereco = await _cepService.BuscaEnderecoPorCep(mtxt_CepEntrega.Text);

            txt_LogradouroEntrega.Text = endereco.Logradouro;
            txt_BairroEntrega.Text = endereco.Bairro;
            txt_CidadeEntrega.Text = endereco.Cidade;
            txt_estadoEntrega.Text = endereco.Estado;


        }
    }
}
