using ErrorOr;
using MediatR;
using Tarefas.Application.Common.Interfaces.Persistence;
using Tarefas.Application.Tarefa.Common;

namespace Tarefas.Application.Tarefa.Queries.GetById
{
    public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, ErrorOr<TarefaResult>>
    {
        private readonly ITarefaRepository _tarefaRepository;

        public GetByIdQueryHandler(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public async Task<ErrorOr<TarefaResult>> Handle(GetByIdQuery command, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var tarefa = _tarefaRepository.GetById(command.Id);

            if (tarefa is null)
            {
                return Domain.Common.Errors.Errors.Tarefa.TarefaNotFound;
            }

            var result = new TarefaResult(tarefa);

            return result;
        }
    }
}