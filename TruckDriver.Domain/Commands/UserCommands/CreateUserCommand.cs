﻿

using TruckDriver.Domain.Commands.Contracts;

namespace TruckDriver.Domain.Commands.UserCommands
{
    public class CreateUserCommand : ICommand
    {


        public CreateUserCommand() { }

        public CreateUserCommand(string name, string password, string repeatPassword)
        {
            Name = name;
            Password = password;
            RepeatPassword = repeatPassword;



        }

        public string Name { get; set; }

        public string Password { get; set; }

        public string RepeatPassword { get; set; }





    }
}
