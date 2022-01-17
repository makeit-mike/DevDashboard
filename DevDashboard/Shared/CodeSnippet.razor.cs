using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http.Json;

namespace DevDashboard.Shared
{
    public partial class CodeSnippet : ComponentBase
    {
        [Inject] private IJSRuntime _js { get; set; } //adding JS

        [Parameter] public RenderFragment ChildContent { get; set; }
        [Parameter] public string Language { get; set; } = "csharp";

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            Console.WriteLine("Calling InvokeVoidAsync.");

            await _js.InvokeVoidAsync("highlightSnippet");
        }
    }
}
