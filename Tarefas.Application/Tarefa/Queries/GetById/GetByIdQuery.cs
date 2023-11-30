using ErrorOr;
using MediatR;
using Tarefas.Application.Tarefa.Common;

namespace Tarefas.Application.Tarefa.Queries.GetById
{
    public record GetByIdQuery(Guid Id) : IRequest<ErrorOr<TarefaResult>>;
}