﻿using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.EnderecoCommands;
using TruckDriver.Domain.Commands.MotoristaCommands;
using TruckDriver.Domain.Handlers;
using TruckDriver.Infra.ADO;
using TruckDriver.WindowsFormsApp.Services;

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



            _enderecoHandler = new EnderecoHandler(new EnderecoRepository());

            _handler = new MotoristaHandler(new MotoristaRepository(), _enderecoHandler);
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

            command.enderecoCommand = new CreateEnderecoCommand()
            {
               bairro = txt_Bairro.Text,
                Cep = mtxt_CEP.Text,
                logradouro = txt_Logradouro.Text,
                complemento = txt_Complemento.Text,
                cidade = txt_Cidade.Text,
                estado = txt_estado.Text
            };


            GenericCommandResult result = (GenericCommandResult)_handler.Handle(command);


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

        private void mtxt_CEP_Leave(object sender, EventArgs e)
        {
            Dictionary<string, string> buscaCep = CepAutocomplete.BuscaCep(mtxt_CEP.Text);

            txt_Logradouro.Text = buscaCep["logradouro"];
            txt_Bairro.Text = buscaCep["bairro"];
            txt_Cidade.Text = buscaCep["cidade"];
            txt_estado.Text = buscaCep["estado"];



        }
    }
}
