
namespace BlazorApp.Models;

public class TodoListItemMetadata
{
  public bool IsDone { get; set; }
  public DateTime CreatedAt { get; set; }
  public DateTime? CompletedAt { get; set; }
}
