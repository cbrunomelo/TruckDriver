using FluentValidation;

namespace TruckDriver.Domain.Commands.UserCommands.Validations
{
    public class CreatUserValidation : AbstractValidator<CreateUserCommand>
    {
        public CreatUserValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Nome nao pode ser vazio");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Senha nao pode ser vazia");
            RuleFor(x => x.RepeatPassword).Equal(x => x.Password).WithMessage("As senhas digitadas não são iguais.");
        }
    }
}
