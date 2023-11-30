using MediatR;
using Tarefas.Application.Common.Interfaces.Persistence;

namespace Tarefas.Application.Tarefa.Command.Delete
{
    public class DeleteCommandHandler : IRequestHandler<DeleteCommand>
    {
        private readonly ITarefaRepository _tarefaRepository;

        public DeleteCommandHandler(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public async Task<Unit> Handle(DeleteCommand command, CancellationToken cancellationToken)
        {
            _tarefaRepository.Delete(command.Id);

            return await Task.FromResult(Unit.Value);
        }
    }
}