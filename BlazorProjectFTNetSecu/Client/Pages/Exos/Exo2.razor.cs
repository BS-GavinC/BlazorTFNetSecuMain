using BlazorProjectFTNetSecu.Shared;

namespace BlazorProjectFTNetSecu.Client.Pages.Exos
{
    public partial class Exo2
    {

        public Exo2()
        {
            ExoFormData = new ExoForm();
        }

        ExoForm ExoFormData { get; set; }

        public bool FormValidated { get; set; } = false;

        void OnValidSubmit()
        {
            Console.WriteLine(ExoFormData.Color);
            FormValidated = true;
        }


    }
}
