using NUnit.Framework;
using Moq;
using CustomerRewards.Domain;
using CustomerRewards.Model.CustomModels;
using System.Collections.Generic;
using CustomerRewardsAPI.Controllers;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace CustomerRewards.Tests
{
    public class CustomerControllerTests
    {
        Mock<ICustomerRepository> _mockCustomerRepository;
        CustomerController customerController;
        
        [SetUp]
        public void Setup()
        {
            _mockCustomerRepository.Setup(p => p.GetCustomerRewardPointsByMonths()).Returns(MockCustomerTransactionData());
        }

        [Test]
        public void GetCustomersRewardPoints_Test()
        {
            var mock = new Mock<ILogger<CustomerController>>();
            ILogger<CustomerController> logger = mock.Object;
            logger = Mock.Of<ILogger<CustomerController>>();
            customerController = new CustomerController(_mockCustomerRepository.Object, logger);
            var custTransactionData = customerController.GetCustomersRewardPoints().Result; 
            Assert.IsNotNull(custTransactionData);
        }

        public List<CustomerTransactions> MockCustomerTransactionData()
        {
            return new List<CustomerTransactions>
            {
                new CustomerTransactions{ CustId = 1, TotalAmount = 120,  Month = "Nov", RewardPoints = 90}
            };
        }
    }
}