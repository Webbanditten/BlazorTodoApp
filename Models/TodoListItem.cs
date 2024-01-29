
namespace BlazorApp.Models;
public class TodoListItem
{
  public string Title { get; set; } = string.Empty;
  public TodoListItemMetadata Metadata { get; set; } = new TodoListItemMetadata();
}
