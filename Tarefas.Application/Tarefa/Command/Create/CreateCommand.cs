using ErrorOr;
using MediatR;

namespace Tarefas.Application.Tarefa.Command.Create
{
    public record CreateCommand(string Titulo) : IRequest<ErrorOr<Domain.TarefaAggregate.Tarefa>>;
}