using System.Net.NetworkInformation;

namespace TruckDriver.Domain.MessageConstants
{
    public static class MessageConstant
    {
        public static string UNABLE_TO_CREATE = "Nao foi possivel criar";

        public static string INVALID_USER_OR_PASSWORD = "Usuario ou senha invalida";

        public static string CREATED_SUCCESSFULLY = "criado com sucesso";

        public static string NAME_CANNOT_BE_EMPTY = "Nome não pode ser vazio";

        public static string PASSWORD_CANNOT_BE_EMPTY = "Senha nao pode ser vazia";

        public static string PASSWORDS_DO_NOT_MATCH = "As senhas digitadas não são iguais";

        public static string USER_AUTHENTICATED = "Usuario autenticado";
    }
}
