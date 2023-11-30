namespace Tarefas.Domain.Entities
{
    public class Tarefa
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Titulo { get; set; } = null!;
        public bool Concluido { get; set; } = false;
    }
}