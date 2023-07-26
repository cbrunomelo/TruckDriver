using FluentValidation.Results;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.EnderecoCommands;
using TruckDriver.Domain.Commands.EnderecoCommands.Validations;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Extensions;
using TruckDriver.Domain.Handlers.Contracts;
using TruckDriver.Domain.MessageConstants;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Domain.Handlers
{
    public class EnderecoHandler : IEnderecoHandle
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
                return new GenericCommandResult(false, MessageConstant.UNABLE_TO_CREATE, result.ToList());

            Endereco endereco = new Endereco(command.Cep, command.Logradouro, command.Complemento, command.Bairro, command.Cidade, command.Estado);

            endereco.Id = _repository.Creat(endereco);

            return new GenericCommandResult(true, MessageConstant.CREATED_SUCCESSFULLY, endereco);
        }

        public ICommandResult Handle(UpdateEnderecoCommand command)
        {
            throw new System.NotImplementedException();
        }

        public ICommandResult Handle(DeleteEnderecoCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}
