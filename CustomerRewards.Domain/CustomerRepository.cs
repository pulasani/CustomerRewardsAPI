using CustomerRewards.Data;
using CustomerRewards.Model.CustomModels;
using System;
using System.Collections.Generic;

namespace CustomerRewards.Domain
{
    public class CustomerRepository : ICustomerRepository
    {
        private ICustomerDataManager _customerDataManager;
        public CustomerRepository(ICustomerDataManager customerDataManager)
        {
            _customerDataManager = customerDataManager;
        }
        public List<CustomerTransactions> GetCustomerRewardPointsByMonths()
        {
            return _customerDataManager.GetCustomerRewardPointsByMonths();
        }
    }
}
