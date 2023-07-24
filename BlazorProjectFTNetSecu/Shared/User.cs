using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorProjectFTNetSecu.Shared
{
    public class User
    {
        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
