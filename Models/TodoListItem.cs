
namespace BlazorApp.Models;
public class TodoListItem
{
  public Guid Id { get; set; }
  public string Title { get; set; } = string.Empty;
  public TodoListItemMetadata Metadata { get; set; } = new TodoListItemMetadata();
}
