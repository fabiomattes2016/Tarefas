using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tarefas.Domain.TarefaAggregate;
using Tarefas.Domain.TarefaAggregate.ValueObjects;

namespace Tarefas.Infrastructure.Persistence.Configurations
{
    public class TarefaConfigurations : IEntityTypeConfiguration<Tarefa>
    {
        public void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            ConfigureTarefasTable(builder);
        }

        private static void ConfigureTarefasTable(EntityTypeBuilder<Tarefa> builder)
        {
            builder.ToTable("tarefas");
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).HasConversion(id => id.Value, value => TarefaId.Create(value));
            builder.Property(t => t.Titulo).HasMaxLength(200);
            builder.Property(t => t.Concluido).HasDefaultValue(false);
        }
    }
}