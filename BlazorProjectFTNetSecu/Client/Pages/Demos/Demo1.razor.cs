using BlazorProjectFTNetSecu.Shared;

namespace BlazorProjectFTNetSecu.Client.Pages.Demos
{
    public partial class Demo1
    {

        public string TwoWayBindingValue { get; set; } = "Hello World";

        public int ValueFromChild { get; set; }

        public List<User> Users { get; set; } = new List<User>()
        {
            new User("Pierre", "Pierre@pierre", "ppthepwd"),
            new User("Paul", "Paul@Paul", "ppthepwd"),
            new User("Jacques", "Jacques@Jacques", "jjthepwd"),
        };

        void AddItem()
        {
            Users.Add(new User("Scoobi", "doo@bidoo", "bdthepwd"));
        }


        void ReceiveEventInvoke(int value)
        {
            ValueFromChild = value;
        }
    }
}
