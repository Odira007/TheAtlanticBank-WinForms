using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheAtlanticBank.Data;
using TheAtlanticBank.Entities;

namespace TheAtlanticBank.Helpers
{
    public class FileOperations
    {
        public FileOperations() { }
        private static string directory = Environment.CurrentDirectory;
        public static string path = Path.Combine(directory, "customers.json");
        public static string path2 = Path.Combine(directory, "accounts.json");
        public static string path3 = Path.Combine(directory, "transactions.json");

        /// <summary>
        /// Save all customers to a file
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static async Task SaveCustomers(List<Customer> customers)
        {
            string filePath = path;
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    string json = JsonConvert.SerializeObject(customers) + Environment.NewLine;

                    await sw.WriteAsync(json);
                    sw.Close();
                }
            }
            catch { }
        }



        /// <summary>
        /// Save accounts to a file
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public static async Task SaveAccounts(List<Account> accounts)
        {
            string filePath = path2;
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    string json = JsonConvert.SerializeObject(accounts) + Environment.NewLine;

                    await sw.WriteAsync(json);
                    sw.Close();
                }
            }
            catch { }
        }

        /// <summary>
        /// Save transactions to a file
        /// </summary>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static async Task SaveTransactions(List<Transaction> transactions)
        {
            string filePath = path3;
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    string json = JsonConvert.SerializeObject(transactions) + Environment.NewLine;

                    await sw.WriteAsync(json);
                    sw.Close();
                }
            }
            catch { }
        }

        public static async Task<bool> SaveToDatabaseAsync()
        {
            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);

            try
            {
                await SaveCustomers(DataStore.customers);
                await SaveAccounts(DataStore.accounts);
                await SaveTransactions(DataStore.transactions);
                return true;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
                return false;
            }
        }

        public static List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();

            try
            {
                string getAllLines = File.ReadAllText(path);

                customers = JsonConvert.DeserializeObject<List<Customer>>(getAllLines);
            }
            catch { }

            return customers;
        }

        public static List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();

            try
            {
                string getAllLines = File.ReadAllText(path2);

                accounts = JsonConvert.DeserializeObject<List<Account>>(getAllLines);
            }
            catch { }

            return accounts;
        }

        public static List<Transaction> GetTransactions()
        {
            List<Transaction> transactions = new List<Transaction>();

            try
            {
                string getAllLines = File.ReadAllText(path3);

                transactions = JsonConvert.DeserializeObject<List<Transaction>>(getAllLines);
            }
            catch { }

            return transactions;
        }

        /// <summary>
        /// Delete a customer's account from a file
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteAccount(int id)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path2))
                {
                    string line;
                    string singleLine = sr.ReadLine();
                    while ((line = singleLine) != null)
                    {
                        string[] sp = line.Split(';');
                        if (int.Parse(sp[0].Substring(sp[0].IndexOf(":")) + 1) == id)
                        {
                            singleLine = null;
                        }
                    }
                }
            }
            catch { }
        }
    }
}
