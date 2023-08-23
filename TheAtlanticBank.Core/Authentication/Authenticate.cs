using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAtlanticBank.Data;
using TheAtlanticBank.Entities;
using TheAtlanticBank.Helpers;

namespace TheAtlanticBank.Core.Authentication
{
    public class Authenticate
    {
        public static Customer customer { get; set; }
        public static Account selectedAccount { get; set; }

        /// <summary>
        /// Authenticate a user's login
        /// </summary>
        /// <returns>Returns true if authentication details pass, else false</returns>
        public static bool Login(string email, string password)
        {
            Customer user = DataStore.customers.FirstOrDefault(c => c.EmailAddress == email & c.Password == password);
            if (user == null)
            {
                return false;
            }
            customer = user;
            selectedAccount = DataStore.accounts.FirstOrDefault(x => x.AccountId == user.Id);
            return true;
        }

        /// <summary>
        /// Let's a user log out
        /// </summary>
        public static void Logout()
        {
            customer = null;
        }
    }
}
