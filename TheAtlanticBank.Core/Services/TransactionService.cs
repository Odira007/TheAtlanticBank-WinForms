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
    public class TransactionService : ITransactionService
    {
        public static int IdCount { get; set; } = 0;

        public async void CreateTransaction(string description, decimal amount, int accountId)
        {
            IdCount++;
            var transaction = new Transaction(IdCount, description, amount, accountId);
            DataStore.transactions.Add(transaction);
            var account = DataStore.accounts.First(acc => acc.AccountId == accountId);

            transaction.Balance = account.Balance;
            await FileOperations.SaveTransactions(DataStore.transactions);
        }

        public List<Transaction> BankStatement(int transId) =>
                    DataStore.transactions.Where(trans => trans.AccId == transId).ToList();
    }
}
