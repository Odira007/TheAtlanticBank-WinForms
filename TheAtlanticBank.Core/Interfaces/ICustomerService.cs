using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAtlanticBank.Core.Interfaces
{
    public interface ICustomerService
    {
        /// <summary>
        /// Create a new customer
        /// </summary>
        void NewCustomer(string firstName, string lastName, string emailAddress, string password, string pin);  
    }
}
