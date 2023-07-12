using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace TruckDriver.Domain.Extensions
{
    public static class ValidationResultExtension
    {
        /// <summary>
        /// Converte um objeto ValidationResult em uma lista de mensagens de erro.
        /// </summary>
        /// <param name="validationResult">O objeto ValidationResult a ser convertido.</param>
        /// <returns>Uma lista de strings contendo as mensagens de erro.</returns>
        public static List<string> ToList(this ValidationResult validationResult)
        {            
            string errors = validationResult.ToString("/");
            List<string> errorList = new List<string>(errors.Split('/'));
            return errorList;

        }


    }
}
