using MediatR;
using Tarefas.Application.Common.Interfaces.Persistence;
using Tarefas.Application.Tarefa.Common;

namespace Tarefas.Application.Tarefa.Queries.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQuery, List<TarefaResult>>
    {
        private readonly ITarefaRepository _tarefaRepository;

        public GetAllQueryHandler(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public async Task<List<TarefaResult>> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var tarefas = _tarefaRepository.GetAll();

            var result = new List<TarefaResult>();

            if (tarefas is null)
            {
                return result;
            }

            foreach (var tarefa in tarefas)
            {
                TarefaResult tarefaResult = new(tarefa);

                result.Add(tarefaResult);
            }

            return result;
        }
    }
}