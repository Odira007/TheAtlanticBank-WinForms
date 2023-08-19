using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAtlanticBank.Entities
{
    public class Customer
    {
        public Customer(int id, string firstName, string lastName, string emailAddress, string password, string pin)
        {
            Id = Id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            Password = password;
            Pin = pin;
            DateOfCreation = DateTime.Now.ToString("MM/dd/yyyy");
        }
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Pin { get; set; }
        public string DateOfCreation { get; set; }
    }
}
