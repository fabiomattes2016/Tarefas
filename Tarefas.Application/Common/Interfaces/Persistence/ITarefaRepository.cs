namespace Tarefas.Application.Common.Interfaces.Persistence
{
    public interface ITarefaRepository
    {
        List<Domain.Entities.Tarefa>? GetAll();
        Domain.Entities.Tarefa? GetById(Guid id);
        void Add(Domain.TarefaAggregate.Tarefa tarefa);
        void Update(Domain.Entities.Tarefa tarefa);
        void Delete(Guid id);
    }
}