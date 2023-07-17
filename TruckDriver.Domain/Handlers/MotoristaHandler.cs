using FluentValidation.Results;
using System.Linq;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.MotoristaCommands;
using TruckDriver.Domain.Commands.MotoristaCommands.Validations;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Extensions;
using TruckDriver.Domain.MessageConstants;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Domain.Handlers
{
    public class MotoristaHandler
    {
        private IMotoristaRepository _repository;
        private EnderecoHandler _enderecoHandler;

        public MotoristaHandler(IMotoristaRepository repository, EnderecoHandler enderecoHandler)
        {
            _repository = repository;
            _enderecoHandler = enderecoHandler;
        }

        public ICommandResult Handle(CreateMotoristaCommand command)
        {
            CreateMotoristaValidation validator = new CreateMotoristaValidation();
            ValidationResult result = validator.Validate(command);

            if (!result.IsValid)
                return new GenericCommandResult(false, MessageConstant.UNABLE_TO_CREATE, result.ToList());

            var resultEndereco = (GenericCommandResult)_enderecoHandler.Handle(command.enderecoCommand);
            if (!resultEndereco.Success)
                return new GenericCommandResult(false, MessageConstant.UNABLE_TO_CREATE, resultEndereco.Erros);

            int enderecoId = resultEndereco.Id;

            Motorista motorista = new Motorista(command.Name, command.Sobrenome, command.cpf, command.cnh, command.telefone, enderecoId);

            int id = _repository.Creat(motorista);

            return new GenericCommandResult(true, MessageConstant.CREATED_SUCCESSFULLY, id);

        }
    }
}
