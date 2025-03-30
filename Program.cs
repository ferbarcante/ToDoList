using ToDoList.Data;
using ToDoList.Routes;
using ToDoList.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<TarefaContext>(); //injetando a conexão do bd
builder.Services.AddScoped<TarefaService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.TarefaRoutes();

app.UseHttpsRedirection();
app.Run();
 