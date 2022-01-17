using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace DevDashboard.Shared
{
    public partial class MainLayout : ComponentBase
    {
        const string message = "null reply"; //TO DO: Find out why Invoking JS Requires input? 

        private string[] args = { message };

        private async Task Alert()
        {
            await JS.InvokeAsync<string>("showAbout", args); //This is an easy way to call JS method
        }
    }
}
