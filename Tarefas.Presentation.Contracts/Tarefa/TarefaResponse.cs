namespace Tarefas.Presentation.Contracts.Tarefa
{
    public record TarefaResponse(Guid Id, string Titulo, bool? Concluido, DateTime? CriadoEm, DateTime? AtualizadoEm);
}