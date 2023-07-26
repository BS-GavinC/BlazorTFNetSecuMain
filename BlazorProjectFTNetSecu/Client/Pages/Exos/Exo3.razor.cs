using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorProjectFTNetSecu.Client.Pages.Exos
{
    public partial class Exo3
    {

        bool isConnected = false;

        string secretMessage = "";

        [Inject]
        public IJSRuntime js { get; set; }

        protected async override Task OnInitializedAsync()
        {
            
            await CheckConnection();
        }

        private async Task CheckConnection()
        {
            string message = await js.InvokeAsync<string>("localStorage.getItem", "secret");

            isConnected = !string.IsNullOrEmpty(message);

            if (isConnected)
            {
                secretMessage = message;
            }
        }

        private async Task Disconnect()
        {
            await js.InvokeVoidAsync("localStorage.clear");
            await CheckConnection();

        }

    }
}
