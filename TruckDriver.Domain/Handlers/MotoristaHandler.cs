using FluentValidation.Results;
using System.Linq;
using System.Threading.Tasks;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.MotoristaCommands;
using TruckDriver.Domain.Commands.MotoristaCommands.Validations;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Extensions;
using TruckDriver.Domain.Handlers.Contracts;
using TruckDriver.Domain.MessageConstants;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Domain.Handlers
{
    public class MotoristaHandler : IMotoristaHandle
    {
        private IMotoristaRepository _repository;
        private IEnderecoHandle _enderecoHandler;

        public MotoristaHandler(IMotoristaRepository repository, IEnderecoHandle enderecoHandler)
        {
            _repository = repository;
            _enderecoHandler = enderecoHandler;
        }

        public async Task<ICommandResult> Handle(CreateMotoristaCommand command)
        {
            CreateMotoristaValidation validator = new CreateMotoristaValidation();
            ValidationResult result = validator.Validate(command);

            if (!result.IsValid)
                return new GenericCommandResult(false, MessageConstant.UNABLE_TO_CREATE, result.ToList());

            var resultEndereco = await _enderecoHandler.Handle(command.enderecoCommand);
            if (!resultEndereco.Success)
                return new GenericCommandResult(false, MessageConstant.UNABLE_TO_CREATE, resultEndereco.Erros);

            int enderecoId = resultEndereco.Id;

            Motorista motorista = new Motorista(command.Name, command.Sobrenome, command.cpf, command.cnh, command.telefone, enderecoId);

            int id = _repository.Creat(motorista);

            return new GenericCommandResult(true, MessageConstant.CREATED_SUCCESSFULLY, id);

        }

        public async Task<ICommandResult> Handle(UpdateMotoristaCommand command)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ICommandResult> Handle(DeleteMotoristaCommand command)
        {
            throw new System.NotImplementedException();
        }
    }
}
