using Mapster;
using Tarefas.Application.Tarefa.Command.Create;
using Tarefas.Domain.TarefaAggregate;
using Tarefas.Presentation.Contracts.Tarefa;

namespace Tarefas.Presentation.Api.Common.Mapping
{
    public class TarefaMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            // config.NewConfig<UpdateTarefaRequest, UpdateCommand>();
            config.NewConfig<CreateTarefaRequest, CreateCommand>()
                .Map(dest => dest, src => src);

            config.NewConfig<Tarefa, TarefaResponse>()
                .Map(dest => dest.Id, src => src.Id.Value);
        }
    }
}