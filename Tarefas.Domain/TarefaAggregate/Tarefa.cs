using Tarefas.Domain.Common.Models;
using Tarefas.Domain.TarefaAggregate.ValueObjects;

namespace Tarefas.Domain.TarefaAggregate
{
    public sealed class Tarefa : AggregateRoot<TarefaId>
    {
        public string Titulo { get; private set; }
        public bool Concluido { get; private set; }
        public DateTime? CriadoEm { get; private set; }
        public DateTime? AtualizadoEm { get; private set; }


#pragma warning disable CS8618
        private Tarefa() { }
#pragma warning restore CS8618

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