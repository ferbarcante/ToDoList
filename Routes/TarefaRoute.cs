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
                return Results.Ok(criarTarefa);
            });
        
        route.MapGet("", 
            async (TarefaService service) =>
            {
                var buscarTarefas = await service.BuscarTarefas();
                return Results.Ok(buscarTarefas);
            });

        route.MapPut(pattern: "{id:guid}",
            async (TarefaService service, TarefaRequest req, Guid id) =>
            {
                var atualizarTarefa = await service.AtualizarTarefa(id, req);
                
                if (atualizarTarefa == null)
                    return Results.NotFound();
                
                return Results.Ok(atualizarTarefa);
            });

        route.MapDelete("{id:guid",
            async (TarefaRequest req, Guid id, TarefaContext context, TarefaService service) =>
            {
                var deletarTarefa = await service.ExcluirTarefa(id);
                
                if(deletarTarefa == null)
                    return  Results.NotFound();

                return deletarTarefa;
            });
    }
}