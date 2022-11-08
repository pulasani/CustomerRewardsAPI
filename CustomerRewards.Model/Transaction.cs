using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerRewards.Model
{
   public class Transaction
    {
        public int TransactionId { get; set; }
        public int CustId { get; set; }
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}
