using CustomerRewards.Model.CustomModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerRewards.Domain
{
  public  interface ICustomerRepository
    {
        List<CustomerTransactions> GetCustomerRewardPointsByMonths();
    }
}
