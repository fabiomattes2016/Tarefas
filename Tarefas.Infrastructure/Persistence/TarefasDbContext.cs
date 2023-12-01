using Microsoft.EntityFrameworkCore;
using Tarefas.Domain.TarefaAggregate;

namespace Tarefas.Infrastructure.Persistence
{
    public class TarefasDbContext : DbContext
    {
        public TarefasDbContext(DbContextOptions<TarefasDbContext> options) : base(options)
        { }

        public DbSet<Tarefa> Tarefas { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TarefasDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}