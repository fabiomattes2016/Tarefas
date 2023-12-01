namespace Tarefas.Domain.Common.Models
{
    public class AggregateRoot<TId> : Entity<TId> where TId : notnull
    {
        protected AggregateRoot(TId id) : base(id)
        {
        }


#pragma warning disable CS8618
        protected AggregateRoot() { }
#pragma warning restore CS8618
    }
}