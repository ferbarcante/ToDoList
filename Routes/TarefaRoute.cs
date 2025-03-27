using ToDoList.Models;

namespace ToDoList.Routes;

public static class TarefaRoute
{
    // metodo para buscar todas as rotas
    public static void TarefaRoutes(this WebApplication app)
    {
        app.MapGet("tarefa", () => new Tarefa("fernanda"));
    }
}