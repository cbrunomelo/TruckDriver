using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands.Contracts;
using TruckDriver.Domain.Entitys;

namespace TruckDriver.Domain.Commands.UserCommands
{
    public class CreateUserCommand
    {


        public CreateUserCommand() { }

        public CreateUserCommand(string name, string password)
        {
            Name = name;
            Password = password;
            

        }

        public string Name { get; set; }

        public string Password { get; set; }





    }
}
