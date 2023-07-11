using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.UserCommands;
using TruckDriver.Domain.Commands.UserCommands.Validations;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Queries;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Domain.Handlers
{
    public class UserHandler
    {
        private readonly IUserRepository _repository;
        private readonly IUserQuery _userquery;
        public UserHandler(IUserRepository repository)
        {
            _repository = repository;            

        }

        public UserHandler(IUserQuery userquery)
        {
            _userquery = userquery;
        }

        public ICommandResult Handle(CreateUserCommand command) 
        {
            CreatUserValidation validator = new CreatUserValidation();
            ValidationResult result = validator.Validate(command);

            if(!result.IsValid) 
                return new GenericCommandResult(false, "Nao foi possivel criar usuario", result.Errors);

            User user = new User(command.Name, command.Password);

            _repository.Creat(user);
            
            return new GenericCommandResult(true, "Usuario criado com sucesso", result.Errors);

        }

        public ICommandResult Handle(string name, string password) 
        {
            User user = _userquery.GetByName(name);

            if(user == null)
                return new GenericCommandResult(false, "Usuario ou senha invalida", null);


            if (user.VerifyPassword(password))
                return new GenericCommandResult(true, "Usuario autenticado", null);

            return new GenericCommandResult(false, "Usuario ou senha invalida", null);

            
        }
    }
}
