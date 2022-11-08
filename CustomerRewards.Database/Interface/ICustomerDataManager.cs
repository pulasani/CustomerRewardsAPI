using CustomerRewards.Model.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerRewards.Data
{
   public interface ICustomerDataManager
    {
        List<CustomerTransactions> GetCustomerRewardPointsByMonths();
    }
}
