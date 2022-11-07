using CustomerRewards.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerRewards.Data.MockData
{
   public static class CustomerMockData
    {
        //Customer Details
        public static List<Customer> Customers()
        {
            return new List<Customer>
            {
                new Customer{ CustId = 1, FirstName = "Jhon", LastName = "J", Gender="M", PhoneNumber ="000000000"},
                new Customer{ CustId = 2, FirstName = "Smith", LastName = "S", Gender="M", PhoneNumber ="000000000"},
            };
        }

        //Customer Transactions Details
        public static List<Transaction> Transactions()
        {
            return new List<Transaction>
            {
                new Transaction{ CustId = 1, TransactionId = 1,  Amount = 120, TransactionDate = DateTime.Now},
                new Transaction{ CustId = 1, TransactionId = 2,  Amount = 650, TransactionDate = DateTime.Now},
                new Transaction{ CustId = 1, TransactionId = 3,  Amount = 15, TransactionDate = DateTime.Now},
                new Transaction{ CustId = 2, TransactionId = 1,  Amount = 90, TransactionDate = DateTime.Now.AddMonths(-1)},
                new Transaction{ CustId = 2, TransactionId = 2,  Amount = 550, TransactionDate = DateTime.Now.AddMonths(-1)},
                new Transaction{ CustId = 2, TransactionId = 3,  Amount = 40, TransactionDate = DateTime.Now.AddMonths(-1)},
            };
        }
    }
}
