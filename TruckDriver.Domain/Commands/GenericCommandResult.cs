﻿using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands.Contracts;

namespace TruckDriver.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult(bool success, string message, object data)
        {
            Success = success;
            Message = message;
            Data = data;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }
}
