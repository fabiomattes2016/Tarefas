namespace Tarefas.Application.Common.DateTimeProvider
{
    public interface IDateTimeProvider
    {
        DateTime UtcNow { get; }
    }
}