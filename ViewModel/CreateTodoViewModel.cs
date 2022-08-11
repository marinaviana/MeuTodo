namespace MeuTodo.ViewModels
{
    public class CreateTodoViewModel
    {
        public string Title {get; set;}

        public ToDo MapTod()
        {
            return new ToDo(Guid.NewGuid(), Title, false);
        }
    }
}