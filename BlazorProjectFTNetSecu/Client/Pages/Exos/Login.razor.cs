using BlazorProjectFTNetSecu.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Net.Http.Json;

namespace BlazorProjectFTNetSecu.Client.Pages.Exos
{
    public partial class Login
    {

        bool FailConnection = false;

        LoginAuthForm loginAuthForm = new LoginAuthForm();

        [Inject]
        private HttpClient http { get; set; }

        [Inject]
        private NavigationManager nvm { get; set; }

        [Inject]
        private IJSRuntime js { get; set; }

        private async Task SubmitLogin()
        {
            HttpResponseMessage response = await http.PostAsJsonAsync("Auth/Login", loginAuthForm);
        
            if (response.IsSuccessStatusCode)
            {
                string secretMessage = await response.Content.ReadAsStringAsync();

                await js.InvokeVoidAsync("localStorage.setItem", "secret", secretMessage);

                nvm.NavigateTo("/exo/exo3");

                return;
            }
            
            FailConnection = true;
        
        }

    }
}
