using ErrorOr;
using MediatR;
using Tarefas.Application.Tarefa.Common;

namespace Tarefas.Application.Tarefa.Command.Update
{
    public record UpdateCommand(Guid Id, string Titulo, bool Concluido) : IRequest<ErrorOr<TarefaResult>>;
}