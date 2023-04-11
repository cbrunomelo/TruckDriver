using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.UserCommands;
using TruckDriver.Domain.Commands.UserCommands.Validations;

namespace TruckDriver.Domain.Handlers
{
    public class UserHandler
    {
        public UserHandler()
        {
            
        }

        public ICommandResult Handle(CreateUserCommand command) 
        {
            CreatUserValidation validator = new CreatUserValidation();
            ValidationResult result = validator.Validate(command);

            if(!result.IsValid) 
                return new GenericCommandResult(false, "Nao foi possivel criar usuario", result.Errors);


            return new GenericCommandResult(true, "Usuario criado com sucesso", result.Errors);



        }
    }
}
