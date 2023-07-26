using BlazorProjectFTNetSecu.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;


namespace BlazorProjectFTNetSecu.Client.Pages.Exos
{
    public partial class Register
    {

        AuthUser NewUser = new AuthUser();

        [Inject]
        public NavigationManager nvm { get; set; }

        [Inject]
        private HttpClient http { get; set; }

        public async Task SubmitForm() 
        {
             HttpResponseMessage response = await http.PostAsJsonAsync("Auth/Register", NewUser);
        
            if (response.IsSuccessStatusCode)
            {
                nvm.NavigateTo("/exo/exo3");
            }
        
        }

    }
}
