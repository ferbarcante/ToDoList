namespace ToDoList.Routes;

public static class TarefaRoute
{
    // metodo para buscar todas as rotas
    public static void TarefaRoutes(WebApplication app)
    {
        app.MapGet("tarefa", () => "Teste");
    }
}