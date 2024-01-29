
namespace BlazorApp.Services;
using BlazorApp.Models;
public interface IDummyDataService
{
  public Task<List<TodoListItem>> GetRandomTodoItems(int count);
}
