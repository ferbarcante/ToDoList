using Microsoft.EntityFrameworkCore;
using ToDoList.Models;

namespace ToDoList.Data;

public class TarefaContext : DbContext
{
    public DbSet<Tarefa> Tarefas { get; init; } // representação da tabela em memória

    // configurar como será nosso provider do bd
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=tarefa.sqlite");
        base.OnConfiguring(optionsBuilder);
    }
}