using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using DevDashboard.Models;

namespace DevDashboard.Pages
{
    public partial class CodeReviews : ComponentBase 
    {
        public enum ReviewStatus { InProg, Approved, Staged, Released }

        private CodeReview[]? codeReviews;

        protected override async Task OnInitializedAsync()
        {
            codeReviews = await Http.GetFromJsonAsync<CodeReview[]>("sample-data/reviews.json");
        }

        /*
            Using JSON Generator.
                '{{repeat(5, 7)}}',
                {
                    id: '{{index()}}',

                    application: '{{random("Dashboard", "ToDoApp", "Tracker")}}',

                    ReviewDate: '{{date(new Date(2014, 0, 1), new Date(), "YYYY-MM-ddThh:mm:ss Z")}}',

                    ReleaseDate: '{{date(new Date(2014, 0, 1), new Date(), "YYYY-MM-ddThh:mm:ss Z")}}',

                    approver1: '{{firstName()}} {{surname()}}',

                    approver2: '{{firstName()}} {{surname()}}',

                    status: '{{random("InProg", "Approved", "Released")}}'
                }
        */


        public void AddItemForCodeReview()
        {
            throw new NotImplementedException();
        }

        public void UpdateCodeReviewItem()
        {
            throw new NotImplementedException();
        }

        public void RemoveCodeReviewItem()
        {
            throw new NotImplementedException();
        }

        public void SendNotification()
        {
            throw new NotImplementedException();
            // ToDo: Possibly link to a Notification Service that dynamically builds the emails.
            // Ideally code should match ToDoList, and be a simple method call.
        }
    }
}


