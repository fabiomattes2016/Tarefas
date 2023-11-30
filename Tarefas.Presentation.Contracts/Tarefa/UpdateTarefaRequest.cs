namespace Tarefas.Presentation.Contracts.Tarefa
{
    public record UpdateTarefaRequest(Guid Id, string Titulo, bool Concluido);
}