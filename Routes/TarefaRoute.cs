using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Routes;

public static class TarefaRoute
{
    // metodo para buscar todas as rotas
    public static void TarefaRoutes(this WebApplication app)
    {
        var route = app.MapGroup("tarefa");

        route.MapPost("",
            async (TarefaRequest req, TarefaContext context) =>
            {
                var tarefa = new Tarefa(req.titulo);
                await context.AddAsync(tarefa);
                await context.SaveChangesAsync();
            });
        
        route.MapGet("", () => );
        route.MapDelete("", () => );
    }
}