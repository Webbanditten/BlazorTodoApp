namespace BlazorApp.Models;
public class TodoList
{
  public string Title { get; set; } = string.Empty;
  public List<TodoListItem> Items { get; set; } = new List<TodoListItem>();
}
