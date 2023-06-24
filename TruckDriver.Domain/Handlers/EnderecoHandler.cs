using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.EnderecoCommands;
using TruckDriver.Domain.Commands.EnderecoCommands.Validations;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Domain.Handlers
{
    public class EnderecoHandler
    {
        private IEnderecoRepository _repository;

        public EnderecoHandler(IEnderecoRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateEnderecoCommand command)
        {
            CreateEnderecoValidation validator = new CreateEnderecoValidation();
            ValidationResult result = validator.Validate(command);

            if (!result.IsValid)
                return new GenericCommandResult(false, "Nao foi possivel criar novo endereço", result.Errors);

            Endereco endereco = new Endereco(command.Fk_motorista_id, command.Cep, command.logradouro, command.complemento, command.bairro, command.cidade, command.estado);

            _repository.Creat(endereco);

            return new GenericCommandResult(true, "Usuario criado com sucesso", result.Errors);
        }
    }
}
