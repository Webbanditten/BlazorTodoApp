using Microsoft.AspNetCore.Components;

namespace BlazorApp.Components.RenderTreeDemo;
public class RenderTreeDemo : ComponentBase
{
  [Parameter, EditorRequired] public string? Title { get; set; }

  protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder builder)
  {
    builder.AddMarkupContent(0, "<h1>Hello from Render Tree</h1><br />Welcome to your new app.");
    builder.OpenElement(0, "h1");
    builder.AddContent(1, this.Title);
    builder.CloseElement();
  }
}
