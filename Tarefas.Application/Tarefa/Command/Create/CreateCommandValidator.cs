using FluentValidation;

namespace Tarefas.Application.Tarefa.Command.Create
{
    public class CreateCommandValidator : AbstractValidator<CreateCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(x => x.Titulo)
                .NotEmpty().WithMessage("Título não pode ser vazio!")
                .NotNull().WithMessage("Título não pode ser nulo!");
        }
    }
}