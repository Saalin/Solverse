using FluentValidation;

namespace Solverse.Application.Commands
{
    public class CreateExampleCommandValidator : AbstractValidator<CreateExampleCommand>
    {
        public CreateExampleCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}
