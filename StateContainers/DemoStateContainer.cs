namespace BlazorApp.StateContainers;
public class DemoStateContainer
{
  private string? savedString;

  public string Property
  {
    get => savedString ?? string.Empty;
    set
    {
      savedString = value;
      NotifyStateChanged();
    }
  }

  public event Action? OnChange;

  private void NotifyStateChanged() => OnChange?.Invoke();
}
