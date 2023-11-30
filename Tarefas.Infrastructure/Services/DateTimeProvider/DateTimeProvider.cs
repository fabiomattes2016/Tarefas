using Tarefas.Application.Common.DateTimeProvider;

namespace Tarefas.Infrastructure.Services.DateTimeProvider
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
    }
}