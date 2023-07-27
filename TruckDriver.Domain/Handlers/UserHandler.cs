using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TruckDriver.Domain.Commands;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Commands.UserCommands;
using TruckDriver.Domain.Commands.UserCommands.Validations;
using TruckDriver.Domain.Entitys;
using TruckDriver.Domain.Extensions;
using TruckDriver.Domain.Handlers.Contracts;
using TruckDriver.Domain.MessageConstants;
using TruckDriver.Domain.Queries;
using TruckDriver.Domain.Repository;

namespace TruckDriver.Domain.Handlers
{
    public class UserHandler : IUserHandle, IUserQuery
    {
        private readonly IUserRepository _repository;
        private readonly IUserQuery _userquery;
        public UserHandler(IUserRepository repository, IUserQuery userquery)
        {
            _repository = repository;
            _userquery = userquery;

        }

        public User GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<ICommandResult> Handle(CreateUserCommand command) 
        {
            CreatUserValidation validator = new CreatUserValidation();
            ValidationResult result = validator.Validate(command);

            if (!result.IsValid) 
                return new GenericCommandResult(false, MessageConstant.UNABLE_TO_CREATE, result.ToList());

            User user = new User(command.Name, command.Password);

            _repository.Creat(user);
            
            return new GenericCommandResult(true, MessageConstant.CREATED_SUCCESSFULLY, result.ToList());

        }

        public async Task<ICommandResult> Handle(string name, string password) 
        {
            User user = _userquery.GetByName(name);

            if(user == null)
                return new GenericCommandResult(false, MessageConstant.INVALID_USER_OR_PASSWORD);


            if (user.VerifyPassword(password))
                return new GenericCommandResult(true, MessageConstant.USER_AUTHENTICATED);

            return new GenericCommandResult(false, MessageConstant.INVALID_USER_OR_PASSWORD);

            
        }

        public async Task<ICommandResult> Handle(UpdateUserCommand command)
        {
            throw new NotImplementedException();
        }

        public async Task<ICommandResult> Handle(DeleteUserCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
