using Tarefas.Domain.Common.Models;

namespace Tarefas.Domain.TarefaAggregate.ValueObjects
{
    public sealed class TarefaId : ValueObject
    {
        private TarefaId(Guid value)
        {
            Value = value;
        }

        public Guid Value { get; }

        public static TarefaId CreateUniqueId()
        {
            return new(Guid.NewGuid());
        }

        public override IEnumerable<object> GetEqualityComponents()
        {
            throw new NotImplementedException();
        }
    }
}