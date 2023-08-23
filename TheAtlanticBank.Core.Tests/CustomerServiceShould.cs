using Xunit;
using System.Collections.Generic;
using TheAtlanticBank.Core.Services;
using TheAtlanticBank.Data;
using TheAtlanticBank.Entities;

namespace TheAtlanticBank.Core.Tests
{
    public class CustomerServiceShould
    {
        [Fact]
        public void CheckCustomerCreated()
        {
            //Arrange
            var sut = new CustomerService();

            var expected = new Customer(1, "Somto", "Ikewelugo", "somtoikewelugo@gmail.com", "somto@#23", "3535");

            //Act
            sut.NewCustomer(expected.FirstName, expected.LastName, expected.EmailAddress, expected.Password, expected.Pin);

            //Assert
            Assert.Equal(expected.Id, DataStore.customers[0].Id);
            Assert.Equal(expected.FirstName, DataStore.customers[0].FirstName);
            Assert.Equal(expected.LastName, DataStore.customers[0].LastName);
            Assert.Equal(expected.EmailAddress, DataStore.customers[0].EmailAddress);
            Assert.Equal(expected.Password, DataStore.customers[0].Password);
            Assert.Equal(expected.Pin, DataStore.customers[0].Pin);
        }
    }
}
