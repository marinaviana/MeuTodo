using MeuTodo.Data;
using MeuTodo.ViewModels;
{
     
}
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>();


var app = builder.Build();

app.MapGet("v1/todos", (AppDbContext context) => {
    // var todo = new ToDo(Guid.NewGuid(), "Ir a academia", false);
    var todos = context.ToDos.ToList();
    return Results.Ok(todos);
});

app.MapPost("v1/todos", (CreateTodoViewModel model, AppDbContext context) => {
    var todo = model.MapTod();
    context.ToDos.Add(todo);
    context.SaveChanges();
});

app.Run();
