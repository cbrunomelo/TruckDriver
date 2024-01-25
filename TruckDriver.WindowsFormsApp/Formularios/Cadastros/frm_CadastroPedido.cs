using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TruckDriver.Domain.Commands.EnderecoCommands;
using TruckDriver.Domain.Commands.PedidosCommands;
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
            if (mtxt_CepColeta.Text.Replace("-", "").Trim() == string.Empty || 
                mtxt_CepEntrega.Text.Replace("-", "").Trim() == string.Empty)
            {
                MessageBox.Show("O campo CEP é obrigatório", "Erro");
                return;
            }

            CreatePedidoCommand command = new CreatePedidoCommand();

            command.Endereco_coleta = new CreateEnderecoCommand()
            {
                Bairro = txt_BairroColeta.Text,
                Cep = mtxt_CepColeta.Text,
                Logradouro = txt_LogradouroColeta.Text,
                Complemento = txt_ComplementoColeta.Text,
                Cidade = txt_CidadeColeta.Text,
                Estado = txt_estadoColeta.Text
            };

            command.Endereco_entrega = new CreateEnderecoCommand()
            {
                Bairro = txt_BairroEntrega.Text,
                Cep = mtxt_CepEntrega.Text,
                Logradouro = txt_LogradouroEntrega.Text,
                Complemento = txt_ComplementoEntrega.Text,
                Cidade = txt_CidadeEntrega.Text,
                Estado = txt_estadoEntrega.Text
            };

            var result =await _pedidoHandler.Handle(command);

            
            if (!result.Success)
            {
                string erros = "";
                foreach (var erro in (result.Erros))
                {
                    erros += erro + "\n";
                } 
                MessageBox.Show($"Nao foi possivel criar um novo pedido:\n{erros}", "Erro");                                    
                return;
            }
            

            MessageBox.Show("Pedido cadastrado com sucesso", "Sucesso");   


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

        private void mtxt_CepColeta_Leave(object sender, EventArgs e)
        {
            if(mtxt_CepColeta.Text.Replace("-", "").Trim() == string.Empty)
                return;

            Endereco endereco = _cepService.BuscaEnderecoPorCep(mtxt_CepColeta.Text).Result;

            txt_LogradouroColeta.Text = endereco.Logradouro;
            txt_BairroColeta.Text = endereco.Bairro;
            txt_CidadeColeta.Text = endereco.Cidade;
            txt_estadoColeta.Text = endereco.Estado;

        }
    }
}
