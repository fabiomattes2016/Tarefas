using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tarefas.Application.Common.DateTimeProvider;
using Tarefas.Application.Common.Interfaces.Persistence;
using Tarefas.Infrastructure.Persistence;
using Tarefas.Infrastructure.Persistence.Repositories;
using Tarefas.Infrastructure.Services.DateTimeProvider;

namespace Tarefas.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            ConfigurationManager configuration
        )
        {
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            services.AddPersistance(configuration);

            return services;
        }

        public static IServiceCollection AddPersistance(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<TarefasDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("PostgreSQL"))
            );
            services.AddScoped<ITarefaRepository, TarefaRepository>();

            return services;
        }
    }
}