using Xunit;
using Xunit.Abstractions;
using System;
using TheAtlanticBank.Entities;
using TheAtlanticBank.Common;
using TheAtlanticBank.Data;
using TheAtlanticBank.Core.Services;
using Moq;
using TheAtlanticBank.Core.Interfaces;
using TheAtlanticBank.Core.Authentication;

namespace TheAtlanticBank.Core.Tests
{
    public class AccountServiceShould
    {
        private readonly Mock<ITransactionService> _mock = new Mock<ITransactionService>();
        private readonly AccountService _sut;
        private readonly ITestOutputHelper _message;
        private Customer _customer;
        private Account _account;

        public AccountServiceShould(ITestOutputHelper message)
        {
            _message = message;
            _sut = new AccountService(_mock.Object);

        }

        public void SetUp()
        {
            _customer = new Customer(1, "Somto", "Ikewelugo", "somtoikewelugo@gmail.com", "somto@#23", "3535");
            DataStore.customers.Add(_customer);

            Authenticate.Login(_customer.EmailAddress, _customer.Password);
            _account = new Account(1, Authenticate.customer.FullName, "2147893843", AccountType.Savings, 1)
            {
                Balance = 20000.0M
            };
            DataStore.accounts.Add(_account);
        }


        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckDepositSuccess()
        {
            //Arrange
            DataStore.accounts.Clear();

            SetUp();
            var expected = 25000.0M;

            //Act
            _sut.Deposit(_account.AccountId, 5000.0M);

            //Assert
            Assert.Equal(expected, _account.Balance);
            _message.WriteLine("Created a successful deposit");
        }

        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckDepositFailure()
        {
            //Arrange
            DataStore.accounts.Clear();
            SetUp();

            //Assert
            Assert.Throws<FormatException>(() => _sut.Deposit(_account.AccountId, -5000.0M));
            _message.WriteLine("Created a failed deposit");
        }

        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckWithdrawalSuccess()
        {
            //Arrange
            DataStore.accounts.Clear();

            SetUp();

            var expected = 15000.0M;

            //Assert
            Assert.Equal(expected, _sut.Withdraw(_account.AccountId, 5000.0M));
            _message.WriteLine("Created a successful withdrawal");
        }

        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckMinBalanceForSavingsAccountReached()
        {
            //Arrange
            DataStore.customers.Clear();
            DataStore.accounts.Clear();

            var customer = new Customer(1, "Somto", "Ikewelugo", "somtoikewelugo@gmail.com", "somto@#23", "3535");
            DataStore.customers.Add(customer);

            Authenticate.Login(customer.EmailAddress, customer.Password);
            var account = new Account(1, Authenticate.customer.FullName, "2147893843", AccountType.Savings, 1)
            {
                Balance = 1000.0M
            };

            DataStore.accounts.Add(account);

            //Assert
            Assert.Throws<InvalidOperationException>(() => _sut.Withdraw(account.AccountId, 500.0M));
            _message.WriteLine("Ensure savings account cannot withdraw past min balance of 1000");
        }

        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckInvalidWithdrawalAmount()
        {
            //Arrange
            DataStore.customers.Clear();
            DataStore.accounts.Clear();

            var customer = new Customer(1, "Somto", "Ikewelugo", "somtoikewelugo@gmail.com", "somto@#23", "3535");
            DataStore.customers.Add(customer);

            Authenticate.Login(customer.EmailAddress, customer.Password);
            var account = new Account(1, Authenticate.customer.FullName, "2147893843", AccountType.Savings, 1)
            {
                Balance = 1000.0M
            };

            DataStore.accounts.Add(account);

            //Assert
            Assert.Throws<FormatException>(() => _sut.Withdraw(account.AccountId, -500.0M));
            _message.WriteLine("Check for negative input value");
        }

        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckAmountGreaterThanBalance()
        {
            //Arrange
            DataStore.customers.Clear();
            DataStore.accounts.Clear();

            var customer = new Customer(1, "Somto", "Ikewelugo", "somtoikewelugo@gmail.com", "somto@#23", "3535");
            DataStore.customers.Add(customer);

            Authenticate.Login(customer.EmailAddress, customer.Password);
            var account = new Account(1, Authenticate.customer.FullName, "2147893843", AccountType.Savings, 1)
            {
                Balance = 4000.0M
            };

            DataStore.accounts.Add(account);

            //Assert
            Assert.Throws<InvalidOperationException>(() => _sut.Withdraw(account.AccountId, 6000.0M));
            _message.WriteLine("Check insufficient funds");
        }

        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckTransferSuccess()
        {
            //Arrange
            DataStore.customers.Clear();
            DataStore.accounts.Clear();

            var customer = new Customer(1, "Somto", "Ikewelugo", "somtoikewelugo@gmail.com", "somto@#23", "3535");
            DataStore.customers.Add(customer);

            Authenticate.Login(customer.EmailAddress, customer.Password);
            var sourceAccount = new Account(1, Authenticate.customer.FullName, "2147893843", AccountType.Savings, 1)
            {
                Balance = 4000.0M
            };
            DataStore.accounts.Add(sourceAccount);

            var beneficiaryAccount = new Account(2, "Odira Ikewelugo", "2156739543", AccountType.Current, 2)
            {
                Balance = 8000.0M
            };
            DataStore.accounts.Add(beneficiaryAccount);

            var expected1 = 2000.0M;
            var expected2 = 10000.0M;

            //Act
            _sut.Transfer(sourceAccount.AccountId, beneficiaryAccount.AccountId,  2000.0M);

            //Assert
            Assert.Equal(expected2, beneficiaryAccount.Balance);
            Assert.Equal(expected1, sourceAccount.Balance);
        }
    }
}
