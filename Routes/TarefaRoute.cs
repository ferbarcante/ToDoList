using ToDoList.Data;
using ToDoList.Models;
using ToDoList.Services;

namespace ToDoList.Routes;

public static class TarefaRoute
{
    // metodo para buscar todas as rotas
    public static void TarefaRoutes(this WebApplication app)
    {
        var route = app.MapGroup("tarefa");

        route.MapPost("",
            async (TarefaRequest req, TarefaService service) =>
            {
                var criarTarefa = await service.CriarTarefa(req.titulo);
            });
        
        route.MapGet("", 
            async (TarefaContext context) =>
            {
                
            });
       
        // route.MapDelete("", () => );
    }
}