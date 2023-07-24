using BlazorProjectFTNetSecu.Shared;
using Microsoft.AspNetCore.Components;

namespace BlazorProjectFTNetSecu.Client.Pages.Shared
{
    public partial class QuestionComponent
    {
        [Parameter]
        public string UserName { get; set; }

        [Parameter] 
        public int QuestionNbr { get; set; }

        [Parameter]
        public Question Question { get; set; }

        [Parameter]
        public EventCallback<bool> ResponseEvent { get; set; }

        void Reponse(bool reponse)
        {
            ResponseEvent.InvokeAsync(reponse == Question.Reponse);
        }

    }
}
