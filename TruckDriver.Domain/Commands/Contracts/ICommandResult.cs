using System;
using System.Collections.Generic;
using System.Text;

namespace TruckDriver.Domain.Commands.Contracts
{
    public interface ICommandResult
    {
        int Id { get; set; }
        bool Success { get; set; }
        string Message { get; set; }
        object Data { get; set; }
        IEnumerable<string> Erros { get; set; }
    }
}
