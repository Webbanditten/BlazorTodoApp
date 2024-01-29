
namespace BlazorApp.Services;
using BlazorApp.Models;
public interface IDummyDataService
{
  public Task<IEnumerable<TodoListItem>> GetRandomTodoItems(int count);
}
