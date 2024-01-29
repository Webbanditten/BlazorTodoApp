
namespace BlazorApp.Services;

using BlazorApp.Models;
public class DummyDataService : IDummyDataService
{

  Task<List<TodoListItem>> IDummyDataService.GetRandomTodoItems(int count)
  {
    var titles = new String[] { "Buy milk", "Buy eggs", "Buy bread", "Buy butter", "Buy cheese", "Buy coffee", "Buy tea", "Buy sugar", "Buy salt", "Buy pepper", "Buy flour", "Buy rice", "Buy pasta", "Buy potatoes", "Buy tomatoes", "Buy onions", "Buy garlic", "Buy apples", "Buy oranges", "Buy bananas", "Buy pears", "Buy grapes", "Buy lemons", "Buy limes", "Buy pineapples", "Buy strawberries", "Buy raspberries", "Buy blueberries", "Buy cherries", "Buy peaches", "Buy plums", "Buy apricots", "Buy melons", "Buy watermelons", "Buy cucumbers", "Buy carrots", "Buy celery", "Buy broccoli", "Buy cauliflower", "Buy lettuce", "Buy spinach", "Buy kale", "Buy cabbage", "Buy mushrooms", "Buy peppers", "Buy olives", "Buy pickles", "Buy pickled cucumbers", "Buy pickled tomatoes", "Buy pickled onions", "Buy pickled garlic", "Buy pickled carrots", "Buy pickled peppers", "Buy pickled olives", "Buy pickled eggs", "Buy pickled beets", "Buy pickled cauliflower", "Buy pickled cabbage", "Buy pickled mushrooms", "Buy pickled gherkins", "Buy pickled jalapenos", "Buy pickled lemons", "Buy pickled limes", "Buy pickled cucamelons", "Buy pickled watermelons", "Buy pickled cherries", "Buy pickled plums", "Buy pickled apricots", "Buy pickled peaches", "Buy pickled pears", "Buy pickled pineapples", "Buy pickled strawberries", "Buy pickled raspberries", "Buy pickled blueberries" };
    var random = new Random();
    var todoItems = new List<TodoListItem>();
    for (var i = 0; i < count; i++)
    {
      var title = titles[random.Next(titles.Length)];
      var isDone = random.Next(2) == 0;
      var createdAt = DateTime.Now.AddDays(-random.Next(30));
      DateTime? completedAt = isDone ? createdAt.AddDays(random.Next(30)) : null;

      var todoListItem = new TodoListItem { Id = Guid.NewGuid(), Title = title, Metadata = new TodoListItemMetadata { IsDone = isDone, CreatedAt = createdAt, CompletedAt = completedAt } };
      todoItems.Add(todoListItem);
    }
    return Task.FromResult(todoItems);
  }
}
