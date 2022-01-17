using DevDashboard.Classes;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json.Linq;

namespace DevDashboard.Pages
{
    public partial class PlayGround : ComponentBase
    {
        private string randomUser = "N/A";
        private string name = "N/A";
        private string gender = "N/A";
        private string location = "N/A";

        private string imgSrc = "https://picsum.photos/200/300/?blur";


        private async void GetRandomUserJSON()
        {
            try
            {
                string formalName = "michael jones";
                //string[] individualNames = formalName
                //                            .Split(' ');
                //individualNames =           individualNames
                //                            .Select(s => s.ToProperNoun())
                //                            .ToArray();
                //formalName = string.Join(" ", individualNames);

                formalName = string.Join(" ",
                                            formalName
                                            .Split(' ')
                                            .Select(s => s.ToProperNoun())
                                            .ToArray());

                //string[] individualNames = formalName.Split(' ').Select(x => x.ToProperNoun).ToArray();
                //var properIndividualNames = individualNames.Select(x => x.ToProperNoun);
                //formalName = formalName.Split(' ').Select(x => x.ToProperNoun() + " ").ToArray<string>().ToString().Trim();
                Console.WriteLine(formalName);
            }
            catch
            {

            }

            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://api.randomuser.me");
                    var response = await client.GetAsync("https://api.randomuser.me");
                    response.EnsureSuccessStatusCode();

                    var stringResult = await response.Content.ReadAsStringAsync();

                    Console.WriteLine(stringResult);
                    randomUser = stringResult;

                    JToken token = JToken.Parse(stringResult);
                    string firstName = (string)token?.SelectToken("results[0].name.first") ?? "";
                    string lastName = (string)token?.SelectToken("results[0].name.last") ?? "";
                    name = $"{firstName} {lastName}" ?? "";
                    string city = (string)token?.SelectToken("results[0].location.city") ?? "";
                    string state = (string)token?.SelectToken("results[0].location.state") ?? "";
                    location = $"{city}, {state}";
                    string username = (string)token.SelectToken("results[0].login.username");
                    gender = (string)token.SelectToken("results[0].gender");
                    gender = $"{gender[0].ToString().ToUpper()}{gender[1..]}";
                    imgSrc = (string)token.SelectToken("results[0].picture.large");
                }

                catch (HttpRequestException httpRequestException)
                {
                    randomUser = httpRequestException.Message;
                }
                StateHasChanged();
            }
        }
    }
}
