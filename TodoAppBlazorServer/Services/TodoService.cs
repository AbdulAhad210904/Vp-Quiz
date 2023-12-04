namespace TodoAppBlazorServer.Services;

public class TodoService : ITodoService
{
    private readonly IList<TodoItem> _todoItems;

    public TodoService()
    {
        _todoItems = new List<TodoItem> {
            new TodoItem("Wash Clothes"),
            new TodoItem("Clean Desk"),
            new TodoItem("CLean Room"),
            new TodoItem("Complete Assignment")
        };
    }

    public void Add(TodoItem item)
    {
        _todoItems.Add(item);
    }

    public IEnumerable<TodoItem> GetAll()
    {
        return _todoItems.ToList();
    }

    public void Delete(TodoItem item)
    {
        _todoItems.Remove(item);
    }

    public void Complete(TodoItem item)
    {
        item.Completed = true;
    }

    public void Uncomplete(TodoItem item)
    {
        item.Completed = false;
    }
}