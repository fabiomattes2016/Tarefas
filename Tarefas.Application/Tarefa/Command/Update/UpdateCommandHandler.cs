using ErrorOr;
using MediatR;
using Tarefas.Application.Common.Interfaces.Persistence;
using Tarefas.Application.Tarefa.Common;

namespace Tarefas.Application.Tarefa.Command.Update
{
    public class UpdateCommandHandler : IRequestHandler<UpdateCommand, ErrorOr<TarefaResult>>
    {
        private readonly ITarefaRepository _tarefaRepository;

        public UpdateCommandHandler(ITarefaRepository tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public async Task<ErrorOr<TarefaResult>> Handle(UpdateCommand command, CancellationToken cancellationToken)
        {
            await Task.CompletedTask;

            var tarefa = _tarefaRepository.GetById(command.Id);

            if (tarefa is null)
            {
                return Domain.Common.Errors.Errors.Tarefa.TarefaNotFound;
            }

            tarefa.Titulo = command.Titulo;
            tarefa.Concluido = command.Concluido;

            _tarefaRepository.Update(tarefa);

            return new TarefaResult(tarefa);
        }
    }
}