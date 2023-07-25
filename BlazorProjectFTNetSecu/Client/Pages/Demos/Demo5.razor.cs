using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorProjectFTNetSecu.Client.Pages.Demos
{
    public partial class Demo5
    {
        [Inject]
        public IJSRuntime js { get; set; }

        
        public string ValueRecover { get; set; } = "Rien";

        void ActivateJSAlert()
        {
            js.InvokeVoidAsync("alert", ValueRecover);
        }

        async Task ActivateJSPrompt()
        {
            string value = await js.InvokeAsync<string>("prompt", "Inseré une valeur :");
            ValueRecover = value;
        }

        void SaveOnLocalStorage()
        {
            js.InvokeVoidAsync("localStorage.setItem", "Valeur", ValueRecover);
        }

        void ClearLocalStorage()
        {
            js.InvokeVoidAsync("localStorage.clear");
        }

        async Task AlertLSValue()
        {
            string value = await js.InvokeAsync<string>("localStorage.getItem", "Valeur");
            js.InvokeVoidAsync("alert", "Valuer dans le LS :" + value);
        }

    }
}
