using BlazorProjectFTNetSecu.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorProjectFTNetSecu.Client.Pages.Demos
{
    public partial class Demo4
    {

        [Inject]
        public HttpClient http { get; set; }

        public string ResponseMessage { get; set; } = "Aucune reponse";

        void ChangeMessage(string message)
        {
            ResponseMessage = message;
        }

        async Task SendGet()
        {
            

            HttpResponseMessage Response = await http.GetAsync("Test");

            

            if (Response.IsSuccessStatusCode) 
            {
                ResponseMessage = await Response.Content.ReadAsStringAsync();
            }
        }


        public async Task SendPost()
        {
            RegisterForm registerForm = new RegisterForm()
            {
                Password = "password",
                ConfirmationPassword = "password",
                Email = "email@mail.be",
                Firstname = "firstname",
                Lastname = "lastname",
            };

            User user;
            HttpResponseMessage response = await http.PostAsJsonAsync("Test", registerForm);
          
            if (response.IsSuccessStatusCode)
            {
                user = await response.Content.ReadFromJsonAsync<User>();


                Console.WriteLine("Print Value : " + user.Email);


                ChangeMessage($"POST : {user.Name}, {user.Email}, {user.Password}");
                
            }

            
            

        }

    }
}
