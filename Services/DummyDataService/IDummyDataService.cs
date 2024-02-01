
namespace BlazorApp.Services;
using BlazorApp.Models;
public interface IDummyDataService
{
  public List<TodoListItem> GetRandomTodoItems(int count);
}
