using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.MotoristaCommands;
using TruckDriver.Domain.Commands.MotoristaCommands.Validations;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Domain.Handlers
{
    public class MotoristaHandler
    {
        private IMotoristaRepository _repository;

        public MotoristaHandler(IMotoristaRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateMotoristaCommand command)
        {
            CreateMotoristaValidation validator = new CreateMotoristaValidation();
            ValidationResult result = validator.Validate(command);

            if (!result.IsValid)
                return new GenericCommandResult(false, "Nao foi possivel criar usuario", result.Errors);

            Motorista motorista = new Motorista(command.Name, command.Sobrenome, command.cpf, command.cnh, command.telefone);

            int id = _repository.Creat(motorista);

            return new GenericCommandResult(true, "Usuario criado com sucesso", id);
            
       }
    }
}
