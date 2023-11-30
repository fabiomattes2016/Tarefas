using Microsoft.AspNetCore.Mvc.Infrastructure;
using Tarefas.Presentation.Api.Common.Errors;
using Tarefas.Presentation.Api.Common.Mapping;

namespace Tarefas.Presentation.Api
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<ProblemDetailsFactory, TarefasProblemDetailsFactory>();
            services.AddMappings();

            return services;
        }
    }
}