using MediatR;

namespace Tarefas.Application.Tarefa.Command.Delete
{
    public record DeleteCommand(Guid Id) : IRequest;
}