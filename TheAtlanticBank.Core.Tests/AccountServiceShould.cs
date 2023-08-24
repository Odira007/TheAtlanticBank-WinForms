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
        private Account _beneficiaryAccount;

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

        public void SetBeneficiary()
        {
            _beneficiaryAccount = new Account(2, "Odira Ikewelugo", "2156739543", AccountType.Current, 2)
            {
                Balance = 8000.0M
            };
            DataStore.accounts.Add(_beneficiaryAccount);
        }


        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckDepositSuccess()
        {
            DataStore.accounts.Clear();

            //Arrange
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
            DataStore.accounts.Clear();

            //Arrange
            SetUp();

            //Assert
            Assert.Throws<FormatException>(() => _sut.Deposit(_account.AccountId, -5000.0M));
            _message.WriteLine("Created a failed deposit");
        }

        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckWithdrawalSuccess()
        {
            DataStore.accounts.Clear();

            //Arrange
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
            DataStore.accounts.Clear();

            //Arrange
            SetUp();

            //Assert
            Assert.Throws<InvalidOperationException>(() => _sut.Withdraw(_account.AccountId, 19500.0M));
            _message.WriteLine("Ensured that savings account cannot withdraw past min balance of 1000");
        }

        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckInvalidWithdrawalAmount()
        {
            DataStore.accounts.Clear();

            //Arrange
            SetUp();

            //Assert
            Assert.Throws<FormatException>(() => _sut.Withdraw(_account.AccountId, -500.0M));
            _message.WriteLine("Checked for negative withdrawal amount");
        }

        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckWithdrawalAmountGreaterThanBalance()
        {
            DataStore.accounts.Clear();

            //Arrange
            SetUp();

            //Assert
            Assert.Throws<InvalidOperationException>(() => _sut.Withdraw(_account.AccountId, 21000.0M));
            _message.WriteLine("Checked for insufficient funds for withdrawal");
        }

        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckTransferSuccess()
        {
            DataStore.accounts.Clear();

            //Arrange
            SetUp();
            SetBeneficiary();

            //Act
            _sut.Transfer(_account.AccountId, _beneficiaryAccount.AccountId,  7000.0M);

            //Assert
            Assert.Equal(13000.0M, _account.Balance);
            Assert.Equal(15000.0M, _beneficiaryAccount.Balance);
            _message.WriteLine("Created successful transfer");
        }

        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckTransferAmountGreaterThanBalance()
        {
            DataStore.accounts.Clear();

            //Arrange
            SetUp();
            SetBeneficiary();

            //Assert
            Assert.Throws<InvalidOperationException>(() => 
                                _sut.Transfer(_account.AccountId, _beneficiaryAccount.AccountId, 21000.0M));
            _message.WriteLine("Checked for insufficient funds for transfer");
        }

        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckMaxTransferrableForSavingsAccountReached()
        {
            DataStore.accounts.Clear();

            //Arrange
            SetUp();
            SetBeneficiary();

            //Assert
            Assert.Throws<InvalidOperationException>(() => 
                                    _sut.Transfer(_account.AccountId, _beneficiaryAccount.AccountId, 19500.0M));
            _message.WriteLine("Ensured that savings account cannot transfer past minimum balance for savings - 1000");
        }

        [Fact]
        [Trait("Category", "Transaction")]
        public void CheckInvalidTransferAmount()
        {
            DataStore.accounts.Clear();

            //Arrange
            SetUp();
            SetBeneficiary();

            //Assert
            Assert.Throws<FormatException>(() =>
                                    _sut.Transfer(_account.AccountId, _beneficiaryAccount.AccountId, -10500.0M));
            _message.WriteLine("Checked for invalid transfer amount");
        }
    }
}
