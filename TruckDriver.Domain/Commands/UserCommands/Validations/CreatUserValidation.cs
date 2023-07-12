using FluentValidation;
using TruckDriver.Domain.MessageConstants;

namespace TruckDriver.Domain.Commands.UserCommands.Validations
{
    public class CreatUserValidation : AbstractValidator<CreateUserCommand>
    {
        public CreatUserValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(MessageConstant.NAME_CANNOT_BE_EMPTY);
            RuleFor(x => x.Password).NotEmpty().WithMessage(MessageConstant.PASSWORD_CANNOT_BE_EMPTY);
            RuleFor(x => x.RepeatPassword).Equal(x => x.Password).WithMessage(MessageConstant.PASSWORDS_DO_NOT_MATCH);
        }
    }
}
