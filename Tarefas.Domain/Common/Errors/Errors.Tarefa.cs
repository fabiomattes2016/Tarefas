
using ErrorOr;

namespace Tarefas.Domain.Common.Errors
{
    public static partial class Errors
    {
        public static class Tarefa
        {
            public static Error TarefaNotFound => Error.NotFound(code: "Tarefa.NotFound", description: "Tarefa não encontrada!");
        }
    }
}