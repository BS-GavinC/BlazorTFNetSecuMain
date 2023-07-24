using BlazorProjectFTNetSecu.Shared;

namespace BlazorProjectFTNetSecu.Client.Pages.Demos
{
    public partial class Demo2
    {

        RegisterForm RegisterFormulaire { get; set; } = new RegisterForm();


        void Submit()
        {
            Console.WriteLine("Submit Executé");
        }

    }
}
