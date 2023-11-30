using ErrorOr;
using MediatR;
using Tarefas.Application.Common.Interfaces.Persistence;

namespace Tarefas.Application.Tarefa.Command.Create
{
    public class CreateCommandHandler : IRequestHandler<CreateCommand, ErrorOr<Domain.TarefaAggregate.Tarefa>>
    {
        private readonly ITarefaRepository _tarefaRepository;

        public CreateCommandHandler(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public async Task<ErrorOr<Domain.TarefaAggregate.Tarefa>> Handle(CreateCommand command, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var tarefa = Domain.TarefaAggregate.Tarefa.Create(titulo: command.Titulo, concluido: false, DateTime.UtcNow, null);

            _tarefaRepository.Add(tarefa);

            return tarefa!;
        }
    }
}