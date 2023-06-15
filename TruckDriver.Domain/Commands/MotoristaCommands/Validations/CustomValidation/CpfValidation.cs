using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TruckDriver.Domain.Commands.MotoristaCommands.Validations.CustomValidation
{
    public static class CpfValidation
    {

        public static bool Validar(string cpf)
        {
            // Remova caracteres especiais do CPF, mantendo apenas os dígitos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // CPF deve ter 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verificação do primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            }

            int resto = soma % 11;
            int digitoVerificador1 = (resto < 2) ? 0 : 11 - resto;

            if (int.Parse(cpf[9].ToString()) != digitoVerificador1)
            {
                return false;
            }

            // Verificação do segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            }

            resto = soma % 11;
            int digitoVerificador2 = (resto < 2) ? 0 : 11 - resto;

            if (int.Parse(cpf[10].ToString()) != digitoVerificador2)
            {
                return false;
            }

            return true;
        }
    }
}
