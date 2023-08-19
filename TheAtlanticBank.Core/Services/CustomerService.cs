using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAtlanticBank.Core.Interfaces;
using TheAtlanticBank.Data;
using TheAtlanticBank.Entities;
using TheAtlanticBank.Helpers;

namespace TheAtlanticBank.Core.Services
{
    public class CustomerService : ICustomerService
    {
        public static int IdCount { get; set; }

        public async void NewCustomer(string firstName, string lastName, string emailAddress, string password, string pin)
        {
            IdCount++;

            var customer = new Customer(IdCount, firstName, lastName, emailAddress, password, pin);

            DataStore.customers.Add(customer);
            await FileOperations.SaveCustomers(DataStore.customers);
        }
    }
}
