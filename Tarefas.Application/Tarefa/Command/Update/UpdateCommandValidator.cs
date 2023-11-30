using FluentValidation;

namespace Tarefas.Application.Tarefa.Command.Update
{
    public class UpdateCommandValidator : AbstractValidator<UpdateCommand>
    {
        public UpdateCommandValidator()
        {
            RuleFor(x => x.Titulo)
                .NotEmpty().WithMessage("Título não pode ser vazio!")
                .NotNull().WithMessage("Título não pode ser nulo!");
            RuleFor(x => x.Concluido)
                .NotNull().WithMessage("Defina se a tarefa foi ou não concluída");
        }
    }
}