﻿using System;
using System.Collections.Generic;
using System.Text;
using TruckDriver.Domain.Commands.Contracts;

namespace TruckDriver.Domain.Commands
{
    public class GenericCommandResult : ICommandResult
    {
        public GenericCommandResult(bool success, string message, IEnumerable<string> erros, object data = null)
        {
            Success = success;
            Message = message;
            Data = data;
            Erros = erros;
        }

        public GenericCommandResult(bool success, string message, string erro = "", object data = null )
        {
            Success = success;
            Message = message;
            Data = data;
            Erros = new[] {erro};
        }



        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
        public IEnumerable<string> Erros { get; set; } 
    }
}
