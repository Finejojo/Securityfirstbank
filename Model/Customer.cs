using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurefirstBank.Model
{
    internal class Customer
    {
        public Customer(string fullName, string email, string password)
        {
            FullName = fullName;
            Email = email;
            Password = password;
        }

        public string FullName { get; set; }
        public string Email { get; set; }     
        public string Password { get; set; }

    }
}
