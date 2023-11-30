using MediatR;
using Tarefas.Application.Tarefa.Common;

namespace Tarefas.Application.Tarefa.Queries.GetAll
{
    public record GetAllQuery() : IRequest<List<TarefaResult>>;
}