using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Services;

public class TarefaService
{
    private readonly TarefaContext _context;

    public TarefaService(TarefaContext context)
    {
        _context = context;
    }
    
    public async Task<Tarefa> CriarTarefa(String titulo)
    {
        if (string.IsNullOrWhiteSpace(titulo))
        {
            throw new ArgumentException("O título não pode ser vazio.");
        }
        
        var tarefa = new Tarefa(titulo);
        await _context.AddAsync(tarefa);
        await _context.SaveChangesAsync();
        
        return tarefa;
    }
}