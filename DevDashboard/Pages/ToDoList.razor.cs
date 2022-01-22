using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using DevDashboard.Models;

namespace DevDashboard.Pages
{
    public partial class ToDoList : ComponentBase
    {
        public enum ToDoStatus { Open, Complete, Withdrawn }
        private ToDoItem[]? Items_All, Items_ToDo, Items_InProg, Items_Done;

        protected override async Task OnInitializedAsync()
        {
            Items_All = await Http.GetFromJsonAsync<ToDoItem[]>("sample-data/todoItems.json");
            if (Items_All is null) { return; }

            Items_ToDo = Items_All.Where(x => x.Status == "To Do").ToArray();
            Items_InProg = Items_All.Where(x => x.Status == "In Progress").ToArray();
            Items_Done = Items_All.Where(x => x.Status == "Done").ToArray();
        }

        public void AddToDoItem()
        {
            throw new NotImplementedException();
        }

        public void UpdateToDoItem()
        {
            throw new NotImplementedException();
        }

        public void RemoveToDoItem()
        {
            throw new NotImplementedException();
        }

        public void SendNotification()
        {
            throw new NotImplementedException();
            // ToDo: Possibly link to a Notification Service that dynamically builds the emails.
            // Ideally code should match CodeReviews, and be a simple method call.
        }




    }
}
