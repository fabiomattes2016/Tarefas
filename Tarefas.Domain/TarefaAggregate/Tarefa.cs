using Tarefas.Domain.Common.Models;
using Tarefas.Domain.TarefaAggregate.ValueObjects;

namespace Tarefas.Domain.TarefaAggregate
{
    public sealed class Tarefa : AggregateRoot<TarefaId>
    {
        public string Titulo { get; }
        public bool Concluido { get; }
        public DateTime? CriadoEm { get; }
        public DateTime? AtualizadoEm { get; set; }

        private Tarefa(
            TarefaId id,
            string titulo,
            bool concluido,
            DateTime? criadoEm,
            DateTime? atualizadoEm
        ) : base(id)
        {
            Titulo = titulo;
            Concluido = concluido;
            CriadoEm = criadoEm;
            AtualizadoEm = atualizadoEm;
        }

        public static Tarefa Create(
            string titulo,
            bool concluido,
            DateTime? criadoEm,
            DateTime? atualizadoEm
        )
        {
            return new(
                TarefaId.CreateUniqueId(),
                titulo,
                false,
                DateTime.UtcNow,
                null
            );
        }
    }
}