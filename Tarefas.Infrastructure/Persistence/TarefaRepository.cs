using Tarefas.Application.Common.Interfaces.Persistence;
using Tarefas.Domain.Entities;

namespace Tarefas.Infrastructure.Persistence
{
    public class TarefaRepository : ITarefaRepository
    {
        private static readonly List<Tarefa> _tarefas = [];
        private static readonly List<Domain.TarefaAggregate.Tarefa> _tarefasAgg = [];

        public void Add(Domain.TarefaAggregate.Tarefa tarefa)
        {
            _tarefasAgg.Add(tarefa);
        }

        public List<Tarefa>? GetAll()
        {
            return [.. _tarefas];
        }

        public Tarefa? GetById(Guid id)
        {
            return _tarefas.SingleOrDefault(t => t.Id == id);
        }

        public void Update(Tarefa tarefa)
        {
            var selected = _tarefas.SingleOrDefault(t => t.Id == tarefa.Id);

            if (selected is not null)
            {
                _tarefas.Remove(selected);
            }

            _tarefas.Add(tarefa);
        }

        public void Delete(Guid id)
        {
            var selected = _tarefas.SingleOrDefault(t => t.Id == id);

            if (selected is not null)
            {
                _tarefas.Remove(selected);
            }
        }
    }
}