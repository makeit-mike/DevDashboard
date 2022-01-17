using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

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

        public class ToDoItem
        {
            public int ID { get; set; }
            public string Task { get; set; }
            public string Owner { get; set; }
            public string Comments { get; set; }
            public string Status { get; set; }  // ToDo Convert to Enum.
            public DateTime DateTimeAdded { get; set; }
            public string DateDue { get; set; } // ToDo Convert to DateTime.
            public DateTime DateTimeCompleted { get; set; }
        }
    }
}
