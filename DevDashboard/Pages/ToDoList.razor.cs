using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using DevDashboard.Models;

namespace DevDashboard.Pages
{
    public partial class ToDoList : ComponentBase
    { 
        public enum ToDoStatus { Open, Complete, Withdrawn }
        private ToDoItem[]? toDoItems;

        protected override async Task OnInitializedAsync()
        {
            toDoItems = await Http.GetFromJsonAsync<ToDoItem[]>("sample-data/todo.json");
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
