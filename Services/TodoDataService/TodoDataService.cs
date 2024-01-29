using BlazorApp.Models;
using BlazorApp.Services;
using Blazored.LocalStorage;

namespace BlazorApp.Services
{
  public class TodoDataService : ITodoDataService
  {
    private readonly ILocalStorageService localStorage;

    public TodoDataService(ILocalStorageService localStorage)
    {
      this.localStorage = localStorage;
    }
    public async Task<TodoListItem> AddTodoItem(TodoListItem todoItem)
    {
      var todoListItems = await GetTodoItems();
      todoListItems.Add(todoItem);

      await localStorage.SetItemAsync("items", todoListItems);
      return todoItem;
    }

    public async Task DeleteTodoItem(Guid id)
    {
      var todoListItems = await GetTodoItems();
      todoListItems.RemoveAll(x => x.Id == id);

      await localStorage.SetItemAsync("items", todoListItems);
    }

    public async Task<TodoListItem?> GetTodoItem(Guid id)
    {
      var todoListItems = await GetTodoItems();
      return todoListItems.FirstOrDefault(x => x.Id == id);
    }

    public async Task<List<TodoListItem>> GetTodoItems()
    {
      try
      {
        var todoListItems = await localStorage.GetItemAsync<List<TodoListItem>>("items") ?? [];
        return todoListItems;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        return [];
      }
    }

    public async Task SaveTodoItems(List<TodoListItem> todoListItems)
    {
      await localStorage.SetItemAsync("items", todoListItems);
    }

    public async Task<TodoListItem> UpdateTodoItem(TodoListItem todoItem)
    {
      var todoListItems = await GetTodoItems();
      var index = todoListItems.FindIndex(x => x.Id == todoItem.Id);
      todoListItems[index] = todoItem;

      await localStorage.SetItemAsync("items", todoListItems);
      return todoItem;
    }
  }
}
