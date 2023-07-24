using Microsoft.AspNetCore.Components;

namespace BlazorProjectFTNetSecu.Client.Pages.Demos
{
    public partial class Demo1EnfantEvent
    {

        [Parameter]
        public int Value { get; set; }

        [Parameter]
        public EventCallback<int> EventEnfant { get; set; }

        void ExecuteEvent()
        {
            EventEnfant.InvokeAsync(Value);
        }

    }
}
