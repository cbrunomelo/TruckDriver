using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.UserCommands;
using TruckDriver.Domain.Commands.UserCommands.Validations;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Domain.Handlers
{
    public class UserHandler
    {
        private readonly IUserRepository _repository;
        public UserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateUserCommand command) 
        {
            CreatUserValidation validator = new CreatUserValidation();
            ValidationResult result = validator.Validate(command);

            if(!result.IsValid) 
                return new GenericCommandResult(false, "Nao foi possivel criar usuario", result.Errors);

            User user = new User(command.Name, command.Password);

            _repository.CreateUser(user);
            
            return new GenericCommandResult(true, "Usuario criado com sucesso", result.Errors);



        }
    }
}
