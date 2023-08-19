using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAtlanticBank.Entities;

namespace TheAtlanticBank.Data
{
    public class DataStore
    {
        public static List<Customer> customers { get; set; } = new List<Customer>();
        public static List<Account> accounts { get; set; } = new List<Account>();
        public static List<Transaction> transactions { get; set; } = new List<Transaction>();
    }
}
