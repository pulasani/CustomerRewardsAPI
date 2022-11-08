using CustomerRewards.Data.MockData;
using CustomerRewards.Model.CustomModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerRewards.Data
{
    public class CustomerDataManager : ICustomerDataManager
    {
        public List<CustomerTransactions> GetCustomerRewardPointsByMonths()
        {
            //Get Customers & Trasaction details - Now i am getting directly from mock data. if it is database i would use IQueryable here.
            var customers = CustomerMockData.Customers();
            var transactions = CustomerMockData.Transactions();
            var monthlyTrans = (from t in transactions
                                group t by new { t.CustId, t.TransactionDate.Month }
                               into grpTran
                                select new
                                {
                                    CustId = grpTran.Key.CustId,
                                    Month = grpTran.Key.Month,
                                    TotalAmount = grpTran.Sum(t=>t.Amount),
                                    NumberofTransactions= grpTran.Count()
                                }).ToList();

            var customerTranDetails = monthlyTrans.Join(customers, m => m.CustId, c => c.CustId, (m, c) => new CustomerTransactions
            {
                CustId = c.CustId,
                FullName = c.FirstName + " "+ c.LastName,
                Month =  new DateTime(2022,m.Month,1).ToString("MMM"),
                TotalAmount = m.TotalAmount,
                NumberOfTransactions = m.NumberofTransactions,
                RewardPoints = CalculateRewardPoints(m.TotalAmount)
            }).ToList();

            return customerTranDetails;
        }

        private double CalculateRewardPoints(double totoalAmount)
        {
            double rewardPoints = 0;
            if(totoalAmount - 100 > 0)
            {
                rewardPoints += (totoalAmount - 100) * 2;
            }
            if(totoalAmount > 50)
            {
                rewardPoints +=  50;
            }
            return rewardPoints;
        }
    }
}
