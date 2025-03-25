var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// como um endpoint de uma minimal api funciona, rota e handler
app.MapGet("tarefa", () => "Olá");
// post, put, delete, patch...

app.UseHttpsRedirection();
app.Run();
