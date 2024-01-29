using BlazorApp.Models;

namespace BlazorApp.Services
{
  public interface ITodoDataService
  {
    Task SaveTodoItems(List<TodoListItem> todoListItems);
    Task<List<TodoListItem>> GetTodoItems();
    Task<TodoListItem?> GetTodoItem(Guid id);
    Task<TodoListItem> AddTodoItem(TodoListItem todoItem);
    Task<TodoListItem> UpdateTodoItem(TodoListItem todoItem);
    Task DeleteTodoItem(Guid id);
    Task ClearTodoItems();
  }
}
