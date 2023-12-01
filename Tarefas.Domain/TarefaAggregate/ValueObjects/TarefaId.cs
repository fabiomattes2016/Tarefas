using Tarefas.Domain.Common.Models;

namespace Tarefas.Domain.TarefaAggregate.ValueObjects
{
    public sealed class TarefaId : ValueObject
    {
        private TarefaId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; private set; }

        public static TarefaId CreateUniqueId()
        {
            return new(Guid.NewGuid());
        }

        public static TarefaId Create(Guid value)
        {
            return new TarefaId(value);
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value;
        }
    }
}