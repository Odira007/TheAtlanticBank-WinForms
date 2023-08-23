using Xunit;
using System.Collections.Generic;
using TheAtlanticBank.Common;
using TheAtlanticBank.Core.Services;
using TheAtlanticBank.Data;
using TheAtlanticBank.Entities;


namespace TheAtlanticBank.Core.Tests
{
    public class TransactionServiceShould
    {
        [Fact]
        public void CheckTransactionCreated()
        {
            //Arrange
            var sut = new TransactionService();
            var account = new Account(1, "Odira Ikewelugo", "2178290372", AccountType.Savings, 2);
            DataStore.accounts.Add(account);

            var trans1 = new Transaction(1, "Deposit by Odira", 2000.0M, account.AccountId);
            var trans2 = new Transaction(2, "Deposit by Odira", 3500.0M, account.AccountId);

            List<Transaction> expected = new List<Transaction> { trans1, trans2 };

            //Act
            sut.CreateTransaction(trans1.Description, trans1.Amount, account.AccountId);
            sut.CreateTransaction(trans2.Description, trans2.Amount, account.AccountId);

            //Assert
            for (int i = 0; i <= 1; i++)
            {
                Assert.Equal(expected[i].TransactionId, DataStore.transactions[i].TransactionId);
                Assert.Equal(expected[i].Description, DataStore.transactions[i].Description);
                Assert.Equal(expected[i].Amount, DataStore.transactions[i].Amount);
                Assert.Equal(expected[i].AccId, DataStore.transactions[i].AccId);
            }
        }

    }
}
