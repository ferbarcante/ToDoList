namespace ToDoList.Models;

public class Tarefa
{
    public Tarefa(string titulo)
    {
        
        Titulo = titulo;
        Id = Guid.NewGuid();
    }
    
    public Guid Id { get; init; }
    public string Titulo { get; private set; }

    public void MudarTitulo(String titulo)
    {
        Titulo = titulo;
    }
}